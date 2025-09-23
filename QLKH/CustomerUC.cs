using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace QLKH
{
    public partial class CustomerUC : UserControl
    {
        private readonly DBConnect db = new DBConnect();

        public CustomerUC()
        {
            InitializeComponent();
            this.Load += CustomerUC_Load;
        }
        private void ClearInputs()
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
        }
        private void LoadGrid()
        {
            var dt = db.ExecuteProcTable("dbo.proc_DanhSachKhachHang");
            customerGrid.DataSource = dt;
            customerGrid.ClearSelection();
            ClearInputs();
        }

        private void CustomerUC_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void customerGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (customerGrid.CurrentRow == null || customerGrid.CurrentRow.Index < 0) return;
            var row = (customerGrid.CurrentRow.DataBoundItem as DataRowView)?.Row;
            if (row == null) return;

            txtMaKH.Text = row["MaKH"]?.ToString();
            txtHoTen.Text = row["HoTen"]?.ToString();
            txtSDT.Text = row["SoDienThoai"]?.ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var msg = new SqlParameter("@Msg", SqlDbType.NVarChar, 200)
            {
                Direction = ParameterDirection.Output
            };
            try
            {
                db.ExecuteProcNonQuery("dbo.proc_ThemKhachHang",
                    DBConnect.P("@MaKH", SqlDbType.VarChar, txtMaKH.Text),
                     DBConnect.P("@HoTen", SqlDbType.NVarChar, txtHoTen.Text),
                    DBConnect.P("@SoDienThoai", SqlDbType.VarChar, txtSDT.Text),
                    msg);
                MessageBox.Show(Convert.ToString(msg.Value), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                db.ExecuteProcNonQuery("dbo.proc_SuaKhachHang",
                    DBConnect.P("@MaKH", SqlDbType.VarChar, txtMaKH.Text),
                    DBConnect.P("@HoTen", SqlDbType.NVarChar, txtHoTen.Text),
                    DBConnect.P("@SoDienThoai", SqlDbType.VarChar, txtSDT.Text)
                );
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text)) return;
            if (MessageBox.Show("Xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                db.ExecuteProcNonQuery("dbo.proc_XoaKhachHang",
                    DBConnect.P("@MaKH", SqlDbType.VarChar, txtMaKH.Text)
                );
                LoadGrid();
            }
            catch (Exception ex)
            {
                // Trigger/proc sẽ báo nếu còn HoiVien
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            var k = txtSearch.Text?.Trim();
            var dt = db.Execute("SELECT * FROM dbo.fn_TimKhachHang(@k)",
                DBConnect.P("@k", SqlDbType.NVarChar, k ?? string.Empty, 100));
            customerGrid.DataSource = dt;
            customerGrid.ClearSelection();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
