using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CuaHangMayTinh
{
    public partial class hoadonchitiet : UserControl
    {
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();

        public hoadonchitiet()
        {
            InitializeComponent();

            // Gán event
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
                } // SqlConnection tự động đóng ở đây
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi LoadData: " + ex.Message);
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

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
