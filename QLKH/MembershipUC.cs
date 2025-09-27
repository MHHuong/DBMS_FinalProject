using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKH
{
    public partial class MembershipUC : UserControl
    {
        private readonly DBConnect db = new DBConnect();
        public MembershipUC()
        {
            InitializeComponent();
            this.Load += MemberUC_Load;
            membershipGrid.SelectionChanged += membershipGrid_SelectionChanged;
           
        }
        private void MemberUC_Load(object sender, EventArgs e)
        {
            LoadKhachHangCombo();
            LoadGrid();
        }
        private void LoadKhachHangCombo()
        {
            var dt = db.Execute("SELECT MaKH, HoTen FROM dbo.KhachHang ORDER BY HoTen");
            cboMaKH.DisplayMember = "HoTen";
            cboMaKH.ValueMember = "MaKH";
            cboMaKH.DataSource = dt;
            cboMaKH.SelectedIndex = dt.Rows.Count > 0 ? 0 : -1;
        }
        private void LoadGrid()
        {
            var dt = db.ExecuteProcTable("dbo.proc_DanhSachHoiVien");
            membershipGrid.DataSource = dt;
            membershipGrid.ClearSelection();
            ClearInputs();
        }
        private void ClearInputs()
        {
            txtMaHV.Clear();
            if (cboMaKH.Items.Count > 0) cboMaKH.SelectedIndex = 0;
            dtpBatDau.Value = DateTime.Today;
            dtpKetThuc.Value = DateTime.Today.AddMonths(1);
        }

        private void membershipGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (membershipGrid.CurrentRow == null || membershipGrid.CurrentRow.Index < 0) return;
            var row = (membershipGrid.CurrentRow.DataBoundItem as DataRowView)?.Row;
            if (row == null) return;

            txtMaHV.Text = row["MaHV"]?.ToString();
            var makh = row["MaKH"]?.ToString();
            if (!string.IsNullOrEmpty(makh)) cboMaKH.SelectedValue = makh;

            if (DateTime.TryParse(row["NgayBatDau"]?.ToString(), out var bd)) dtpBatDau.Value = bd;
            if (DateTime.TryParse(row["NgayKetThuc"]?.ToString(), out var kt)) dtpKetThuc.Value = kt;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var msg = new SqlParameter("@Msg", SqlDbType.NVarChar, 200) { Direction = ParameterDirection.Output };
            try
            {
                db.ExecuteProcNonQuery("dbo.proc_ThemHoiVien",
                    DBConnect.P("@MaHV", SqlDbType.VarChar, txtMaHV.Text),
                    DBConnect.P("@MaKH", SqlDbType.VarChar, cboMaKH.SelectedValue),
                    DBConnect.P("@NgayBatDau", SqlDbType.Date, dtpBatDau.Value.Date),
                    DBConnect.P("@NgayKetThuc", SqlDbType.Date, dtpKetThuc.Value.Date),
                    msg
                );
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
                db.ExecuteProcNonQuery("dbo.proc_SuaHoiVien",
                    DBConnect.P("@MaHV", SqlDbType.VarChar, txtMaHV.Text),
                    DBConnect.P("@MaKH", SqlDbType.VarChar, cboMaKH.SelectedValue),
                    DBConnect.P("@NgayBatDau", SqlDbType.Date, dtpBatDau.Value.Date),
                    DBConnect.P("@NgayKetThuc", SqlDbType.Date, dtpKetThuc.Value.Date)
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
            if (string.IsNullOrWhiteSpace(txtMaHV.Text)) return;
            if (MessageBox.Show("Xóa hội viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                db.ExecuteProcNonQuery("dbo.proc_XoaHoiVien",
                    DBConnect.P("@MaHV", SqlDbType.VarChar, txtMaHV.Text)
                );
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            var useNewKH = CheckBox.Checked;
            var makhParam = useNewKH ? (object)DBNull.Value : (object)cboMaKH.SelectedValue;

            var msg = new SqlParameter("@Msg", SqlDbType.NVarChar, 200) { Direction = ParameterDirection.Output };
            try
            {
                db.ExecuteProcNonQuery("dbo.proc_DangKyHoiVien",
                    DBConnect.P("@MaHV", SqlDbType.VarChar, txtMaHV.Text),
                    DBConnect.P("@MaKH", SqlDbType.VarChar, makhParam),
                    DBConnect.P("@HoTenKH", SqlDbType.NVarChar, useNewKH ? txtHoTen.Text : (object)DBNull.Value, 50),
                    DBConnect.P("@SoDTKH", SqlDbType.VarChar, useNewKH ? txtSDT.Text : (object)DBNull.Value, 20),
                    DBConnect.P("@NgayBatDau", SqlDbType.Date, dtpBatDau.Value.Date),
                    DBConnect.P("@NgayKetThuc", SqlDbType.Date, dtpKetThuc.Value.Date),
                    msg
                );
                MessageBox.Show(Convert.ToString(msg.Value), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKhachHangCombo();
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox.Checked)
            {
                nameLabel.Visible = true;
                phoneLabel.Visible = true;
                txtHoTen.Visible = true;
                txtSDT.Visible = true;
                BtnRegister.Visible = true;
                cusLabel.Visible = false;
                cboMaKH.Visible = false;
                BtnAdd.Visible = false;
                BtnDel.Visible = false;
                BtnUpdate.Visible = false;
            }
            else
            {
                nameLabel.Visible = false;
                phoneLabel.Visible = false;
                txtHoTen.Visible = false;
                txtSDT.Visible= false;
                BtnRegister.Visible = false;
                cboMaKH.Visible = true;
                cusLabel.Visible = true;
                cboMaKH.Visible = true;
                BtnAdd.Visible = true;
                BtnDel.Visible = true;
                BtnUpdate.Visible = true;
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            var keyword = txtSearch.Text?.Trim();

            var dt = db.Execute("SELECT * FROM dbo.fn_TimHoiVien(@k)",
                DBConnect.P("@k", SqlDbType.NVarChar, keyword ?? string.Empty, 100));

            membershipGrid.DataSource = dt;
            membershipGrid.ClearSelection();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
    
}
