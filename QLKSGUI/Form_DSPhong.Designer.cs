namespace Form_DSPhong_HoaDon
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
            listView1 = new ListView();
            cl_STT = new ColumnHeader();
            cl_Phong = new ColumnHeader();
            cl_LoaiPhong = new ColumnHeader();
            cl_DonGia = new ColumnHeader();
            cl_TinhTrang = new ColumnHeader();
            btn_TimPhong = new Button();
            cbbox_Phong = new ComboBox();
            SuspendLayout();
            // 
            // lb_DanhSachPhong
            // 
            lb_DanhSachPhong.AutoSize = true;
            lb_DanhSachPhong.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lb_DanhSachPhong.Location = new Point(329, 30);
            lb_DanhSachPhong.Name = "lb_DanhSachPhong";
            lb_DanhSachPhong.Size = new Size(253, 41);
            lb_DanhSachPhong.TabIndex = 0;
            lb_DanhSachPhong.Text = "Danh Sách Phòng";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { cl_STT, cl_Phong, cl_LoaiPhong, cl_DonGia, cl_TinhTrang });
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(130, 175);
            listView1.Name = "listView1";
            listView1.Size = new Size(674, 258);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // cl_STT
            // 
            cl_STT.Text = "STT";
            cl_STT.Width = 80;
            // 
            // cl_Phong
            // 
            cl_Phong.Text = "Phòng";
            cl_Phong.TextAlign = HorizontalAlignment.Center;
            cl_Phong.Width = 150;
            // 
            // cl_LoaiPhong
            // 
            cl_LoaiPhong.Text = "Loại Phòng";
            cl_LoaiPhong.TextAlign = HorizontalAlignment.Center;
            cl_LoaiPhong.Width = 160;
            // 
            // cl_DonGia
            // 
            cl_DonGia.Text = "Đơn Giá";
            cl_DonGia.TextAlign = HorizontalAlignment.Center;
            cl_DonGia.Width = 140;
            // 
            // cl_TinhTrang
            // 
            cl_TinhTrang.Text = "Tình Trạng";
            cl_TinhTrang.TextAlign = HorizontalAlignment.Center;
            cl_TinhTrang.Width = 140;
            // 
            // btn_TimPhong
            // 
            btn_TimPhong.Location = new Point(130, 114);
            btn_TimPhong.Name = "btn_TimPhong";
            btn_TimPhong.Size = new Size(112, 33);
            btn_TimPhong.TabIndex = 2;
            btn_TimPhong.Text = "Tìm Phòng";
            btn_TimPhong.UseVisualStyleBackColor = true;
            // 
            // cbbox_Phong
            // 
            cbbox_Phong.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbox_Phong.FormattingEnabled = true;
            cbbox_Phong.Items.AddRange(new object[] { "Tất cả", "Đơn", "Đôi", "Lớn" });
            cbbox_Phong.Location = new Point(248, 114);
            cbbox_Phong.Name = "cbbox_Phong";
            cbbox_Phong.Size = new Size(182, 33);
            cbbox_Phong.TabIndex = 3;
            // 
            // Form_DanhSachPhong
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 533);
            Controls.Add(cbbox_Phong);
            Controls.Add(btn_TimPhong);
            Controls.Add(listView1);
            Controls.Add(lb_DanhSachPhong);
            Name = "Form_DanhSachPhong";
            Text = "Danh Sách Phòng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_DanhSachPhong;
        private ListView listView1;
        private ColumnHeader cl_STT;
        private ColumnHeader cl_Phong;
        private ColumnHeader cl_LoaiPhong;
        private ColumnHeader cl_DonGia;
        private ColumnHeader cl_TinhTrang;
        private Button btn_TimPhong;
        private ComboBox cbbox_Phong;
    }
}
