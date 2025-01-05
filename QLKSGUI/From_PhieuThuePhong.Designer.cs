namespace QLKSGUI
{
    partial class From_PhieuThuePhong
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
            components = new System.ComponentModel.Container();
            tblp_Form = new TableLayoutPanel();
            dtp_NgayThue = new DateTimePicker();
            lbl_ = new Label();
            lbl_PhieuThuePhong = new Label();
            liv_KhachHang = new ListView();
            cl_STT = new ColumnHeader();
            cl_KhachHang = new ColumnHeader();
            cl_LoaiKhach = new ColumnHeader();
            cl_CMND = new ColumnHeader();
            cl_DiaChi = new ColumnHeader();
            btn_SuaThongTin = new Button();
            btn_QuayLai = new Button();
            btn_Them = new Button();
            btn_XuatPhieu = new Button();
            picb_QuangCao = new PictureBox();
            tblp_Ten = new TableLayoutPanel();
            lbl_Ten = new Label();
            txt_Ten = new TextBox();
            tblp_CMNDiaChi = new TableLayoutPanel();
            tblp_DiaChi = new TableLayoutPanel();
            lbl_DiaChi = new Label();
            txt_DiaChi = new TextBox();
            tblp_CMND = new TableLayoutPanel();
            lbl_CMND = new Label();
            txt_CMND = new TextBox();
            gr_LoaiKhach = new GroupBox();
            rdbtn_NuocNgoai = new RadioButton();
            rdbtn_NoiDia = new RadioButton();
            tblp_Phong = new TableLayoutPanel();
            lbl_ChonPhong = new Label();
            cbb_Phong = new ComboBox();
            btn_ThongTinPhong = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            tblp_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picb_QuangCao).BeginInit();
            tblp_Ten.SuspendLayout();
            tblp_CMNDiaChi.SuspendLayout();
            tblp_DiaChi.SuspendLayout();
            tblp_CMND.SuspendLayout();
            gr_LoaiKhach.SuspendLayout();
            tblp_Phong.SuspendLayout();
            SuspendLayout();
            // 
            // tblp_Form
            // 
            tblp_Form.ColumnCount = 4;
            tblp_Form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.0025864F));
            tblp_Form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.878788F));
            tblp_Form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.4242439F));
            tblp_Form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.90909F));
            tblp_Form.Controls.Add(dtp_NgayThue, 2, 3);
            tblp_Form.Controls.Add(lbl_, 1, 3);
            tblp_Form.Controls.Add(lbl_PhieuThuePhong, 1, 0);
            tblp_Form.Controls.Add(liv_KhachHang, 3, 5);
            tblp_Form.Controls.Add(btn_SuaThongTin, 2, 7);
            tblp_Form.Controls.Add(btn_QuayLai, 3, 7);
            tblp_Form.Controls.Add(btn_Them, 1, 7);
            tblp_Form.Controls.Add(btn_XuatPhieu, 0, 7);
            tblp_Form.Controls.Add(picb_QuangCao, 0, 1);
            tblp_Form.Controls.Add(tblp_Ten, 0, 3);
            tblp_Form.Controls.Add(tblp_CMNDiaChi, 0, 4);
            tblp_Form.Controls.Add(gr_LoaiKhach, 3, 3);
            tblp_Form.Controls.Add(tblp_Phong, 1, 4);
            tblp_Form.Dock = DockStyle.Fill;
            tblp_Form.Location = new Point(0, 0);
            tblp_Form.Name = "tblp_Form";
            tblp_Form.RowCount = 7;
            tblp_Form.RowStyles.Add(new RowStyle(SizeType.Percent, 26.5193367F));
            tblp_Form.RowStyles.Add(new RowStyle(SizeType.Percent, 73.48066F));
            tblp_Form.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tblp_Form.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            tblp_Form.RowStyles.Add(new RowStyle(SizeType.Absolute, 189F));
            tblp_Form.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tblp_Form.RowStyles.Add(new RowStyle(SizeType.Absolute, 166F));
            tblp_Form.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tblp_Form.Size = new Size(825, 676);
            tblp_Form.TabIndex = 0;
            // 
            // dtp_NgayThue
            // 
            dtp_NgayThue.Dock = DockStyle.Fill;
            dtp_NgayThue.Location = new Point(388, 148);
            dtp_NgayThue.MinDate = new DateTime(2025, 1, 5, 0, 0, 0, 0);
            dtp_NgayThue.Name = "dtp_NgayThue";
            dtp_NgayThue.Size = new Size(277, 27);
            dtp_NgayThue.TabIndex = 29;
            // 
            // lbl_
            // 
            lbl_.AutoSize = true;
            lbl_.Dock = DockStyle.Top;
            lbl_.Location = new Point(224, 145);
            lbl_.Margin = new Padding(2, 0, 2, 0);
            lbl_.Name = "lbl_";
            lbl_.Size = new Size(159, 20);
            lbl_.TabIndex = 28;
            lbl_.Text = "Ngày bắt đầu thuê:";
            lbl_.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_PhieuThuePhong
            // 
            lbl_PhieuThuePhong.AutoSize = true;
            tblp_Form.SetColumnSpan(lbl_PhieuThuePhong, 2);
            lbl_PhieuThuePhong.Dock = DockStyle.Fill;
            lbl_PhieuThuePhong.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_PhieuThuePhong.Location = new Point(224, 0);
            lbl_PhieuThuePhong.Margin = new Padding(2, 0, 2, 0);
            lbl_PhieuThuePhong.Name = "lbl_PhieuThuePhong";
            lbl_PhieuThuePhong.Size = new Size(442, 36);
            lbl_PhieuThuePhong.TabIndex = 40;
            lbl_PhieuThuePhong.Text = "Phiếu Thuê Phòng";
            lbl_PhieuThuePhong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // liv_KhachHang
            // 
            liv_KhachHang.Columns.AddRange(new ColumnHeader[] { cl_STT, cl_KhachHang, cl_LoaiKhach, cl_CMND, cl_DiaChi });
            tblp_Form.SetColumnSpan(liv_KhachHang, 4);
            liv_KhachHang.Dock = DockStyle.Fill;
            liv_KhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            liv_KhachHang.FullRowSelect = true;
            liv_KhachHang.GridLines = true;
            liv_KhachHang.Location = new Point(2, 454);
            liv_KhachHang.Margin = new Padding(2);
            liv_KhachHang.Name = "liv_KhachHang";
            liv_KhachHang.Size = new Size(821, 162);
            liv_KhachHang.TabIndex = 47;
            liv_KhachHang.UseCompatibleStateImageBehavior = false;
            liv_KhachHang.View = View.Details;
            liv_KhachHang.SelectedIndexChanged += liv_KhachHang_SelectedIndexChanged;
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
            // btn_SuaThongTin
            // 
            btn_SuaThongTin.Dock = DockStyle.Fill;
            btn_SuaThongTin.Enabled = false;
            btn_SuaThongTin.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SuaThongTin.Location = new Point(387, 620);
            btn_SuaThongTin.Margin = new Padding(2);
            btn_SuaThongTin.Name = "btn_SuaThongTin";
            btn_SuaThongTin.Size = new Size(279, 54);
            btn_SuaThongTin.TabIndex = 46;
            btn_SuaThongTin.Text = "Sửa đổi thông tin khách hàng";
            btn_SuaThongTin.UseVisualStyleBackColor = true;
            btn_SuaThongTin.Click += btn_SuaThongTin_Click;
            // 
            // btn_QuayLai
            // 
            btn_QuayLai.Dock = DockStyle.Fill;
            btn_QuayLai.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_QuayLai.Location = new Point(670, 620);
            btn_QuayLai.Margin = new Padding(2);
            btn_QuayLai.Name = "btn_QuayLai";
            btn_QuayLai.Size = new Size(153, 54);
            btn_QuayLai.TabIndex = 44;
            btn_QuayLai.Text = "Quay Lại";
            btn_QuayLai.UseVisualStyleBackColor = true;
            btn_QuayLai.Click += btn_QuayLai_Click;
            // 
            // btn_Them
            // 
            btn_Them.Dock = DockStyle.Fill;
            btn_Them.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Them.Location = new Point(224, 620);
            btn_Them.Margin = new Padding(2);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(159, 54);
            btn_Them.TabIndex = 45;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_XuatPhieu
            // 
            btn_XuatPhieu.Dock = DockStyle.Fill;
            btn_XuatPhieu.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_XuatPhieu.Location = new Point(2, 620);
            btn_XuatPhieu.Margin = new Padding(2);
            btn_XuatPhieu.Name = "btn_XuatPhieu";
            btn_XuatPhieu.Size = new Size(218, 54);
            btn_XuatPhieu.TabIndex = 43;
            btn_XuatPhieu.Text = "Xác nhận thuê";
            btn_XuatPhieu.UseVisualStyleBackColor = true;
            btn_XuatPhieu.Click += btn_XuatPhieu_Click;
            // 
            // picb_QuangCao
            // 
            tblp_Form.SetColumnSpan(picb_QuangCao, 4);
            picb_QuangCao.Dock = DockStyle.Fill;
            picb_QuangCao.ErrorImage = null;
            picb_QuangCao.InitialImage = null;
            picb_QuangCao.Location = new Point(3, 39);
            picb_QuangCao.Name = "picb_QuangCao";
            tblp_Form.SetRowSpan(picb_QuangCao, 2);
            picb_QuangCao.Size = new Size(819, 103);
            picb_QuangCao.TabIndex = 42;
            picb_QuangCao.TabStop = false;
            picb_QuangCao.Paint += picb_QuangCao_Paint;
            // 
            // tblp_Ten
            // 
            tblp_Ten.ColumnCount = 2;
            tblp_Ten.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.9458122F));
            tblp_Ten.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.0541878F));
            tblp_Ten.Controls.Add(lbl_Ten, 0, 0);
            tblp_Ten.Controls.Add(txt_Ten, 1, 0);
            tblp_Ten.Dock = DockStyle.Top;
            tblp_Ten.Location = new Point(3, 148);
            tblp_Ten.Name = "tblp_Ten";
            tblp_Ten.RowCount = 1;
            tblp_Ten.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblp_Ten.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tblp_Ten.Size = new Size(216, 104);
            tblp_Ten.TabIndex = 51;
            // 
            // lbl_Ten
            // 
            lbl_Ten.AutoSize = true;
            lbl_Ten.Dock = DockStyle.Top;
            lbl_Ten.Location = new Point(2, 0);
            lbl_Ten.Margin = new Padding(2, 0, 2, 0);
            lbl_Ten.Name = "lbl_Ten";
            lbl_Ten.Size = new Size(75, 20);
            lbl_Ten.TabIndex = 48;
            lbl_Ten.Text = "Tên* :";
            lbl_Ten.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_Ten
            // 
            txt_Ten.Dock = DockStyle.Top;
            txt_Ten.Location = new Point(81, 2);
            txt_Ten.Margin = new Padding(2);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.PlaceholderText = "...................................................";
            txt_Ten.Size = new Size(133, 27);
            txt_Ten.TabIndex = 49;
            // 
            // tblp_CMNDiaChi
            // 
            tblp_CMNDiaChi.ColumnCount = 1;
            tblp_CMNDiaChi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblp_CMNDiaChi.Controls.Add(tblp_DiaChi, 0, 1);
            tblp_CMNDiaChi.Controls.Add(tblp_CMND, 0, 0);
            tblp_CMNDiaChi.Dock = DockStyle.Fill;
            tblp_CMNDiaChi.Location = new Point(3, 258);
            tblp_CMNDiaChi.Name = "tblp_CMNDiaChi";
            tblp_CMNDiaChi.RowCount = 2;
            tblp_CMNDiaChi.RowStyles.Add(new RowStyle(SizeType.Percent, 50.8771935F));
            tblp_CMNDiaChi.RowStyles.Add(new RowStyle(SizeType.Percent, 49.1228065F));
            tblp_CMNDiaChi.Size = new Size(216, 183);
            tblp_CMNDiaChi.TabIndex = 55;
            // 
            // tblp_DiaChi
            // 
            tblp_DiaChi.ColumnCount = 2;
            tblp_DiaChi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.423645F));
            tblp_DiaChi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.576355F));
            tblp_DiaChi.Controls.Add(lbl_DiaChi, 0, 0);
            tblp_DiaChi.Controls.Add(txt_DiaChi, 1, 0);
            tblp_DiaChi.Dock = DockStyle.Fill;
            tblp_DiaChi.Location = new Point(3, 96);
            tblp_DiaChi.Name = "tblp_DiaChi";
            tblp_DiaChi.RowCount = 1;
            tblp_DiaChi.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblp_DiaChi.Size = new Size(210, 84);
            tblp_DiaChi.TabIndex = 54;
            // 
            // lbl_DiaChi
            // 
            lbl_DiaChi.AutoSize = true;
            lbl_DiaChi.Dock = DockStyle.Top;
            lbl_DiaChi.Location = new Point(2, 0);
            lbl_DiaChi.Margin = new Padding(2, 0, 2, 0);
            lbl_DiaChi.Name = "lbl_DiaChi";
            lbl_DiaChi.Size = new Size(76, 20);
            lbl_DiaChi.TabIndex = 55;
            lbl_DiaChi.Text = "Địa chỉ :";
            lbl_DiaChi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Dock = DockStyle.Top;
            txt_DiaChi.Location = new Point(82, 2);
            txt_DiaChi.Margin = new Padding(2);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.PlaceholderText = "...................................................";
            txt_DiaChi.Size = new Size(126, 27);
            txt_DiaChi.TabIndex = 56;
            // 
            // tblp_CMND
            // 
            tblp_CMND.ColumnCount = 2;
            tblp_CMND.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.4384232F));
            tblp_CMND.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5615768F));
            tblp_CMND.Controls.Add(lbl_CMND, 0, 0);
            tblp_CMND.Controls.Add(txt_CMND, 1, 0);
            tblp_CMND.Dock = DockStyle.Fill;
            tblp_CMND.Location = new Point(3, 3);
            tblp_CMND.Name = "tblp_CMND";
            tblp_CMND.RowCount = 1;
            tblp_CMND.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblp_CMND.Size = new Size(210, 87);
            tblp_CMND.TabIndex = 52;
            // 
            // lbl_CMND
            // 
            lbl_CMND.AutoSize = true;
            lbl_CMND.Dock = DockStyle.Top;
            lbl_CMND.Location = new Point(2, 0);
            lbl_CMND.Margin = new Padding(2, 0, 2, 0);
            lbl_CMND.Name = "lbl_CMND";
            lbl_CMND.Size = new Size(74, 20);
            lbl_CMND.TabIndex = 48;
            lbl_CMND.Text = "CMND* :";
            lbl_CMND.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_CMND
            // 
            txt_CMND.Dock = DockStyle.Top;
            txt_CMND.Location = new Point(80, 2);
            txt_CMND.Margin = new Padding(2);
            txt_CMND.Name = "txt_CMND";
            txt_CMND.PlaceholderText = "...................................................";
            txt_CMND.Size = new Size(128, 27);
            txt_CMND.TabIndex = 49;
            // 
            // gr_LoaiKhach
            // 
            gr_LoaiKhach.Controls.Add(rdbtn_NuocNgoai);
            gr_LoaiKhach.Controls.Add(rdbtn_NoiDia);
            gr_LoaiKhach.Dock = DockStyle.Fill;
            gr_LoaiKhach.Location = new Point(671, 148);
            gr_LoaiKhach.Name = "gr_LoaiKhach";
            gr_LoaiKhach.Size = new Size(151, 104);
            gr_LoaiKhach.TabIndex = 56;
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
            // tblp_Phong
            // 
            tblp_Phong.ColumnCount = 2;
            tblp_Form.SetColumnSpan(tblp_Phong, 3);
            tblp_Phong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.4350643F));
            tblp_Phong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.56493F));
            tblp_Phong.Controls.Add(lbl_ChonPhong, 0, 0);
            tblp_Phong.Controls.Add(cbb_Phong, 1, 0);
            tblp_Phong.Controls.Add(btn_ThongTinPhong, 1, 1);
            tblp_Phong.Dock = DockStyle.Fill;
            tblp_Phong.Location = new Point(225, 258);
            tblp_Phong.Name = "tblp_Phong";
            tblp_Phong.RowCount = 2;
            tblp_Phong.RowStyles.Add(new RowStyle(SizeType.Percent, 46.11111F));
            tblp_Phong.RowStyles.Add(new RowStyle(SizeType.Percent, 53.88889F));
            tblp_Phong.Size = new Size(597, 183);
            tblp_Phong.TabIndex = 59;
            // 
            // lbl_ChonPhong
            // 
            lbl_ChonPhong.AutoSize = true;
            lbl_ChonPhong.Dock = DockStyle.Top;
            lbl_ChonPhong.Location = new Point(2, 0);
            lbl_ChonPhong.Margin = new Padding(2, 0, 2, 0);
            lbl_ChonPhong.Name = "lbl_ChonPhong";
            lbl_ChonPhong.Size = new Size(159, 20);
            lbl_ChonPhong.TabIndex = 33;
            lbl_ChonPhong.Text = "Chọn Phòng :";
            lbl_ChonPhong.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbb_Phong
            // 
            cbb_Phong.Dock = DockStyle.Top;
            cbb_Phong.FormattingEnabled = true;
            cbb_Phong.Location = new Point(166, 3);
            cbb_Phong.Name = "cbb_Phong";
            cbb_Phong.Size = new Size(428, 28);
            cbb_Phong.TabIndex = 34;
            cbb_Phong.DrawItem += cbb_Phong_DrawItem;
            // 
            // btn_ThongTinPhong
            // 
            btn_ThongTinPhong.Dock = DockStyle.Fill;
            btn_ThongTinPhong.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ThongTinPhong.Location = new Point(165, 86);
            btn_ThongTinPhong.Margin = new Padding(2);
            btn_ThongTinPhong.Name = "btn_ThongTinPhong";
            btn_ThongTinPhong.Size = new Size(430, 95);
            btn_ThongTinPhong.TabIndex = 47;
            btn_ThongTinPhong.Text = "Nhấn vào đây để biết thêm thông tin \r\nvề tất cả các phòng";
            btn_ThongTinPhong.UseVisualStyleBackColor = true;
            btn_ThongTinPhong.Click += btn_ThongTinPhong_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // From_PhieuThuePhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 676);
            Controls.Add(tblp_Form);
            Name = "From_PhieuThuePhong";
            Text = "PhieuThuePhong";
            Load += Form_PhieuThuePhong_Load;
            tblp_Form.ResumeLayout(false);
            tblp_Form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picb_QuangCao).EndInit();
            tblp_Ten.ResumeLayout(false);
            tblp_Ten.PerformLayout();
            tblp_CMNDiaChi.ResumeLayout(false);
            tblp_DiaChi.ResumeLayout(false);
            tblp_DiaChi.PerformLayout();
            tblp_CMND.ResumeLayout(false);
            tblp_CMND.PerformLayout();
            gr_LoaiKhach.ResumeLayout(false);
            gr_LoaiKhach.PerformLayout();
            tblp_Phong.ResumeLayout(false);
            tblp_Phong.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblp_Form;
        private Label lbl_PhieuThuePhong;
        private Button btn_QuayLai;
        private ListView liv_KhachHang;
        private ColumnHeader cl_STT;
        private ColumnHeader cl_KhachHang;
        private ColumnHeader cl_LoaiKhach;
        private ColumnHeader cl_CMND;
        private ColumnHeader cl_DiaChi;
        private Button btn_Them;
        private Button btn_XuatPhieu;
        private Button btn_SuaThongTin;
        private System.Windows.Forms.Timer timer1;
        private PictureBox picb_QuangCao;
        private Label lbl_Ten;
        private TextBox txt_Ten;
        private TableLayoutPanel tblp_Ten;
        private TableLayoutPanel tblp_CMND;
        private Label lbl_CMND;
        private TextBox txt_CMND;
        private TableLayoutPanel tblp_DiaChi;
        private DateTimePicker dtp_NgayThue;
        private Label lbl_;
        private Label lbl_DiaChi;
        private TextBox txt_DiaChi;
        private TableLayoutPanel tblp_CMNDiaChi;
        private GroupBox gr_LoaiKhach;
        private RadioButton rdbtn_NuocNgoai;
        private RadioButton rdbtn_NoiDia;
        private TableLayoutPanel tblp_Phong;
        private Label lbl_ChonPhong;
        private ComboBox cbb_Phong;
        private Button btn_ThongTinPhong;
    }
}
