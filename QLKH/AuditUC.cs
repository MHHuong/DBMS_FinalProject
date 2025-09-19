using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKH
{
    public partial class AuditUC : UserControl
    {
        private readonly DBConnect db = new DBConnect();

        public AuditUC()
        {
            InitializeComponent();
            this.Load += AuditUC_Load;

        }
        private void AuditUC_Load(object sender, EventArgs e)
        {
            cboAudit.Items.Clear();
            cboAudit.Items.Add("Khách hàng");
            cboAudit.Items.Add("Hội viên");
            cboAudit.SelectedIndex = 0; 

            auditGrid.AutoGenerateColumns = true;
            auditGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            auditGrid.MultiSelect = false;

            LoadAudit();
        }
        private void LoadAudit()
        {
            if (cboAudit.SelectedItem == null) return;

            string sql;
            if (cboAudit.SelectedItem.ToString() == "Khách hàng")
                sql = "SELECT * FROM dbo.Audit_KhachHang ORDER BY AtTime DESC";
            else
                sql = "SELECT * FROM dbo.Audit_HoiVien ORDER BY AtTime DESC";

            try
            {
                var dt = db.Execute(sql);
                auditGrid.DataSource = dt;
                auditGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                auditGrid.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi nạp Audit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboAudit_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAudit();
        }
    }
}
