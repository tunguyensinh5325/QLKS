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
            ((System.ComponentModel.ISupportInitialize)dtgv_dsphong).BeginInit();
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
            // btn_TimPhong
            // 
            btn_TimPhong.Location = new Point(130, 114);
            btn_TimPhong.Name = "btn_TimPhong";
            btn_TimPhong.Size = new Size(112, 33);
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
            cbbox_Phong.Location = new Point(248, 114);
            cbbox_Phong.Name = "cbbox_Phong";
            cbbox_Phong.Size = new Size(182, 33);
            cbbox_Phong.TabIndex = 3;
            // 
            // dtgv_dsphong
            // 
            dtgv_dsphong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_dsphong.Location = new Point(70, 183);
            dtgv_dsphong.Name = "dtgv_dsphong";
            dtgv_dsphong.RowHeadersWidth = 62;
            dtgv_dsphong.RowTemplate.Height = 33;
            dtgv_dsphong.Size = new Size(808, 280);
            dtgv_dsphong.TabIndex = 4;
            dtgv_dsphong.RowPostPaint += dtgv_dsphong_RowPostPaint;
            // 
            // btn_QuayLai
            // 
            btn_QuayLai.Location = new Point(487, 112);
            btn_QuayLai.Name = "btn_QuayLai";
            btn_QuayLai.Size = new Size(112, 34);
            btn_QuayLai.TabIndex = 5;
            btn_QuayLai.Text = "Quay Lại";
            btn_QuayLai.UseVisualStyleBackColor = true;
            btn_QuayLai.Click += btn_QuayLai_Click;
            // 
            // Form_DSPhong
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 533);
            Controls.Add(btn_QuayLai);
            Controls.Add(dtgv_dsphong);
            Controls.Add(cbbox_Phong);
            Controls.Add(btn_TimPhong);
            Controls.Add(lb_DanhSachPhong);
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
    }
}
