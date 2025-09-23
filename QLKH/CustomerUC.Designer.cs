namespace QLKH
{
    partial class CustomerUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.customerGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtMaKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.cusIDLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnDel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.findButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ReloadButton = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(279, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(457, 41);
            this.txtSearch.TabIndex = 9;
            // 
            // customerGrid
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.customerGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.customerGrid.ColumnHeadersHeight = 15;
            this.customerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.customerGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.customerGrid.Location = new System.Drawing.Point(279, 73);
            this.customerGrid.Name = "customerGrid";
            this.customerGrid.ReadOnly = true;
            this.customerGrid.RowHeadersVisible = false;
            this.customerGrid.Size = new System.Drawing.Size(568, 574);
            this.customerGrid.TabIndex = 8;
            this.customerGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.customerGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.customerGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.customerGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.customerGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.customerGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.customerGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.customerGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.customerGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.customerGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customerGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.customerGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.customerGrid.ThemeStyle.HeaderStyle.Height = 15;
            this.customerGrid.ThemeStyle.ReadOnly = true;
            this.customerGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.customerGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.customerGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customerGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.customerGrid.ThemeStyle.RowsStyle.Height = 22;
            this.customerGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.customerGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.customerGrid.SelectionChanged += new System.EventHandler(this.customerGrid_SelectionChanged);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKH.DefaultText = "";
            this.txtMaKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.Location = new System.Drawing.Point(14, 114);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.PlaceholderText = "";
            this.txtMaKH.SelectedText = "";
            this.txtMaKH.Size = new System.Drawing.Size(237, 38);
            this.txtMaKH.TabIndex = 11;
            // 
            // cusIDLabel
            // 
            this.cusIDLabel.AutoSize = true;
            this.cusIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cusIDLabel.Location = new System.Drawing.Point(10, 89);
            this.cusIDLabel.Name = "cusIDLabel";
            this.cusIDLabel.Size = new System.Drawing.Size(123, 20);
            this.cusIDLabel.TabIndex = 12;
            this.cusIDLabel.Text = "Mã Khách Hàng";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nameLabel.Location = new System.Drawing.Point(10, 167);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(77, 20);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Họ và tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Location = new System.Drawing.Point(14, 192);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(237, 38);
            this.txtHoTen.TabIndex = 14;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.phoneLabel.Location = new System.Drawing.Point(10, 244);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(102, 20);
            this.phoneLabel.TabIndex = 16;
            this.phoneLabel.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Location = new System.Drawing.Point(14, 269);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(237, 38);
            this.txtSDT.TabIndex = 15;
            // 
            // BtnAdd
            // 
            this.BtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(14, 547);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(98, 37);
            this.BtnAdd.TabIndex = 17;
            this.BtnAdd.Text = "Thêm";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDel.ForeColor = System.Drawing.Color.White;
            this.BtnDel.Location = new System.Drawing.Point(77, 608);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(98, 37);
            this.BtnDel.TabIndex = 18;
            this.BtnDel.Text = "Xóa";
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUpdate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(153, 547);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(98, 37);
            this.BtnUpdate.TabIndex = 19;
            this.BtnUpdate.Text = "Cập nhật";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // findButton
            // 
            this.findButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.findButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.findButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.findButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.findButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.findButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.findButton.ForeColor = System.Drawing.Color.White;
            this.findButton.Location = new System.Drawing.Point(772, 10);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 41);
            this.findButton.TabIndex = 20;
            this.findButton.Text = "Tìm";
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ReloadButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ReloadButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReloadButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReloadButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ReloadButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ReloadButton.ForeColor = System.Drawing.Color.White;
            this.ReloadButton.Location = new System.Drawing.Point(12, 13);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(75, 41);
            this.ReloadButton.TabIndex = 22;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // CustomerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.cusIDLabel);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.customerGrid);
            this.Name = "CustomerUC";
            this.Size = new System.Drawing.Size(869, 653);
            this.Load += new System.EventHandler(this.CustomerUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2DataGridView customerGrid;
        private Guna.UI2.WinForms.Guna2TextBox txtMaKH;
        private System.Windows.Forms.Label cusIDLabel;
        private System.Windows.Forms.Label nameLabel;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private System.Windows.Forms.Label phoneLabel;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2GradientButton BtnAdd;
        private Guna.UI2.WinForms.Guna2GradientButton BtnDel;
        private Guna.UI2.WinForms.Guna2GradientButton BtnUpdate;
        private Guna.UI2.WinForms.Guna2GradientButton findButton;
        private Guna.UI2.WinForms.Guna2GradientButton ReloadButton;
    }
}
