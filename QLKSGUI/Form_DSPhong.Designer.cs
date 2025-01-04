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
            btn_QuayLai = new Button();
            btn_Baocao = new Button();
            btn_Datphong = new Button();
            btn_Thanhtoan = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgv_dsphong).BeginInit();
            SuspendLayout();
            // 
            // lb_DanhSachPhong
            // 
            lb_DanhSachPhong.AutoSize = true;
            lb_DanhSachPhong.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lb_DanhSachPhong.Location = new Point(363, 9);
            lb_DanhSachPhong.Margin = new Padding(4, 0, 4, 0);
            lb_DanhSachPhong.Name = "lb_DanhSachPhong";
            lb_DanhSachPhong.Size = new Size(260, 36);
            lb_DanhSachPhong.TabIndex = 0;
            lb_DanhSachPhong.Text = "Danh Sách Phòng";
            // 
            // btn_TimPhong
            // 
            btn_TimPhong.Location = new Point(84, 114);
            btn_TimPhong.Margin = new Padding(4, 2, 4, 2);
            btn_TimPhong.Name = "btn_TimPhong";
            btn_TimPhong.Size = new Size(134, 36);
            btn_TimPhong.TabIndex = 2;
            btn_TimPhong.Text = "Tìm Phòng";
            btn_TimPhong.UseVisualStyleBackColor = true;
            btn_TimPhong.Click += btn_TimPhong_Click;
            // 
            // cbbox_Phong
            // 
            cbbox_Phong.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbox_Phong.FormattingEnabled = true;
            cbbox_Phong.Items.AddRange(new object[] { "Tất cả", "Đơn", "Đôi", "Lớn" });
            cbbox_Phong.Location = new Point(226, 115);
            cbbox_Phong.Margin = new Padding(4, 2, 4, 2);
            cbbox_Phong.Name = "cbbox_Phong";
            cbbox_Phong.Size = new Size(218, 33);
            cbbox_Phong.TabIndex = 3;
            // 
            // dtgv_dsphong
            // 
            dtgv_dsphong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_dsphong.Location = new Point(84, 182);
            dtgv_dsphong.Margin = new Padding(4, 2, 4, 2);
            dtgv_dsphong.Name = "dtgv_dsphong";
            dtgv_dsphong.RowHeadersWidth = 62;
            dtgv_dsphong.RowTemplate.Height = 33;
            dtgv_dsphong.Size = new Size(813, 280);
            dtgv_dsphong.TabIndex = 4;
            dtgv_dsphong.RowPostPaint += dtgv_dsphong_RowPostPaint;
            // 
            // btn_QuayLai
            // 
            btn_QuayLai.Location = new Point(763, 478);
            btn_QuayLai.Margin = new Padding(4, 2, 4, 2);
            btn_QuayLai.Name = "btn_QuayLai";
            btn_QuayLai.Size = new Size(134, 34);
            btn_QuayLai.TabIndex = 5;
            btn_QuayLai.Text = "Quay Lại";
            btn_QuayLai.UseVisualStyleBackColor = true;
            btn_QuayLai.Click += btn_QuayLai_Click;
            // 
            // btn_Baocao
            // 
            btn_Baocao.Location = new Point(537, 478);
            btn_Baocao.Margin = new Padding(4, 2, 4, 2);
            btn_Baocao.Name = "btn_Baocao";
            btn_Baocao.Size = new Size(134, 34);
            btn_Baocao.TabIndex = 6;
            btn_Baocao.Text = "Báo cáo";
            btn_Baocao.UseVisualStyleBackColor = true;
            btn_Baocao.Click += btn_Baocao_Click;
            // 
            // btn_Datphong
            // 
            btn_Datphong.Location = new Point(84, 478);
            btn_Datphong.Margin = new Padding(4, 2, 4, 2);
            btn_Datphong.Name = "btn_Datphong";
            btn_Datphong.Size = new Size(134, 34);
            btn_Datphong.TabIndex = 7;
            btn_Datphong.Text = "Đặt Phòng";
            btn_Datphong.UseVisualStyleBackColor = true;
            btn_Datphong.Click += btn_Datphong_Click;
            // 
            // btn_Thanhtoan
            // 
            btn_Thanhtoan.Location = new Point(310, 478);
            btn_Thanhtoan.Margin = new Padding(4, 2, 4, 2);
            btn_Thanhtoan.Name = "btn_Thanhtoan";
            btn_Thanhtoan.Size = new Size(134, 34);
            btn_Thanhtoan.TabIndex = 8;
            btn_Thanhtoan.Text = "Thanh toán";
            btn_Thanhtoan.UseVisualStyleBackColor = true;
            btn_Thanhtoan.Click += btn_Thanhtoan_Click;
            // 
            // Form_DSPhong
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 532);
            Controls.Add(btn_Thanhtoan);
            Controls.Add(btn_Datphong);
            Controls.Add(btn_Baocao);
            Controls.Add(btn_QuayLai);
            Controls.Add(dtgv_dsphong);
            Controls.Add(cbbox_Phong);
            Controls.Add(btn_TimPhong);
            Controls.Add(lb_DanhSachPhong);
            Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form_DSPhong";
            Text = "Danh Sách Phòng";
            Load += Form_DSPhong_Load_1;
            ((System.ComponentModel.ISupportInitialize)dtgv_dsphong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_DanhSachPhong;
        private Button btn_TimPhong;
        private ComboBox cbbox_Phong;
        private DataGridView dtgv_dsphong;
        private Button btn_QuayLai;
        private Button btn_Baocao;
        private Button btn_Datphong;
        private Button btn_Thanhtoan;
    }
}
