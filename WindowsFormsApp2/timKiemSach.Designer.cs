namespace WindowsFormsApp2
{
    partial class timKiemSach
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timKiemSach));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSBook = new System.Windows.Forms.TextBox();
            this.btnSBook = new System.Windows.Forms.Button();
            this.btnExitSBook = new System.Windows.Forms.Button();
            this.dgvSBook = new System.Windows.Forms.DataGridView();
            this.rbFollowIDBook = new System.Windows.Forms.RadioButton();
            this.rbFollowName = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnTrảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpPhiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.độcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSBook)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbFollowName);
            this.panel1.Controls.Add(this.rbFollowIDBook);
            this.panel1.Controls.Add(this.btnExitSBook);
            this.panel1.Controls.Add(this.btnSBook);
            this.panel1.Controls.Add(this.txtSBook);
            this.panel1.Location = new System.Drawing.Point(8, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 132);
            this.panel1.TabIndex = 0;
            // 
            // txtSBook
            // 
            this.txtSBook.Location = new System.Drawing.Point(206, 62);
            this.txtSBook.Name = "txtSBook";
            this.txtSBook.Size = new System.Drawing.Size(369, 26);
            this.txtSBook.TabIndex = 0;
            // 
            // btnSBook
            // 
            this.btnSBook.Location = new System.Drawing.Point(606, 59);
            this.btnSBook.Name = "btnSBook";
            this.btnSBook.Size = new System.Drawing.Size(75, 33);
            this.btnSBook.TabIndex = 1;
            this.btnSBook.Text = "Tìm";
            this.btnSBook.UseVisualStyleBackColor = true;
            // 
            // btnExitSBook
            // 
            this.btnExitSBook.Location = new System.Drawing.Point(702, 59);
            this.btnExitSBook.Name = "btnExitSBook";
            this.btnExitSBook.Size = new System.Drawing.Size(75, 33);
            this.btnExitSBook.TabIndex = 2;
            this.btnExitSBook.Text = "Thoát";
            this.btnExitSBook.UseVisualStyleBackColor = true;
            this.btnExitSBook.Click += new System.EventHandler(this.btnExitSBook_Click);
            // 
            // dgvSBook
            // 
            this.dgvSBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSBook.Location = new System.Drawing.Point(8, 231);
            this.dgvSBook.Name = "dgvSBook";
            this.dgvSBook.RowHeadersWidth = 62;
            this.dgvSBook.RowTemplate.Height = 28;
            this.dgvSBook.Size = new System.Drawing.Size(921, 339);
            this.dgvSBook.TabIndex = 1;
            // 
            // rbFollowIDBook
            // 
            this.rbFollowIDBook.AutoSize = true;
            this.rbFollowIDBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFollowIDBook.Location = new System.Drawing.Point(42, 35);
            this.rbFollowIDBook.Name = "rbFollowIDBook";
            this.rbFollowIDBook.Size = new System.Drawing.Size(149, 24);
            this.rbFollowIDBook.TabIndex = 3;
            this.rbFollowIDBook.TabStop = true;
            this.rbFollowIDBook.Text = "Theo Mã Sách";
            this.rbFollowIDBook.UseVisualStyleBackColor = true;
            // 
            // rbFollowName
            // 
            this.rbFollowName.AutoSize = true;
            this.rbFollowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFollowName.Location = new System.Drawing.Point(43, 82);
            this.rbFollowName.Name = "rbFollowName";
            this.rbFollowName.Size = new System.Drawing.Size(148, 24);
            this.rbFollowName.TabIndex = 4;
            this.rbFollowName.TabStop = true;
            this.rbFollowName.Text = "Theo tên sách";
            this.rbFollowName.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.mượnTrảSáchToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.báoCáoThốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.system2;
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.hToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.iconexit;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.ext;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSáchToolStripMenuItem,
            this.quảnLýĐộcGiảToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.list;
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.addbook;
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(317, 34);
            this.quảnLýSáchToolStripMenuItem.Text = "Quản lý sách";
            // 
            // quảnLýĐộcGiảToolStripMenuItem
            // 
            this.quảnLýĐộcGiảToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.addhuman;
            this.quảnLýĐộcGiảToolStripMenuItem.Name = "quảnLýĐộcGiảToolStripMenuItem";
            this.quảnLýĐộcGiảToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.quảnLýĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(317, 34);
            this.quảnLýĐộcGiảToolStripMenuItem.Text = "Quản lý độc giả";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.addstaff;
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(317, 34);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // mượnTrảSáchToolStripMenuItem
            // 
            this.mượnTrảSáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lậpPhiếuToolStripMenuItem});
            this.mượnTrảSáchToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.brrowbook;
            this.mượnTrảSáchToolStripMenuItem.Name = "mượnTrảSáchToolStripMenuItem";
            this.mượnTrảSáchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mượnTrảSáchToolStripMenuItem.Size = new System.Drawing.Size(166, 29);
            this.mượnTrảSáchToolStripMenuItem.Text = "Mượn trả sách";
            // 
            // lậpPhiếuToolStripMenuItem
            // 
            this.lậpPhiếuToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.list;
            this.lậpPhiếuToolStripMenuItem.Name = "lậpPhiếuToolStripMenuItem";
            this.lậpPhiếuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.lậpPhiếuToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.lậpPhiếuToolStripMenuItem.Text = "Lập phiếu";
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sáchToolStripMenuItem,
            this.độcGiảToolStripMenuItem});
            this.tìmKiếmToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.search2;
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.brrowbook;
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.sáchToolStripMenuItem.Text = "Sách";
            // 
            // độcGiảToolStripMenuItem
            // 
            this.độcGiảToolStripMenuItem.Image = global::WindowsFormsApp2.Properties.Resources.addhuman;
            this.độcGiảToolStripMenuItem.Name = "độcGiảToolStripMenuItem";
            this.độcGiảToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.độcGiảToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.độcGiảToolStripMenuItem.Text = "Độc giả";
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            this.báoCáoThốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuấtExcelToolStripMenuItem});
            this.báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            this.báoCáoThốngKêToolStripMenuItem.Size = new System.Drawing.Size(167, 29);
            this.báoCáoThốngKêToolStripMenuItem.Text = "Báo cáo thống kê";
            // 
            // xuấtExcelToolStripMenuItem
            // 
            this.xuấtExcelToolStripMenuItem.Name = "xuấtExcelToolStripMenuItem";
            this.xuấtExcelToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.xuấtExcelToolStripMenuItem.Text = "Xuất Excel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm sách";
            // 
            // timKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvSBook);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "timKiemSach";
            this.Text = "timKiemSach";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSBook)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbFollowName;
        private System.Windows.Forms.RadioButton rbFollowIDBook;
        private System.Windows.Forms.Button btnExitSBook;
        private System.Windows.Forms.Button btnSBook;
        private System.Windows.Forms.TextBox txtSBook;
        private System.Windows.Forms.DataGridView dgvSBook;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mượnTrảSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpPhiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem độcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtExcelToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}