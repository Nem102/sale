using ClosedXML.Excel;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CuaHangMayTinh
{
    public partial class Giohang1 : UserControl
    {
        DataTable dtSanPham = new DataTable();
        DataTable dtGioHang = new DataTable();

        public Giohang1()
        {
            InitializeComponent();
        }

        private void Giohang1_Load(object sender, EventArgs e)
        {
            LoadSanPham();

            // Cấu trúc giỏ hàng
            dtGioHang.Columns.Add("MaSP", typeof(string));
            dtGioHang.Columns.Add("TenSP", typeof(string));
            dtGioHang.Columns.Add("DonGia", typeof(decimal));
            dtGioHang.Columns.Add("SoLuong", typeof(int));
            dtGioHang.Columns.Add("ThanhTien", typeof(decimal), "DonGia * SoLuong");

            DataGridViewdgvGioHang.DataSource = dtGioHang;

            // Header
            DataGridViewdgvGioHang.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            DataGridViewdgvGioHang.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            DataGridViewdgvGioHang.Columns["DonGia"].HeaderText = "Đơn giá";
            DataGridViewdgvGioHang.Columns["SoLuong"].HeaderText = "Số lượng";
            DataGridViewdgvGioHang.Columns["ThanhTien"].HeaderText = "Thành tiền";
        }

        private void LoadSanPham()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT ma_hang, tenhang, giaban, soluong FROM HangBan";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    dtSanPham.Clear();
                    da.Fill(dtSanPham);

                    DataGridViewdgvSanPham.DataSource = dtSanPham.DefaultView;

                    DataGridViewdgvSanPham.Columns["ma_hang"].HeaderText = "Mã SP";
                    DataGridViewdgvSanPham.Columns["tenhang"].HeaderText = "Tên sản phẩm";
                    DataGridViewdgvSanPham.Columns["giaban"].HeaderText = "Giá bán";
                    DataGridViewdgvSanPham.Columns["soluong"].HeaderText = "SL tồn kho";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi LoadSanPham: " + ex.Message);
            }
        }

        // Double click -> thêm vào giỏ
        private void DataGridViewdgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maSP = DataGridViewdgvSanPham.Rows[e.RowIndex].Cells["ma_hang"].Value.ToString();
                string tenSP = DataGridViewdgvSanPham.Rows[e.RowIndex].Cells["tenhang"].Value.ToString();
                decimal giaSP = Convert.ToDecimal(DataGridViewdgvSanPham.Rows[e.RowIndex].Cells["giaban"].Value);

                DataRow[] existing = dtGioHang.Select("MaSP = '" + maSP + "'");
                if (existing.Length > 0)
                {
                    existing[0]["SoLuong"] = Convert.ToInt32(existing[0]["SoLuong"]) + 1;
                }
                else
                {
                    dtGioHang.Rows.Add(maSP, tenSP, giaSP, 1);
                }

                TinhTongTien();
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (DataGridViewdgvGioHang.CurrentRow != null)
            {
                DataGridViewdgvGioHang.Rows.RemoveAt(DataGridViewdgvGioHang.CurrentRow.Index);
                TinhTongTien();
            }
        }

        // 🔥 Thanh toán
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtGioHang.Rows.Count == 0)
                {
                    MessageBox.Show("Giỏ hàng trống!");
                    return;
                }

                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    SqlTransaction tran = conn.BeginTransaction();

                    try
                    {
                        // Tạo mã hóa đơn
                        string maHD = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");

                        string insertHD = "INSERT INTO HoaDonBan(ma_hd, ngaylap, id_nv, id_kh, tongtien) " +
                                          "OUTPUT INSERTED.id_hd " +
                                          "VALUES(@ma_hd, GETDATE(), 1, 1, @tongtien)";

                        SqlCommand cmdHD = new SqlCommand(insertHD, conn, tran);
                        cmdHD.Parameters.AddWithValue("@ma_hd", maHD);
                        cmdHD.Parameters.AddWithValue("@tongtien", Convert.ToInt32(lblTongTien.Text.Replace(",", "")));

                        int idHD = (int)cmdHD.ExecuteScalar();

                        foreach (DataRow r in dtGioHang.Rows)
                        {
                            string insertCT = "INSERT INTO ChiTietHoaDon(id_hd, id_hang, soluong, dongia) " +
                                              "SELECT @id_hd, id_hang, @soluong, @dongia FROM HangBan WHERE ma_hang=@ma_hang";

                            SqlCommand cmdCT = new SqlCommand(insertCT, conn, tran);
                            cmdCT.Parameters.AddWithValue("@id_hd", idHD);
                            cmdCT.Parameters.AddWithValue("@ma_hang", r["MaSP"]);
                            cmdCT.Parameters.AddWithValue("@soluong", r["SoLuong"]);
                            cmdCT.Parameters.AddWithValue("@dongia", r["DonGia"]);
                            cmdCT.ExecuteNonQuery();
                        }

                        tran.Commit();

                        MessageBox.Show("Thanh toán thành công! Mã HĐ: " + maHD, "Thông báo");

                        // Xuất Excel ngay sau khi thanh toán
                        XuatExcel(maHD);

                        dtGioHang.Clear();
                        lblTongTien.Text = "0";
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Lỗi lưu hóa đơn: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ThanhToan: " + ex.Message);
            }
        }

        // 🔥 Xuất Excel hóa đơn
        private void XuatExcel(string maHD)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;

                Excel.Workbook workbook = excelApp.Workbooks.Add(Missing.Value);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = "HoaDon";

                worksheet.Range["A1", "D1"].Merge();
                worksheet.Range["A1"].Value = "HÓA ĐƠN BÁN HÀNG";
                worksheet.Range["A1"].Font.Size = 16;
                worksheet.Range["A1"].Font.Bold = true;
                worksheet.Range["A1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                worksheet.Range["A2", "D2"].Merge();
                worksheet.Range["A2"].Value = $"Mã hóa đơn: {maHD} - Ngày: {DateTime.Now:dd/MM/yyyy HH:mm}";
                worksheet.Range["A2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

                worksheet.Cells[4, 1] = "STT";
                worksheet.Cells[4, 2] = "Tên sản phẩm";
                worksheet.Cells[4, 3] = "Số lượng";
                worksheet.Cells[4, 4] = "Thành tiền";

                Excel.Range header = worksheet.Range["A4", "D4"];
                header.Font.Bold = true;
                header.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                header.Interior.Color = ColorTranslator.ToOle(Color.LightGray);

                int row = 5;
                int stt = 1;
                foreach (DataRow r in dtGioHang.Rows)
                {
                    worksheet.Cells[row, 1] = stt++;
                    worksheet.Cells[row, 2] = r["TenSP"];
                    worksheet.Cells[row, 3] = r["SoLuong"];
                    worksheet.Cells[row, 4] = r["ThanhTien"];
                    row++;
                }

                Excel.Range dataRange = worksheet.Range["A4", "D" + (row - 1)];
                dataRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                dataRange.Columns.AutoFit();

                worksheet.Range["C" + row].Value = "Tổng cộng:";
                worksheet.Range["C" + row].Font.Bold = true;
                worksheet.Range["D" + row].Value = lblTongTien.Text;
                worksheet.Range["D" + row].Font.Bold = true;
                worksheet.Range["D" + row].Interior.Color = ColorTranslator.ToOle(Color.Yellow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Xuất Excel: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            DataView dv = dtSanPham.DefaultView;

            dv.RowFilter = !string.IsNullOrEmpty(keyword)
                ? string.Format("tenhang LIKE '%{0}%'", keyword)
                : "";

            DataGridViewdgvSanPham.DataSource = dv;
        }

        private void TinhTongTien()
        {
            decimal tong = 0;
            foreach (DataRow row in dtGioHang.Rows)
            {
                tong += Convert.ToDecimal(row["ThanhTien"]);
            }
            lblTongTien.Text = tong.ToString("N0");
        }

        // Event trống
        private void DataGridViewdgvGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void txtTimKiem_TextChanged(object sender, EventArgs e) { }
        private void DataGridViewdgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void DataGridViewdgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cellValue = DataGridViewdgvSanPham.Rows[e.RowIndex].Cells["hinhanh"].Value;
                if (cellValue != null && File.Exists(cellValue.ToString()))
                {
                    pictureBox1.Image = Image.FromFile(cellValue.ToString());
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pictureBox1.Image = null; // không có ảnh thì clear
                }
            }
        }

        private void lblTongTien_Click(object sender, EventArgs e) { }



        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new ClosedXML.Excel.XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("DanhSachSanPham");

                        int startRow = 3; // dữ liệu sẽ bắt đầu từ dòng 3 (để chừa chỗ cho tiêu đề)

                        // ======= TIÊU ĐỀ CHÍNH =======
                        worksheet.Cell(1, 1).Value = "DANH SÁCH SẢN PHẨM";
                        worksheet.Range(1, 1, 1, DataGridViewdgvGioHang.Columns.Count).Merge().Style
                            .Font.SetBold()
                            .Font.SetFontSize(16)
                            .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                        // ======= TIÊU ĐỀ CỘT =======
                        for (int j = 0; j < DataGridViewdgvGioHang.Columns.Count; j++)
                        {
                            worksheet.Cell(startRow, j + 1).Value = DataGridViewdgvGioHang.Columns[j].HeaderText;
                            worksheet.Cell(startRow, j + 1).Style.Font.SetBold();
                            worksheet.Cell(startRow, j + 1).Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.LightGray;
                        }

                        // ======= DỮ LIỆU =======
                        double tongTien = 0;
                        for (int i = 0; i < DataGridViewdgvGioHang.Rows.Count; i++)
                        {
                            for (int j = 0; j < DataGridViewdgvGioHang.Columns.Count; j++)
                            {
                                object value = DataGridViewdgvGioHang.Rows[i].Cells[j].Value;
                                worksheet.Cell(i + startRow + 1, j + 1).Value = (value == null) ? "" : value.ToString();
                            }

                            // Giả sử cột "Thành tiền" nằm ở cột cuối (dgvSanPham.Columns.Count - 1)
                            object thanhTien = DataGridViewdgvGioHang.Rows[i].Cells[DataGridViewdgvGioHang.Columns.Count - 1].Value;
                            if (thanhTien != null && double.TryParse(thanhTien.ToString(), out double soTien))
                            {
                                tongTien += soTien;
                            }
                        }

                        // ======= TỔNG TIỀN =======
                        int lastRow = DataGridViewdgvGioHang.Rows.Count + startRow + 1;
                        worksheet.Cell(lastRow, DataGridViewdgvGioHang.Columns.Count - 1).Value = "TỔNG TIỀN:";
                        worksheet.Cell(lastRow, DataGridViewdgvGioHang.Columns.Count - 1).Style.Font.SetBold();

                        worksheet.Cell(lastRow, DataGridViewdgvGioHang.Columns.Count).Value = tongTien;
                        worksheet.Cell(lastRow, DataGridViewdgvGioHang.Columns.Count).Style.Font.SetBold();

                        // AutoFit cột
                        worksheet.Columns().AdjustToContents();

                        workbook.SaveAs(sfd.FileName);
                        MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }




    }
}
