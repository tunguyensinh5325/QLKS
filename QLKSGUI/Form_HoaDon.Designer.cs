namespace QLKSGUI
{
    partial class Form_HoaDon
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
            tblp_HoaDon = new TableLayoutPanel();
            lb_HoaDonThanhToan = new Label();
            txt_DiaChi = new TextBox();
            lb_DiaChi = new Label();
            lv_HoaDonThanhToan = new ListView();
            cl_stt = new ColumnHeader();
            cl_Phong = new ColumnHeader();
            cl_SoNgayThue = new ColumnHeader();
            cl_DonGia = new ColumnHeader();
            cl_ThanhTien = new ColumnHeader();
            txt_KhachHang = new TextBox();
            txt_TriGia = new TextBox();
            lb_TriGia = new Label();
            lb_KhachHang = new Label();
            tblp_lvHoaDon = new TableLayoutPanel();
            tblp_btn = new TableLayoutPanel();
            btn_QuayLai = new Button();
            btn_Tim = new Button();
            btn_ThanhToan = new Button();
            btn_reset = new Button();
            tblp_input = new TableLayoutPanel();
            tblp_all = new TableLayoutPanel();
            tblp_HoaDon.SuspendLayout();
            tblp_lvHoaDon.SuspendLayout();
            tblp_btn.SuspendLayout();
            tblp_input.SuspendLayout();
            tblp_all.SuspendLayout();
            SuspendLayout();
            // 
            // tblp_HoaDon
            // 
            tblp_HoaDon.ColumnCount = 1;
            tblp_HoaDon.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblp_HoaDon.Controls.Add(lb_HoaDonThanhToan, 0, 0);
            tblp_HoaDon.Dock = DockStyle.Fill;
            tblp_HoaDon.Location = new Point(4, 3);
            tblp_HoaDon.Margin = new Padding(4, 3, 4, 3);
            tblp_HoaDon.Name = "tblp_HoaDon";
            tblp_HoaDon.RowCount = 1;
            tblp_HoaDon.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblp_HoaDon.Size = new Size(1024, 90);
            tblp_HoaDon.TabIndex = 0;
            // 
            // lb_HoaDonThanhToan
            // 
            lb_HoaDonThanhToan.AutoSize = true;
            lb_HoaDonThanhToan.BackColor = SystemColors.Control;
            lb_HoaDonThanhToan.Dock = DockStyle.Fill;
            lb_HoaDonThanhToan.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lb_HoaDonThanhToan.Location = new Point(4, 0);
            lb_HoaDonThanhToan.Margin = new Padding(4, 0, 4, 0);
            lb_HoaDonThanhToan.Name = "lb_HoaDonThanhToan";
            lb_HoaDonThanhToan.RightToLeft = RightToLeft.No;
            lb_HoaDonThanhToan.Size = new Size(1016, 90);
            lb_HoaDonThanhToan.TabIndex = 27;
            lb_HoaDonThanhToan.Text = "HÓA ĐƠN THANH TOÁN";
            lb_HoaDonThanhToan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Dock = DockStyle.Fill;
            txt_DiaChi.Location = new Point(281, 3);
            txt_DiaChi.Margin = new Padding(4, 3, 4, 3);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.ReadOnly = true;
            txt_DiaChi.Size = new Size(271, 35);
            txt_DiaChi.TabIndex = 33;
            // 
            // lb_DiaChi
            // 
            lb_DiaChi.AutoSize = true;
            lb_DiaChi.Dock = DockStyle.Right;
            lb_DiaChi.Location = new Point(180, 0);
            lb_DiaChi.Margin = new Padding(4, 0, 4, 0);
            lb_DiaChi.Name = "lb_DiaChi";
            lb_DiaChi.Size = new Size(93, 58);
            lb_DiaChi.TabIndex = 30;
            lb_DiaChi.Text = "Địa chỉ :";
            // 
            // lv_HoaDonThanhToan
            // 
            lv_HoaDonThanhToan.Columns.AddRange(new ColumnHeader[] { cl_stt, cl_Phong, cl_SoNgayThue, cl_DonGia, cl_ThanhTien });
            lv_HoaDonThanhToan.Dock = DockStyle.Fill;
            lv_HoaDonThanhToan.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lv_HoaDonThanhToan.FullRowSelect = true;
            lv_HoaDonThanhToan.GridLines = true;
            lv_HoaDonThanhToan.Location = new Point(4, 227);
            lv_HoaDonThanhToan.Margin = new Padding(4, 3, 4, 3);
            lv_HoaDonThanhToan.Name = "lv_HoaDonThanhToan";
            lv_HoaDonThanhToan.Size = new Size(1024, 346);
            lv_HoaDonThanhToan.TabIndex = 28;
            lv_HoaDonThanhToan.UseCompatibleStateImageBehavior = false;
            lv_HoaDonThanhToan.View = View.Details;
            lv_HoaDonThanhToan.Resize += lv_HoaDonThanhToan_Resize;
            // 
            // cl_stt
            // 
            cl_stt.Text = "STT";
            cl_stt.Width = 100;
            // 
            // cl_Phong
            // 
            cl_Phong.Text = "Phòng";
            cl_Phong.TextAlign = HorizontalAlignment.Center;
            cl_Phong.Width = 250;
            // 
            // cl_SoNgayThue
            // 
            cl_SoNgayThue.Text = "Số Ngày Thuê";
            cl_SoNgayThue.TextAlign = HorizontalAlignment.Center;
            cl_SoNgayThue.Width = 200;
            // 
            // cl_DonGia
            // 
            cl_DonGia.Text = "Đơn Giá";
            cl_DonGia.TextAlign = HorizontalAlignment.Center;
            cl_DonGia.Width = 225;
            // 
            // cl_ThanhTien
            // 
            cl_ThanhTien.Text = "Thành Tiền";
            cl_ThanhTien.TextAlign = HorizontalAlignment.Center;
            cl_ThanhTien.Width = 245;
            // 
            // txt_KhachHang
            // 
            txt_KhachHang.Dock = DockStyle.Fill;
            txt_KhachHang.Location = new Point(283, 3);
            txt_KhachHang.Margin = new Padding(4, 3, 4, 3);
            txt_KhachHang.Name = "txt_KhachHang";
            txt_KhachHang.Size = new Size(271, 35);
            txt_KhachHang.TabIndex = 32;
            // 
            // txt_TriGia
            // 
            txt_TriGia.Dock = DockStyle.Fill;
            txt_TriGia.Location = new Point(794, 3);
            txt_TriGia.Margin = new Padding(4, 3, 4, 3);
            txt_TriGia.Name = "txt_TriGia";
            txt_TriGia.ReadOnly = true;
            txt_TriGia.Size = new Size(226, 35);
            txt_TriGia.TabIndex = 34;
            // 
            // lb_TriGia
            // 
            lb_TriGia.AutoSize = true;
            lb_TriGia.Dock = DockStyle.Right;
            lb_TriGia.Location = new Point(701, 0);
            lb_TriGia.Margin = new Padding(4, 0, 4, 0);
            lb_TriGia.Name = "lb_TriGia";
            lb_TriGia.Size = new Size(85, 58);
            lb_TriGia.TabIndex = 31;
            lb_TriGia.Text = "Trị giá :";
            // 
            // lb_KhachHang
            // 
            lb_KhachHang.AutoSize = true;
            lb_KhachHang.Dock = DockStyle.Right;
            lb_KhachHang.Location = new Point(148, 0);
            lb_KhachHang.Margin = new Padding(4, 0, 4, 0);
            lb_KhachHang.Name = "lb_KhachHang";
            lb_KhachHang.Size = new Size(127, 58);
            lb_KhachHang.TabIndex = 29;
            lb_KhachHang.Text = "Khách hàng";
            // 
            // tblp_lvHoaDon
            // 
            tblp_lvHoaDon.ColumnCount = 4;
            tblp_lvHoaDon.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.1235523F));
            tblp_lvHoaDon.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.3166027F));
            tblp_lvHoaDon.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.559845F));
            tblp_lvHoaDon.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblp_lvHoaDon.Controls.Add(lb_DiaChi, 0, 0);
            tblp_lvHoaDon.Controls.Add(txt_DiaChi, 1, 0);
            tblp_lvHoaDon.Dock = DockStyle.Fill;
            tblp_lvHoaDon.Location = new Point(4, 163);
            tblp_lvHoaDon.Margin = new Padding(4, 3, 4, 3);
            tblp_lvHoaDon.Name = "tblp_lvHoaDon";
            tblp_lvHoaDon.RowCount = 1;
            tblp_lvHoaDon.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblp_lvHoaDon.Size = new Size(1024, 58);
            tblp_lvHoaDon.TabIndex = 1;
            // 
            // tblp_btn
            // 
            tblp_btn.ColumnCount = 4;
            tblp_btn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblp_btn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.80695F));
            tblp_btn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.19305F));
            tblp_btn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblp_btn.Controls.Add(btn_QuayLai, 1, 0);
            tblp_btn.Controls.Add(btn_Tim, 2, 0);
            tblp_btn.Controls.Add(btn_ThanhToan, 0, 0);
            tblp_btn.Controls.Add(btn_reset, 3, 0);
            tblp_btn.Dock = DockStyle.Fill;
            tblp_btn.Location = new Point(4, 579);
            tblp_btn.Margin = new Padding(4, 3, 4, 3);
            tblp_btn.Name = "tblp_btn";
            tblp_btn.RowCount = 1;
            tblp_btn.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblp_btn.Size = new Size(1024, 58);
            tblp_btn.TabIndex = 2;
            // 
            // btn_QuayLai
            // 
            btn_QuayLai.Dock = DockStyle.Fill;
            btn_QuayLai.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_QuayLai.Location = new Point(260, 3);
            btn_QuayLai.Margin = new Padding(4, 3, 4, 3);
            btn_QuayLai.Name = "btn_QuayLai";
            btn_QuayLai.Size = new Size(246, 52);
            btn_QuayLai.TabIndex = 36;
            btn_QuayLai.Text = "Quay Lại";
            btn_QuayLai.UseVisualStyleBackColor = true;
            btn_QuayLai.Click += btn_QuayLai_Click;
            // 
            // btn_Tim
            // 
            btn_Tim.Dock = DockStyle.Fill;
            btn_Tim.Location = new Point(514, 3);
            btn_Tim.Margin = new Padding(4, 3, 4, 3);
            btn_Tim.Name = "btn_Tim";
            btn_Tim.Size = new Size(249, 52);
            btn_Tim.TabIndex = 37;
            btn_Tim.Text = "Tìm";
            btn_Tim.UseVisualStyleBackColor = true;
            btn_Tim.Click += btn_Tim_Click;
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.Dock = DockStyle.Fill;
            btn_ThanhToan.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ThanhToan.Location = new Point(4, 3);
            btn_ThanhToan.Margin = new Padding(4, 3, 4, 3);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(248, 52);
            btn_ThanhToan.TabIndex = 35;
            btn_ThanhToan.Text = "Thanh Toán";
            btn_ThanhToan.UseVisualStyleBackColor = true;
            btn_ThanhToan.Click += btn_ThanhToan_Click;
            // 
            // btn_reset
            // 
            btn_reset.Dock = DockStyle.Fill;
            btn_reset.Location = new Point(771, 3);
            btn_reset.Margin = new Padding(4, 3, 4, 3);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(249, 52);
            btn_reset.TabIndex = 38;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // tblp_input
            // 
            tblp_input.ColumnCount = 4;
            tblp_input.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.27273F));
            tblp_input.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.272728F));
            tblp_input.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.727272F));
            tblp_input.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.727272F));
            tblp_input.Controls.Add(lb_KhachHang, 0, 0);
            tblp_input.Controls.Add(txt_TriGia, 3, 0);
            tblp_input.Controls.Add(lb_TriGia, 2, 0);
            tblp_input.Controls.Add(txt_KhachHang, 1, 0);
            tblp_input.Dock = DockStyle.Fill;
            tblp_input.Location = new Point(4, 99);
            tblp_input.Margin = new Padding(4, 3, 4, 3);
            tblp_input.Name = "tblp_input";
            tblp_input.RowCount = 1;
            tblp_input.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblp_input.Size = new Size(1024, 58);
            tblp_input.TabIndex = 3;
            // 
            // tblp_all
            // 
            tblp_all.ColumnCount = 1;
            tblp_all.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblp_all.Controls.Add(lv_HoaDonThanhToan, 0, 3);
            tblp_all.Controls.Add(tblp_HoaDon, 0, 0);
            tblp_all.Controls.Add(tblp_input, 0, 1);
            tblp_all.Controls.Add(tblp_lvHoaDon, 0, 2);
            tblp_all.Controls.Add(tblp_btn, 0, 4);
            tblp_all.Dock = DockStyle.Fill;
            tblp_all.Location = new Point(0, 0);
            tblp_all.Margin = new Padding(4, 3, 4, 3);
            tblp_all.Name = "tblp_all";
            tblp_all.RowCount = 5;
            tblp_all.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tblp_all.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblp_all.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblp_all.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tblp_all.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblp_all.Size = new Size(1032, 640);
            tblp_all.TabIndex = 4;
            // 
            // Form_HoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 640);
            Controls.Add(tblp_all);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form_HoaDon";
            Text = "HoaDonThanhToan";
            Load += Form_HoaDon_Load;
            tblp_HoaDon.ResumeLayout(false);
            tblp_HoaDon.PerformLayout();
            tblp_lvHoaDon.ResumeLayout(false);
            tblp_lvHoaDon.PerformLayout();
            tblp_btn.ResumeLayout(false);
            tblp_input.ResumeLayout(false);
            tblp_input.PerformLayout();
            tblp_all.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblp_HoaDon;
        private Label lb_HoaDonThanhToan;
        private TextBox txt_DiaChi;
        private Label lb_DiaChi;
        private ListView lv_HoaDonThanhToan;
        private ColumnHeader cl_stt;
        private ColumnHeader cl_Phong;
        private ColumnHeader cl_SoNgayThue;
        private ColumnHeader cl_DonGia;
        private ColumnHeader cl_ThanhTien;
        private Label lb_KhachHang;
        private TextBox txt_TriGia;
        private TextBox txt_KhachHang;
        private Label lb_TriGia;
        private TableLayoutPanel tblp_lvHoaDon;
        private TableLayoutPanel tblp_btn;
        private TableLayoutPanel tblp_input;
        private TableLayoutPanel tblp_all;
        private Button btn_QuayLai;
        private Button btn_Tim;
        private Button btn_ThanhToan;
        private Button btn_reset;
    }
}