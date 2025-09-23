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
    public partial class QLKH : Form
    {
        private CustomerUC _managerUc;
        private MembershipUC _memberUc;
        private AuditUC _auditUC;

        public QLKH()
        {
            InitializeComponent();
            ManagerCustomer();

            //guna2TabControl1.SelectedIndexChanged += guna2TabControl1_SelectedIndexChanged;
        }

        private void ManagerCustomer()
        {
            if (_managerUc == null)
            {
                _managerUc = new CustomerUC();
                _managerUc.Dock = DockStyle.Fill;
            }
            managerPanel.Controls.Clear();
            managerPanel.Controls.Add(_managerUc);
            _managerUc.BringToFront();
            
        }

        private void ManagerMember()
        {
            if (_memberUc == null)
            {
                _memberUc = new MembershipUC();
                _memberUc.Dock = DockStyle.Fill;
            }
            tabPage2.Controls.Clear();
            tabPage2.Controls.Add(_memberUc);
            _memberUc.BringToFront();
        }
        private void Audit()
        {
            if (_auditUC == null)
            {
                _auditUC = new AuditUC();
                _auditUC.Dock = DockStyle.Fill;
            }
            tabPage3.Controls.Clear();
            tabPage3.Controls.Add(_auditUC);
            _auditUC.BringToFront();
        }

        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2TabControl1.SelectedTab == tabPage1)
                ManagerCustomer();
            else if (guna2TabControl1.SelectedTab == tabPage2)
                ManagerMember();
            else if (guna2TabControl1.SelectedTab == tabPage3)
                Audit();
        }
    }
}
