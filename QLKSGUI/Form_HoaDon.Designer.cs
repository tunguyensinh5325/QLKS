namespace Form_DSPhong_HoaDon
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
            btn_QuayLai = new Button();
            btn_ThanhToan = new Button();
            txt_TriGia = new TextBox();
            txt_DiaChi = new TextBox();
            txt_KhachHang = new TextBox();
            lb_TriGia = new Label();
            lb_DiaChi = new Label();
            lb_KhachHang = new Label();
            lv_HoaDonThanhToan = new ListView();
            cl_stt = new ColumnHeader();
            cl_Phong = new ColumnHeader();
            cl_SoNgayThue = new ColumnHeader();
            cl_DonGia = new ColumnHeader();
            cl_ThanhTien = new ColumnHeader();
            lb_HoaDonThanhToan = new Label();
            btn_Tim = new Button();
            btn_reset = new Button();
            SuspendLayout();
            // 
            // btn_QuayLai
            // 
            btn_QuayLai.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_QuayLai.Location = new Point(458, 426);
            btn_QuayLai.Name = "btn_QuayLai";
            btn_QuayLai.Size = new Size(152, 46);
            btn_QuayLai.TabIndex = 24;
            btn_QuayLai.Text = "Quay Lại";
            btn_QuayLai.UseVisualStyleBackColor = true;
            btn_QuayLai.Click += btn_QuayLai_Click;
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ThanhToan.Location = new Point(142, 426);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(152, 46);
            btn_ThanhToan.TabIndex = 23;
            btn_ThanhToan.Text = "Thanh Toán";
            btn_ThanhToan.UseVisualStyleBackColor = true;
            btn_ThanhToan.Click += btn_ThanhToan_Click;
            // 
            // txt_TriGia
            // 
            txt_TriGia.Location = new Point(579, 141);
            txt_TriGia.Name = "txt_TriGia";
            txt_TriGia.PlaceholderText = ".........................................................";
            txt_TriGia.Size = new Size(237, 31);
            txt_TriGia.TabIndex = 22;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Location = new Point(222, 141);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.PlaceholderText = ".........................................................";
            txt_DiaChi.Size = new Size(237, 31);
            txt_DiaChi.TabIndex = 21;
            // 
            // txt_KhachHang
            // 
            txt_KhachHang.Location = new Point(326, 88);
            txt_KhachHang.Name = "txt_KhachHang";
            txt_KhachHang.PlaceholderText = "...................................................";
            txt_KhachHang.Size = new Size(203, 31);
            txt_KhachHang.TabIndex = 20;
            // 
            // lb_TriGia
            // 
            lb_TriGia.AutoSize = true;
            lb_TriGia.Location = new Point(514, 141);
            lb_TriGia.Name = "lb_TriGia";
            lb_TriGia.Size = new Size(67, 25);
            lb_TriGia.TabIndex = 19;
            lb_TriGia.Text = "Trị giá :";
            // 
            // lb_DiaChi
            // 
            lb_DiaChi.AutoSize = true;
            lb_DiaChi.Location = new Point(142, 141);
            lb_DiaChi.Name = "lb_DiaChi";
            lb_DiaChi.Size = new Size(74, 25);
            lb_DiaChi.TabIndex = 18;
            lb_DiaChi.Text = "Địa chỉ :";
            // 
            // lb_KhachHang
            // 
            lb_KhachHang.AutoSize = true;
            lb_KhachHang.Location = new Point(142, 94);
            lb_KhachHang.Name = "lb_KhachHang";
            lb_KhachHang.Size = new Size(178, 25);
            lb_KhachHang.TabIndex = 17;
            lb_KhachHang.Text = "Khách hàng/Cơ quan";
            // 
            // lv_HoaDonThanhToan
            // 
            lv_HoaDonThanhToan.Columns.AddRange(new ColumnHeader[] { cl_stt, cl_Phong, cl_SoNgayThue, cl_DonGia, cl_ThanhTien });
            lv_HoaDonThanhToan.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lv_HoaDonThanhToan.FullRowSelect = true;
            lv_HoaDonThanhToan.GridLines = true;
            lv_HoaDonThanhToan.Location = new Point(142, 205);
            lv_HoaDonThanhToan.Name = "lv_HoaDonThanhToan";
            lv_HoaDonThanhToan.Size = new Size(694, 199);
            lv_HoaDonThanhToan.TabIndex = 16;
            lv_HoaDonThanhToan.UseCompatibleStateImageBehavior = false;
            lv_HoaDonThanhToan.View = View.Details;
            lv_HoaDonThanhToan.SelectedIndexChanged += lv_HoaDonThanhToan_SelectedIndexChanged;
            // 
            // cl_stt
            // 
            cl_stt.Text = "STT";
            cl_stt.Width = 80;
            // 
            // cl_Phong
            // 
            cl_Phong.Text = "Phòng";
            cl_Phong.TextAlign = HorizontalAlignment.Center;
            cl_Phong.Width = 150;
            // 
            // cl_SoNgayThue
            // 
            cl_SoNgayThue.Text = "Số Ngày Thuê";
            cl_SoNgayThue.TextAlign = HorizontalAlignment.Center;
            cl_SoNgayThue.Width = 160;
            // 
            // cl_DonGia
            // 
            cl_DonGia.Text = "Đơn Giá";
            cl_DonGia.TextAlign = HorizontalAlignment.Center;
            cl_DonGia.Width = 140;
            // 
            // cl_ThanhTien
            // 
            cl_ThanhTien.Text = "Thành Tiền";
            cl_ThanhTien.TextAlign = HorizontalAlignment.Center;
            cl_ThanhTien.Width = 140;
            // 
            // lb_HoaDonThanhToan
            // 
            lb_HoaDonThanhToan.AutoSize = true;
            lb_HoaDonThanhToan.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lb_HoaDonThanhToan.Location = new Point(284, 26);
            lb_HoaDonThanhToan.Name = "lb_HoaDonThanhToan";
            lb_HoaDonThanhToan.Size = new Size(347, 41);
            lb_HoaDonThanhToan.TabIndex = 15;
            lb_HoaDonThanhToan.Text = "HÓA ĐƠN THANH TOÁN";
            // 
            // btn_Tim
            // 
            btn_Tim.Location = new Point(566, 86);
            btn_Tim.Name = "btn_Tim";
            btn_Tim.Size = new Size(112, 34);
            btn_Tim.TabIndex = 25;
            btn_Tim.Text = "Tìm";
            btn_Tim.UseVisualStyleBackColor = true;
            btn_Tim.Click += btn_Tim_Click;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(704, 85);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(112, 34);
            btn_reset.TabIndex = 26;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // Form_HoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 532);
            Controls.Add(btn_reset);
            Controls.Add(btn_Tim);
            Controls.Add(btn_QuayLai);
            Controls.Add(btn_ThanhToan);
            Controls.Add(txt_TriGia);
            Controls.Add(txt_DiaChi);
            Controls.Add(txt_KhachHang);
            Controls.Add(lb_TriGia);
            Controls.Add(lb_DiaChi);
            Controls.Add(lb_KhachHang);
            Controls.Add(lv_HoaDonThanhToan);
            Controls.Add(lb_HoaDonThanhToan);
            Name = "Form_HoaDon";
            Text = "HoaDonThanhToan";
            Load += Form_HoaDon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_QuayLai;
        private Button btn_ThanhToan;
        private TextBox txt_TriGia;
        private TextBox txt_DiaChi;
        private TextBox txt_KhachHang;
        private Label lb_TriGia;
        private Label lb_DiaChi;
        private Label lb_KhachHang;
        private ListView lv_HoaDonThanhToan;
        private ColumnHeader cl_stt;
        private ColumnHeader cl_Phong;
        private ColumnHeader cl_SoNgayThue;
        private ColumnHeader cl_DonGia;
        private ColumnHeader cl_ThanhTien;
        private Label lb_HoaDonThanhToan;
        private Button btn_Tim;
        private Button btn_reset;
    }
}