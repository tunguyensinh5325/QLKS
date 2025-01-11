namespace QLKSGUI
{
    partial class Form_PhieuThuePhong
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
            tableLayoutPanel2 = new TableLayoutPanel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cbb_Phong = new ComboBox();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dtp_NgayTra = new DateTimePicker();
            dtp_NgayThue = new DateTimePicker();
            lbl_ = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tblp_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picb_QuangCao).BeginInit();
            tblp_Ten.SuspendLayout();
            tblp_CMNDiaChi.SuspendLayout();
            tblp_DiaChi.SuspendLayout();
            tblp_CMND.SuspendLayout();
            gr_LoaiKhach.SuspendLayout();
            tblp_Phong.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tblp_Form
            // 
            tblp_Form.ColumnCount = 4;
            tblp_Form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.0025864F));
            tblp_Form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.878788F));
            tblp_Form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.4242439F));
            tblp_Form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.90909F));
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
            tblp_Form.Controls.Add(tableLayoutPanel1, 1, 3);
            tblp_Form.Dock = DockStyle.Fill;
            tblp_Form.Location = new Point(0, 0);
            tblp_Form.Margin = new Padding(5, 4, 5, 4);
            tblp_Form.Name = "tblp_Form";
            tblp_Form.RowCount = 7;
            tblp_Form.RowStyles.Add(new RowStyle(SizeType.Percent, 26.5193367F));
            tblp_Form.RowStyles.Add(new RowStyle(SizeType.Percent, 73.48066F));
            tblp_Form.RowStyles.Add(new RowStyle(SizeType.Absolute, 11F));
            tblp_Form.RowStyles.Add(new RowStyle(SizeType.Absolute, 132F));
            tblp_Form.RowStyles.Add(new RowStyle(SizeType.Absolute, 272F));
            tblp_Form.RowStyles.Add(new RowStyle(SizeType.Absolute, 11F));
            tblp_Form.RowStyles.Add(new RowStyle(SizeType.Absolute, 225F));
            tblp_Form.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tblp_Form.Size = new Size(1429, 913);
            tblp_Form.TabIndex = 0;
            // 
            // lbl_PhieuThuePhong
            // 
            lbl_PhieuThuePhong.AutoSize = true;
            tblp_Form.SetColumnSpan(lbl_PhieuThuePhong, 2);
            lbl_PhieuThuePhong.Dock = DockStyle.Fill;
            lbl_PhieuThuePhong.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_PhieuThuePhong.Location = new Point(388, 0);
            lbl_PhieuThuePhong.Name = "lbl_PhieuThuePhong";
            lbl_PhieuThuePhong.Size = new Size(767, 49);
            lbl_PhieuThuePhong.TabIndex = 40;
            lbl_PhieuThuePhong.Text = "Phiếu Thuê Phòng";
            lbl_PhieuThuePhong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // liv_KhachHang
            // 
            liv_KhachHang.Columns.AddRange(new ColumnHeader[] { cl_STT, cl_KhachHang, cl_LoaiKhach, cl_CMND, cl_DiaChi });
            tblp_Form.SetColumnSpan(liv_KhachHang, 4);
            liv_KhachHang.Dock = DockStyle.Fill;
            liv_KhachHang.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            liv_KhachHang.FullRowSelect = true;
            liv_KhachHang.GridLines = true;
            liv_KhachHang.Location = new Point(3, 612);
            liv_KhachHang.Margin = new Padding(3, 2, 3, 2);
            liv_KhachHang.Name = "liv_KhachHang";
            liv_KhachHang.Size = new Size(1423, 221);
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
            cl_KhachHang.Width = 250;
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
            cl_CMND.Width = 200;
            // 
            // cl_DiaChi
            // 
            cl_DiaChi.Text = "Địa chỉ";
            cl_DiaChi.TextAlign = HorizontalAlignment.Center;
            cl_DiaChi.Width = 200;
            // 
            // btn_SuaThongTin
            // 
            btn_SuaThongTin.Dock = DockStyle.Fill;
            btn_SuaThongTin.Enabled = false;
            btn_SuaThongTin.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SuaThongTin.Location = new Point(671, 837);
            btn_SuaThongTin.Margin = new Padding(3, 2, 3, 2);
            btn_SuaThongTin.Name = "btn_SuaThongTin";
            btn_SuaThongTin.Size = new Size(484, 74);
            btn_SuaThongTin.TabIndex = 46;
            btn_SuaThongTin.Text = "Sửa đổi thông tin khách hàng";
            btn_SuaThongTin.UseVisualStyleBackColor = true;
            btn_SuaThongTin.Click += btn_SuaThongTin_Click;
            // 
            // btn_QuayLai
            // 
            btn_QuayLai.Dock = DockStyle.Fill;
            btn_QuayLai.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_QuayLai.Location = new Point(1161, 837);
            btn_QuayLai.Margin = new Padding(3, 2, 3, 2);
            btn_QuayLai.Name = "btn_QuayLai";
            btn_QuayLai.Size = new Size(265, 74);
            btn_QuayLai.TabIndex = 44;
            btn_QuayLai.Text = "Quay Lại";
            btn_QuayLai.UseVisualStyleBackColor = true;
            btn_QuayLai.Click += btn_QuayLai_Click;
            // 
            // btn_Them
            // 
            btn_Them.Dock = DockStyle.Fill;
            btn_Them.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Them.Location = new Point(388, 837);
            btn_Them.Margin = new Padding(3, 2, 3, 2);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(277, 74);
            btn_Them.TabIndex = 45;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_XuatPhieu
            // 
            btn_XuatPhieu.Dock = DockStyle.Fill;
            btn_XuatPhieu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_XuatPhieu.Location = new Point(3, 837);
            btn_XuatPhieu.Margin = new Padding(3, 2, 3, 2);
            btn_XuatPhieu.Name = "btn_XuatPhieu";
            btn_XuatPhieu.Size = new Size(379, 74);
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
            picb_QuangCao.Location = new Point(5, 53);
            picb_QuangCao.Margin = new Padding(5, 4, 5, 4);
            picb_QuangCao.Name = "picb_QuangCao";
            tblp_Form.SetRowSpan(picb_QuangCao, 2);
            picb_QuangCao.Size = new Size(1419, 138);
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
            tblp_Ten.Location = new Point(5, 199);
            tblp_Ten.Margin = new Padding(5, 4, 5, 4);
            tblp_Ten.Name = "tblp_Ten";
            tblp_Ten.RowCount = 1;
            tblp_Ten.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblp_Ten.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tblp_Ten.Size = new Size(375, 124);
            tblp_Ten.TabIndex = 51;
            // 
            // lbl_Ten
            // 
            lbl_Ten.AutoSize = true;
            lbl_Ten.Dock = DockStyle.Top;
            lbl_Ten.Location = new Point(3, 0);
            lbl_Ten.Name = "lbl_Ten";
            lbl_Ten.Size = new Size(132, 27);
            lbl_Ten.TabIndex = 48;
            lbl_Ten.Text = "Tên* :";
            lbl_Ten.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_Ten
            // 
            txt_Ten.Dock = DockStyle.Top;
            txt_Ten.Location = new Point(141, 2);
            txt_Ten.Margin = new Padding(3, 2, 3, 2);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.PlaceholderText = "...................................................";
            txt_Ten.Size = new Size(231, 35);
            txt_Ten.TabIndex = 49;
            // 
            // tblp_CMNDiaChi
            // 
            tblp_CMNDiaChi.ColumnCount = 1;
            tblp_CMNDiaChi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblp_CMNDiaChi.Controls.Add(tblp_DiaChi, 0, 1);
            tblp_CMNDiaChi.Controls.Add(tblp_CMND, 0, 0);
            tblp_CMNDiaChi.Dock = DockStyle.Fill;
            tblp_CMNDiaChi.Location = new Point(5, 331);
            tblp_CMNDiaChi.Margin = new Padding(5, 4, 5, 4);
            tblp_CMNDiaChi.Name = "tblp_CMNDiaChi";
            tblp_CMNDiaChi.RowCount = 2;
            tblp_CMNDiaChi.RowStyles.Add(new RowStyle(SizeType.Percent, 50.8771935F));
            tblp_CMNDiaChi.RowStyles.Add(new RowStyle(SizeType.Percent, 49.1228065F));
            tblp_CMNDiaChi.Size = new Size(375, 264);
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
            tblp_DiaChi.Location = new Point(5, 138);
            tblp_DiaChi.Margin = new Padding(5, 4, 5, 4);
            tblp_DiaChi.Name = "tblp_DiaChi";
            tblp_DiaChi.RowCount = 1;
            tblp_DiaChi.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblp_DiaChi.Size = new Size(365, 122);
            tblp_DiaChi.TabIndex = 54;
            // 
            // lbl_DiaChi
            // 
            lbl_DiaChi.AutoSize = true;
            lbl_DiaChi.Dock = DockStyle.Top;
            lbl_DiaChi.Location = new Point(3, 0);
            lbl_DiaChi.Name = "lbl_DiaChi";
            lbl_DiaChi.Size = new Size(134, 27);
            lbl_DiaChi.TabIndex = 55;
            lbl_DiaChi.Text = "Địa chỉ :";
            lbl_DiaChi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Dock = DockStyle.Top;
            txt_DiaChi.Location = new Point(143, 2);
            txt_DiaChi.Margin = new Padding(3, 2, 3, 2);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.PlaceholderText = "...................................................";
            txt_DiaChi.Size = new Size(219, 35);
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
            tblp_CMND.Location = new Point(5, 4);
            tblp_CMND.Margin = new Padding(5, 4, 5, 4);
            tblp_CMND.Name = "tblp_CMND";
            tblp_CMND.RowCount = 1;
            tblp_CMND.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblp_CMND.Size = new Size(365, 126);
            tblp_CMND.TabIndex = 52;
            // 
            // lbl_CMND
            // 
            lbl_CMND.AutoSize = true;
            lbl_CMND.Dock = DockStyle.Top;
            lbl_CMND.Location = new Point(3, 0);
            lbl_CMND.Name = "lbl_CMND";
            lbl_CMND.Size = new Size(130, 27);
            lbl_CMND.TabIndex = 48;
            lbl_CMND.Text = "CMND* :";
            lbl_CMND.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_CMND
            // 
            txt_CMND.Dock = DockStyle.Top;
            txt_CMND.Location = new Point(139, 2);
            txt_CMND.Margin = new Padding(3, 2, 3, 2);
            txt_CMND.Name = "txt_CMND";
            txt_CMND.PlaceholderText = "...................................................";
            txt_CMND.Size = new Size(223, 35);
            txt_CMND.TabIndex = 49;
            // 
            // gr_LoaiKhach
            // 
            gr_LoaiKhach.Controls.Add(rdbtn_NuocNgoai);
            gr_LoaiKhach.Controls.Add(rdbtn_NoiDia);
            gr_LoaiKhach.Dock = DockStyle.Fill;
            gr_LoaiKhach.Location = new Point(1163, 199);
            gr_LoaiKhach.Margin = new Padding(5, 4, 5, 4);
            gr_LoaiKhach.Name = "gr_LoaiKhach";
            gr_LoaiKhach.Padding = new Padding(5, 4, 5, 4);
            gr_LoaiKhach.Size = new Size(261, 124);
            gr_LoaiKhach.TabIndex = 56;
            gr_LoaiKhach.TabStop = false;
            gr_LoaiKhach.Text = "Loại Khách";
            // 
            // rdbtn_NuocNgoai
            // 
            rdbtn_NuocNgoai.AutoSize = true;
            rdbtn_NuocNgoai.Location = new Point(31, 67);
            rdbtn_NuocNgoai.Margin = new Padding(5, 4, 5, 4);
            rdbtn_NuocNgoai.Name = "rdbtn_NuocNgoai";
            rdbtn_NuocNgoai.Size = new Size(149, 31);
            rdbtn_NuocNgoai.TabIndex = 0;
            rdbtn_NuocNgoai.TabStop = true;
            rdbtn_NuocNgoai.Text = "Nước ngoài";
            rdbtn_NuocNgoai.UseVisualStyleBackColor = true;
            // 
            // rdbtn_NoiDia
            // 
            rdbtn_NoiDia.AutoSize = true;
            rdbtn_NoiDia.Location = new Point(31, 37);
            rdbtn_NoiDia.Margin = new Padding(5, 4, 5, 4);
            rdbtn_NoiDia.Name = "rdbtn_NoiDia";
            rdbtn_NoiDia.Size = new Size(107, 31);
            rdbtn_NoiDia.TabIndex = 0;
            rdbtn_NoiDia.TabStop = true;
            rdbtn_NoiDia.Text = "Nội địa";
            rdbtn_NoiDia.UseVisualStyleBackColor = true;
            // 
            // tblp_Phong
            // 
            tblp_Phong.ColumnCount = 2;
            tblp_Form.SetColumnSpan(tblp_Phong, 3);
            tblp_Phong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.3326874F));
            tblp_Phong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.66731F));
            tblp_Phong.Controls.Add(lbl_ChonPhong, 0, 0);
            tblp_Phong.Controls.Add(tableLayoutPanel2, 1, 0);
            tblp_Phong.Dock = DockStyle.Fill;
            tblp_Phong.Location = new Point(390, 331);
            tblp_Phong.Margin = new Padding(5, 4, 5, 4);
            tblp_Phong.Name = "tblp_Phong";
            tblp_Phong.RowCount = 2;
            tblp_Phong.RowStyles.Add(new RowStyle(SizeType.Percent, 73.86364F));
            tblp_Phong.RowStyles.Add(new RowStyle(SizeType.Percent, 26.136364F));
            tblp_Phong.Size = new Size(1034, 264);
            tblp_Phong.TabIndex = 59;
            // 
            // lbl_ChonPhong
            // 
            lbl_ChonPhong.AutoSize = true;
            lbl_ChonPhong.Dock = DockStyle.Top;
            lbl_ChonPhong.Location = new Point(3, 0);
            lbl_ChonPhong.Name = "lbl_ChonPhong";
            lbl_ChonPhong.Size = new Size(349, 27);
            lbl_ChonPhong.TabIndex = 33;
            lbl_ChonPhong.Text = "Chọn Phòng :";
            lbl_ChonPhong.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(cbb_Phong, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Location = new Point(358, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 27.7777786F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 18.5185184F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 19.1358032F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 17.28395F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Size = new Size(673, 189);
            tableLayoutPanel2.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(3, 155);
            label5.Name = "label5";
            label5.Size = new Size(640, 34);
            label5.TabIndex = 38;
            label5.Text = "*Lưu ý: Vượt số lượng trên sẽ phụ thu thêm 25% hóa đơn, ngoại quốc 50%";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 123);
            label4.Name = "label4";
            label4.Size = new Size(195, 27);
            label4.TabIndex = 37;
            label4.Text = "Phòng lớn: 8 người";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 87);
            label3.Name = "label3";
            label3.Size = new Size(194, 27);
            label3.TabIndex = 36;
            label3.Text = "Phòng đôi: 2 người";
            // 
            // cbb_Phong
            // 
            cbb_Phong.FormattingEnabled = true;
            cbb_Phong.Location = new Point(5, 4);
            cbb_Phong.Margin = new Padding(5, 4, 5, 4);
            cbb_Phong.Name = "cbb_Phong";
            cbb_Phong.Size = new Size(663, 35);
            cbb_Phong.TabIndex = 34;
            cbb_Phong.DrawItem += cbb_Phong_DrawItem;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 52);
            label2.Name = "label2";
            label2.Size = new Size(201, 27);
            label2.TabIndex = 35;
            label2.Text = "Phòng đơn: 1 người";
            label2.Click += label2_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tblp_Form.SetColumnSpan(tableLayoutPanel1, 2);
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dtp_NgayTra, 1, 1);
            tableLayoutPanel1.Controls.Add(dtp_NgayThue, 1, 0);
            tableLayoutPanel1.Controls.Add(lbl_, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(388, 198);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(719, 126);
            tableLayoutPanel1.TabIndex = 60;
            // 
            // dtp_NgayTra
            // 
            dtp_NgayTra.Dock = DockStyle.Top;
            dtp_NgayTra.Location = new Point(364, 67);
            dtp_NgayTra.Margin = new Padding(5, 4, 5, 4);
            dtp_NgayTra.MinDate = new DateTime(2025, 1, 5, 0, 0, 0, 0);
            dtp_NgayTra.Name = "dtp_NgayTra";
            dtp_NgayTra.Size = new Size(350, 35);
            dtp_NgayTra.TabIndex = 33;
            dtp_NgayTra.ValueChanged += dtp_NgayTra_ValueChanged;
            // 
            // dtp_NgayThue
            // 
            dtp_NgayThue.Dock = DockStyle.Top;
            dtp_NgayThue.Location = new Point(364, 4);
            dtp_NgayThue.Margin = new Padding(5, 4, 5, 4);
            dtp_NgayThue.MinDate = new DateTime(2025, 1, 5, 0, 0, 0, 0);
            dtp_NgayThue.Name = "dtp_NgayThue";
            dtp_NgayThue.Size = new Size(350, 35);
            dtp_NgayThue.TabIndex = 31;
            dtp_NgayThue.ValueChanged += dtp_NgayThue_ValueChanged;
            // 
            // lbl_
            // 
            lbl_.AutoSize = true;
            lbl_.Dock = DockStyle.Top;
            lbl_.Location = new Point(3, 0);
            lbl_.Name = "lbl_";
            lbl_.Size = new Size(353, 27);
            lbl_.TabIndex = 30;
            lbl_.Text = "Ngày bắt đầu thuê:";
            lbl_.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(3, 63);
            label1.Name = "label1";
            label1.Size = new Size(353, 27);
            label1.TabIndex = 32;
            label1.Text = "Ngày trả:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form_PhieuThuePhong
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1429, 913);
            Controls.Add(tblp_Form);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form_PhieuThuePhong";
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
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel1;
        private DateTimePicker dtp_NgayTra;
        private Label label1;
        private DateTimePicker dtp_NgayThue;
        private Label lbl_;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
    }
}
