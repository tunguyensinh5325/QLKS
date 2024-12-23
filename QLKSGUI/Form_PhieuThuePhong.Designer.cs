namespace QLKSGUI
{
    partial class Form_PhieuThuePhong
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
            liv_KhachHang = new ListView();
            cl_STT = new ColumnHeader();
            cl_KhachHang = new ColumnHeader();
            cl_LoaiKhach = new ColumnHeader();
            cl_CMND = new ColumnHeader();
            cl_DiaChi = new ColumnHeader();
            lbl_PhieuThuePhong = new Label();
            txt_Ten = new TextBox();
            lbl_Ten = new Label();
            lbl_ = new Label();
            btn_QuayLai = new Button();
            btn_XuatPhieu = new Button();
            dtp_NgayThue = new DateTimePicker();
            txt_CMND = new TextBox();
            lbl_CMND = new Label();
            txt_DiaChi = new TextBox();
            lbl_DiaChi = new Label();
            gr_LoaiKhach = new GroupBox();
            rdbtn_NuocNgoai = new RadioButton();
            rdbtn_NoiDia = new RadioButton();
            btn_Them = new Button();
            gr_LoaiKhach.SuspendLayout();
            SuspendLayout();
            // 
            // liv_KhachHang
            // 
            liv_KhachHang.Columns.AddRange(new ColumnHeader[] { cl_STT, cl_KhachHang, cl_LoaiKhach, cl_CMND, cl_DiaChi });
            liv_KhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            liv_KhachHang.FullRowSelect = true;
            liv_KhachHang.GridLines = true;
            liv_KhachHang.Location = new Point(130, 180);
            liv_KhachHang.Margin = new Padding(2);
            liv_KhachHang.Name = "liv_KhachHang";
            liv_KhachHang.Size = new Size(540, 207);
            liv_KhachHang.TabIndex = 5;
            liv_KhachHang.UseCompatibleStateImageBehavior = false;
            liv_KhachHang.View = View.Details;
            // 
            // cl_STT
            // 
            cl_STT.Text = "STT";
            cl_STT.Width = 80;
            // 
            // cl_KhachHang
            // 
            cl_KhachHang.Text = "Khách hàng";
            cl_KhachHang.TextAlign = HorizontalAlignment.Center;
            cl_KhachHang.Width = 150;
            // 
            // cl_LoaiKhach
            // 
            cl_LoaiKhach.Text = "Loại Khách";
            cl_LoaiKhach.TextAlign = HorizontalAlignment.Center;
            cl_LoaiKhach.Width = 160;
            // 
            // cl_CMND
            // 
            cl_CMND.Text = "CMND";
            cl_CMND.TextAlign = HorizontalAlignment.Center;
            cl_CMND.Width = 140;
            // 
            // cl_DiaChi
            // 
            cl_DiaChi.Text = "Địa chỉ";
            cl_DiaChi.TextAlign = HorizontalAlignment.Center;
            cl_DiaChi.Width = 140;
            // 
            // lbl_PhieuThuePhong
            // 
            lbl_PhieuThuePhong.AutoSize = true;
            lbl_PhieuThuePhong.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_PhieuThuePhong.Location = new Point(290, 9);
            lbl_PhieuThuePhong.Margin = new Padding(2, 0, 2, 0);
            lbl_PhieuThuePhong.Name = "lbl_PhieuThuePhong";
            lbl_PhieuThuePhong.Size = new Size(226, 35);
            lbl_PhieuThuePhong.TabIndex = 4;
            lbl_PhieuThuePhong.Text = "Phiếu Thuê Phòng..";
            // 
            // txt_Ten
            // 
            txt_Ten.Enabled = false;
            txt_Ten.Location = new Point(113, 60);
            txt_Ten.Margin = new Padding(2);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.PlaceholderText = "...................................................";
            txt_Ten.Size = new Size(124, 27);
            txt_Ten.TabIndex = 22;
            // 
            // lbl_Ten
            // 
            lbl_Ten.AutoSize = true;
            lbl_Ten.Location = new Point(51, 67);
            lbl_Ten.Margin = new Padding(2, 0, 2, 0);
            lbl_Ten.Name = "lbl_Ten";
            lbl_Ten.Size = new Size(45, 20);
            lbl_Ten.TabIndex = 21;
            lbl_Ten.Text = "Tên* :";
            // 
            // lbl_
            // 
            lbl_.AutoSize = true;
            lbl_.Location = new Point(284, 65);
            lbl_.Margin = new Padding(2, 0, 2, 0);
            lbl_.Name = "lbl_";
            lbl_.Size = new Size(135, 20);
            lbl_.TabIndex = 23;
            lbl_.Text = "Ngày bắt đầu thuê:";
            // 
            // btn_QuayLai
            // 
            btn_QuayLai.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_QuayLai.Location = new Point(548, 402);
            btn_QuayLai.Margin = new Padding(2);
            btn_QuayLai.Name = "btn_QuayLai";
            btn_QuayLai.Size = new Size(122, 37);
            btn_QuayLai.TabIndex = 26;
            btn_QuayLai.Text = "Quay Lại";
            btn_QuayLai.UseVisualStyleBackColor = true;
            btn_QuayLai.Click += btn_QuayLai_Click;
            // 
            // btn_XuatPhieu
            // 
            btn_XuatPhieu.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_XuatPhieu.Location = new Point(132, 402);
            btn_XuatPhieu.Margin = new Padding(2);
            btn_XuatPhieu.Name = "btn_XuatPhieu";
            btn_XuatPhieu.Size = new Size(171, 37);
            btn_XuatPhieu.TabIndex = 25;
            btn_XuatPhieu.Text = "Xác nhận thuê";
            btn_XuatPhieu.UseVisualStyleBackColor = true;
            btn_XuatPhieu.Click += btn_XuatPhieu_Click;
            // 
            // dtp_NgayThue
            // 
            dtp_NgayThue.Location = new Point(424, 62);
            dtp_NgayThue.Name = "dtp_NgayThue";
            dtp_NgayThue.Size = new Size(246, 27);
            dtp_NgayThue.TabIndex = 27;
            // 
            // txt_CMND
            // 
            txt_CMND.Enabled = false;
            txt_CMND.Location = new Point(113, 110);
            txt_CMND.Margin = new Padding(2);
            txt_CMND.Name = "txt_CMND";
            txt_CMND.PlaceholderText = "...................................................";
            txt_CMND.Size = new Size(124, 27);
            txt_CMND.TabIndex = 29;
            // 
            // lbl_CMND
            // 
            lbl_CMND.AutoSize = true;
            lbl_CMND.Location = new Point(51, 117);
            lbl_CMND.Margin = new Padding(2, 0, 2, 0);
            lbl_CMND.Name = "lbl_CMND";
            lbl_CMND.Size = new Size(66, 20);
            lbl_CMND.TabIndex = 28;
            lbl_CMND.Text = "CMND* :";
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Enabled = false;
            txt_DiaChi.Location = new Point(339, 114);
            txt_DiaChi.Margin = new Padding(2);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.PlaceholderText = "...................................................";
            txt_DiaChi.Size = new Size(124, 27);
            txt_DiaChi.TabIndex = 31;
            // 
            // lbl_DiaChi
            // 
            lbl_DiaChi.AutoSize = true;
            lbl_DiaChi.Location = new Point(277, 121);
            lbl_DiaChi.Margin = new Padding(2, 0, 2, 0);
            lbl_DiaChi.Name = "lbl_DiaChi";
            lbl_DiaChi.Size = new Size(62, 20);
            lbl_DiaChi.TabIndex = 30;
            lbl_DiaChi.Text = "Địa chỉ :";
            // 
            // gr_LoaiKhach
            // 
            gr_LoaiKhach.Controls.Add(rdbtn_NuocNgoai);
            gr_LoaiKhach.Controls.Add(rdbtn_NoiDia);
            gr_LoaiKhach.Location = new Point(503, 95);
            gr_LoaiKhach.Name = "gr_LoaiKhach";
            gr_LoaiKhach.Size = new Size(167, 80);
            gr_LoaiKhach.TabIndex = 33;
            gr_LoaiKhach.TabStop = false;
            gr_LoaiKhach.Text = "Loại Khách";
            // 
            // rdbtn_NuocNgoai
            // 
            rdbtn_NuocNgoai.AutoSize = true;
            rdbtn_NuocNgoai.Location = new Point(19, 50);
            rdbtn_NuocNgoai.Name = "rdbtn_NuocNgoai";
            rdbtn_NuocNgoai.Size = new Size(111, 24);
            rdbtn_NuocNgoai.TabIndex = 0;
            rdbtn_NuocNgoai.TabStop = true;
            rdbtn_NuocNgoai.Text = "Nước Ngoài";
            rdbtn_NuocNgoai.UseVisualStyleBackColor = true;
            // 
            // rdbtn_NoiDia
            // 
            rdbtn_NoiDia.AutoSize = true;
            rdbtn_NoiDia.Location = new Point(19, 27);
            rdbtn_NoiDia.Name = "rdbtn_NoiDia";
            rdbtn_NoiDia.Size = new Size(79, 24);
            rdbtn_NoiDia.TabIndex = 0;
            rdbtn_NoiDia.TabStop = true;
            rdbtn_NoiDia.Text = "Nội địa";
            rdbtn_NoiDia.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            btn_Them.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Them.Location = new Point(355, 402);
            btn_Them.Margin = new Padding(2);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(122, 37);
            btn_Them.TabIndex = 34;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // Form_PhieuThuePhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Them);
            Controls.Add(gr_LoaiKhach);
            Controls.Add(txt_DiaChi);
            Controls.Add(lbl_DiaChi);
            Controls.Add(txt_CMND);
            Controls.Add(lbl_CMND);
            Controls.Add(dtp_NgayThue);
            Controls.Add(btn_QuayLai);
            Controls.Add(btn_XuatPhieu);
            Controls.Add(lbl_);
            Controls.Add(txt_Ten);
            Controls.Add(lbl_Ten);
            Controls.Add(liv_KhachHang);
            Controls.Add(lbl_PhieuThuePhong);
            Name = "Form_PhieuThuePhong";
            Text = "PhieuThuePhong";
            Load += frmKhachHang_Load;
            gr_LoaiKhach.ResumeLayout(false);
            gr_LoaiKhach.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView liv_KhachHang;
        private ColumnHeader cl_STT;
        private ColumnHeader cl_KhachHang;
        private ColumnHeader cl_LoaiKhach;
        private ColumnHeader cl_CMND;
        private ColumnHeader cl_DiaChi;
        private Label lbl_PhieuThuePhong;
        private TextBox txt_Ten;
        private Label lbl_Ten;
        private Label lbl_;
        private Button btn_QuayLai;
        private Button btn_XuatPhieu;
        private DateTimePicker dtp_NgayThue;
        private TextBox txt_CMND;
        private Label lbl_CMND;
        private TextBox txt_DiaChi;
        private Label lbl_DiaChi;
        private GroupBox gr_LoaiKhach;
        private RadioButton rdbtn_NuocNgoai;
        private RadioButton rdbtn_NoiDia;
        private Button btn_Them;
    }
}