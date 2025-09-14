using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using ClosedXML.Excel; // cần có using này

namespace CuaHangMayTinh
{
    public partial class hoadonchitiet : UserControl
    {
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();

        public hoadonchitiet()
        {
            InitializeComponent();

            this.Load += hoadonluu_Load;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void hoadonluu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection kn = DbHelper.GetConnection())
                {
                    string sql = @"
                SELECT 
                    ChiTietHoaDon.id_ct AS [Mã CT], 
                    HoaDonBan.ma_hd AS [Mã HĐ], 
                    HangBan.ma_hang AS [Mã hàng], 
                    HangBan.tenhang AS [Tên hàng], 
                    ChiTietHoaDon.soluong AS [Số lượng], 
                    ChiTietHoaDon.dongia AS [Đơn giá], 
                    ChiTietHoaDon.ghichu AS [Ghi chú]
                FROM ChiTietHoaDon
                INNER JOIN HoaDonBan ON ChiTietHoaDon.id_hd = HoaDonBan.id_hd
                INNER JOIN HangBan ON ChiTietHoaDon.id_hang = HangBan.id_hang";

                    adapter = new SqlDataAdapter(sql, kn);
                    ds = new DataSet();
                    adapter.Fill(ds, "ChiTietHoaDon");

                    bindingSource1.DataSource = ds.Tables["ChiTietHoaDon"];
                    dataGridView1.DataSource = bindingSource1;
                }

                // ❌ Đừng gọi ở đây nữa
                // ExportToExcel_Auto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi LoadData: " + ex.Message);
            }
        }


        private void ExportToExcel_Auto()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Chọn nơi lưu file Excel";
                    saveFileDialog.FileName = $"HoaDon_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                var ws = wb.Worksheets.Add("ChiTietHoaDon");

                                // ===== Thêm tiêu đề =====
                                ws.Cell(1, 1).Value = "BÁO CÁO CHI TIẾT HÓA ĐƠN";
                                ws.Range(1, 1, 1, dataGridView1.Columns.Count).Merge();
                                ws.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                ws.Cell(1, 1).Style.Font.Bold = true;
                                ws.Cell(1, 1).Style.Font.FontSize = 16;

                                // ===== Ghi header =====
                                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                                {
                                    ws.Cell(3, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                                    ws.Cell(3, i + 1).Style.Font.Bold = true;
                                    ws.Cell(3, i + 1).Style.Fill.BackgroundColor = XLColor.LightGray;
                                    ws.Cell(3, i + 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                }

                                // ===== Ghi dữ liệu =====
                                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                    {
                                        ws.Cell(i + 4, j + 1).Value = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                                    }
                                }

                                // Border + AutoFit
                                var range = ws.Range(3, 1, dataGridView1.Rows.Count + 3, dataGridView1.Columns.Count);
                                range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                                range.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                                ws.Columns().AdjustToContents();

                                // ===== Lưu file theo đường dẫn người dùng chọn =====
                                wb.SaveAs(saveFileDialog.FileName);
                            }

                            MessageBox.Show($"Xuất Excel thành công!\nFile: {saveFileDialog.FileName}",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xuất Excel: " + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateTextBoxes();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            UpdateTextBoxes();
        }

        private void UpdateTextBoxes()
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtMaHD.Text = dataGridView1.CurrentRow.Cells["Mã HĐ"].Value?.ToString();
                txtMaHang.Text = dataGridView1.CurrentRow.Cells["Mã hàng"].Value?.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text.Trim();

            if (string.IsNullOrEmpty(maHD))
            {
                // Nếu không nhập gì -> load lại toàn bộ
                LoadData();
                return;
            }

            try
            {
                using (SqlConnection kn = DbHelper.GetConnection())
                {
                    string sql = @"
                SELECT 
                    ChiTietHoaDon.id_ct AS [Mã CT], 
                    HoaDonBan.ma_hd AS [Mã HĐ], 
                    HangBan.ma_hang AS [Mã hàng], 
                    HangBan.tenhang AS [Tên hàng], 
                    ChiTietHoaDon.soluong AS [Số lượng], 
                    ChiTietHoaDon.dongia AS [Đơn giá], 
                    ChiTietHoaDon.ghichu AS [Ghi chú]
                FROM ChiTietHoaDon
                INNER JOIN HoaDonBan ON ChiTietHoaDon.id_hd = HoaDonBan.id_hd
                INNER JOIN HangBan ON ChiTietHoaDon.id_hang = HangBan.id_hang
                WHERE HoaDonBan.ma_hd = @maHD";

                    adapter = new SqlDataAdapter(sql, kn);
                    adapter.SelectCommand.Parameters.AddWithValue("@maHD", maHD);

                    ds = new DataSet();
                    adapter.Fill(ds, "ChiTietHoaDon");

                    bindingSource1.DataSource = ds.Tables["ChiTietHoaDon"];
                    dataGridView1.DataSource = bindingSource1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            string idCT = dataGridView1.CurrentRow.Cells["Mã CT"].Value?.ToString();

            if (string.IsNullOrEmpty(idCT))
            {
                MessageBox.Show("Không tìm thấy mã chi tiết để xóa!");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa chi tiết HĐ {idCT}?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection kn = DbHelper.GetConnection())
                    {
                        kn.Open();
                        string sql = "DELETE FROM ChiTietHoaDon WHERE id_ct = @idCT";
                        using (SqlCommand cmd = new SqlCommand(sql, kn))
                        {
                            cmd.Parameters.AddWithValue("@idCT", idCT);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Xóa thành công!");
                    LoadData(); // load lại danh sách
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message);
                }
            }
        }


        private void btn_excel_Click(object sender, EventArgs e)
        {
            ExportToExcel_Auto();
        }
    }
}