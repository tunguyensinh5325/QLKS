namespace QLKSGUI
{
    partial class Form_DSPhong
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_DanhSachPhong = new Label();
            btn_TimPhong = new Button();
            cbbox_Phong = new ComboBox();
            dtgv_dsphong = new DataGridView();
            btn_Thoat = new Button();
            btn_Baocao = new Button();
            btn_Datphong = new Button();
            btn_Thanhtoan = new Button();
            tblp_DSPhong = new TableLayoutPanel();
            tblp_input = new TableLayoutPanel();
            cbb_TinhTrang = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dtgv_dsphong).BeginInit();
            tblp_DSPhong.SuspendLayout();
            tblp_input.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // lb_DanhSachPhong
            // 
            lb_DanhSachPhong.AutoSize = true;
            lb_DanhSachPhong.Dock = DockStyle.Fill;
            lb_DanhSachPhong.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lb_DanhSachPhong.Location = new Point(4, 0);
            lb_DanhSachPhong.Margin = new Padding(4, 0, 4, 0);
            lb_DanhSachPhong.Name = "lb_DanhSachPhong";
            lb_DanhSachPhong.Size = new Size(959, 73);
            lb_DanhSachPhong.TabIndex = 0;
            lb_DanhSachPhong.Text = "Danh Sách Phòng";
            lb_DanhSachPhong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_TimPhong
            // 
            btn_TimPhong.Dock = DockStyle.Right;
            btn_TimPhong.Location = new Point(4, 2);
            btn_TimPhong.Margin = new Padding(4, 2, 4, 2);
            btn_TimPhong.Name = "btn_TimPhong";
            btn_TimPhong.Size = new Size(123, 43);
            btn_TimPhong.TabIndex = 2;
            btn_TimPhong.Text = "Tìm Phòng";
            btn_TimPhong.UseVisualStyleBackColor = true;
            btn_TimPhong.Click += btn_TimPhong_Click;
            // 
            // cbbox_Phong
            // 
            cbbox_Phong.Dock = DockStyle.Left;
            cbbox_Phong.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbox_Phong.FormattingEnabled = true;
            cbbox_Phong.Items.AddRange(new object[] { "Tất cả", "Đơn", "Đôi", "Lớn" });
            cbbox_Phong.Location = new Point(135, 2);
            cbbox_Phong.Margin = new Padding(4, 2, 4, 2);
            cbbox_Phong.Name = "cbbox_Phong";
            cbbox_Phong.Size = new Size(218, 33);
            cbbox_Phong.TabIndex = 3;
            // 
            // dtgv_dsphong
            // 
            dtgv_dsphong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_dsphong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgv_dsphong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_dsphong.Dock = DockStyle.Fill;
            dtgv_dsphong.Location = new Point(4, 2);
            dtgv_dsphong.Margin = new Padding(4, 2, 4, 2);
            dtgv_dsphong.Name = "dtgv_dsphong";
            dtgv_dsphong.RowHeadersWidth = 62;
            dtgv_dsphong.RowTemplate.Height = 33;
            dtgv_dsphong.Size = new Size(959, 335);
            dtgv_dsphong.TabIndex = 4;
            dtgv_dsphong.RowPostPaint += dtgv_dsphong_RowPostPaint;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Dock = DockStyle.Fill;
            btn_Thoat.Location = new Point(727, 2);
            btn_Thoat.Margin = new Padding(4, 2, 4, 2);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(236, 45);
            btn_Thoat.TabIndex = 5;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // btn_Baocao
            // 
            btn_Baocao.Dock = DockStyle.Fill;
            btn_Baocao.Location = new Point(486, 2);
            btn_Baocao.Margin = new Padding(4, 2, 4, 2);
            btn_Baocao.Name = "btn_Baocao";
            btn_Baocao.Size = new Size(233, 45);
            btn_Baocao.TabIndex = 6;
            btn_Baocao.Text = "Báo cáo";
            btn_Baocao.UseVisualStyleBackColor = true;
            btn_Baocao.Click += btn_Baocao_Click;
            // 
            // btn_Datphong
            // 
            btn_Datphong.Dock = DockStyle.Fill;
            btn_Datphong.Location = new Point(4, 2);
            btn_Datphong.Margin = new Padding(4, 2, 4, 2);
            btn_Datphong.Name = "btn_Datphong";
            btn_Datphong.Size = new Size(233, 45);
            btn_Datphong.TabIndex = 7;
            btn_Datphong.Text = "Đặt Phòng";
            btn_Datphong.UseVisualStyleBackColor = true;
            btn_Datphong.Click += btn_Datphong_Click;
            // 
            // btn_Thanhtoan
            // 
            btn_Thanhtoan.Dock = DockStyle.Fill;
            btn_Thanhtoan.Location = new Point(245, 2);
            btn_Thanhtoan.Margin = new Padding(4, 2, 4, 2);
            btn_Thanhtoan.Name = "btn_Thanhtoan";
            btn_Thanhtoan.Size = new Size(233, 45);
            btn_Thanhtoan.TabIndex = 8;
            btn_Thanhtoan.Text = "Thanh toán";
            btn_Thanhtoan.UseVisualStyleBackColor = true;
            btn_Thanhtoan.Click += btn_Thanhtoan_Click;
            // 
            // tblp_DSPhong
            // 
            tblp_DSPhong.ColumnCount = 1;
            tblp_DSPhong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblp_DSPhong.Controls.Add(lb_DanhSachPhong, 0, 0);
            tblp_DSPhong.Dock = DockStyle.Fill;
            tblp_DSPhong.Location = new Point(3, 3);
            tblp_DSPhong.Name = "tblp_DSPhong";
            tblp_DSPhong.RowCount = 1;
            tblp_DSPhong.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblp_DSPhong.Size = new Size(967, 73);
            tblp_DSPhong.TabIndex = 9;
            // 
            // tblp_input
            // 
            tblp_input.ColumnCount = 3;
            tblp_input.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.5470524F));
            tblp_input.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.4705276F));
            tblp_input.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.9824181F));
            tblp_input.Controls.Add(btn_TimPhong, 0, 0);
            tblp_input.Controls.Add(cbbox_Phong, 1, 0);
            tblp_input.Controls.Add(cbb_TinhTrang, 2, 0);
            tblp_input.Dock = DockStyle.Fill;
            tblp_input.Location = new Point(3, 82);
            tblp_input.Name = "tblp_input";
            tblp_input.RowCount = 1;
            tblp_input.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblp_input.Size = new Size(967, 47);
            tblp_input.TabIndex = 10;
            // 
            // cbb_TinhTrang
            // 
            cbb_TinhTrang.Dock = DockStyle.Left;
            cbb_TinhTrang.FormattingEnabled = true;
            cbb_TinhTrang.Items.AddRange(new object[] { "Trống", "Đã Thuê" });
            cbb_TinhTrang.Location = new Point(477, 3);
            cbb_TinhTrang.Name = "cbb_TinhTrang";
            cbb_TinhTrang.Size = new Size(226, 33);
            cbb_TinhTrang.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dtgv_dsphong, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 135);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(967, 339);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(btn_Datphong, 0, 0);
            tableLayoutPanel2.Controls.Add(btn_Thanhtoan, 1, 0);
            tableLayoutPanel2.Controls.Add(btn_Baocao, 2, 0);
            tableLayoutPanel2.Controls.Add(btn_Thoat, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 480);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(967, 49);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tblp_DSPhong, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel3.Controls.Add(tblp_input, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.Size = new Size(973, 532);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // Form_DSPhong
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 532);
            Controls.Add(tableLayoutPanel3);
            Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form_DSPhong";
            Text = "Danh Sách Phòng";
            Load += Form_DSPhong_Load_1;
            ((System.ComponentModel.ISupportInitialize)dtgv_dsphong).EndInit();
            tblp_DSPhong.ResumeLayout(false);
            tblp_DSPhong.PerformLayout();
            tblp_input.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lb_DanhSachPhong;
        private Button btn_TimPhong;
        private ComboBox cbbox_Phong;
        private DataGridView dtgv_dsphong;
        private Button btn_Thoat;
        private Button btn_Baocao;
        private Button btn_Datphong;
        private Button btn_Thanhtoan;
        private TableLayoutPanel tblp_DSPhong;
        private TableLayoutPanel tblp_input;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox cbb_TinhTrang;
    }
}
