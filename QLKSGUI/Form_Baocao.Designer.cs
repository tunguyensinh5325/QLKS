namespace QLKSGUI
{
    partial class Form_Baocao
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
            lb_MatDo = new Label();
            lb_thangmd = new Label();
            cbbox_thangmd = new ComboBox();
            lv_DSMD = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            lv_DSLP = new ListView();
            STT = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            cbbox_thanglp = new ComboBox();
            lb_thanglp = new Label();
            lb_Doannthu = new Label();
            btn_Locmd = new Button();
            cbb_nammd = new ComboBox();
            cbb_namlp = new ComboBox();
            lb_nammd = new Label();
            lb_namlp = new Label();
            btn_Loclp = new Button();
            SuspendLayout();
            // 
            // lb_MatDo
            // 
            lb_MatDo.BackColor = SystemColors.ActiveCaption;
            lb_MatDo.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lb_MatDo.Location = new Point(37, 9);
            lb_MatDo.Margin = new Padding(5, 0, 5, 0);
            lb_MatDo.Name = "lb_MatDo";
            lb_MatDo.Size = new Size(679, 38);
            lb_MatDo.TabIndex = 0;
            lb_MatDo.Text = "Báo Cáo Mật Độ Sử Dụng Phòng ";
            lb_MatDo.TextAlign = ContentAlignment.TopCenter;
            // 
            // lb_thangmd
            // 
            lb_thangmd.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lb_thangmd.Location = new Point(36, 69);
            lb_thangmd.Margin = new Padding(5, 0, 5, 0);
            lb_thangmd.Name = "lb_thangmd";
            lb_thangmd.Size = new Size(132, 38);
            lb_thangmd.TabIndex = 1;
            lb_thangmd.Text = "Tháng :";
            lb_thangmd.TextAlign = ContentAlignment.TopCenter;
            // 
            // cbbox_thangmd
            // 
            cbbox_thangmd.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbox_thangmd.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_thangmd.FormattingEnabled = true;
            cbbox_thangmd.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbbox_thangmd.Location = new Point(158, 69);
            cbbox_thangmd.Margin = new Padding(5);
            cbbox_thangmd.Name = "cbbox_thangmd";
            cbbox_thangmd.Size = new Size(154, 41);
            cbbox_thangmd.TabIndex = 2;
            // 
            // lv_DSMD
            // 
            lv_DSMD.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lv_DSMD.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lv_DSMD.GridLines = true;
            lv_DSMD.Location = new Point(51, 112);
            lv_DSMD.Margin = new Padding(5);
            lv_DSMD.Name = "lv_DSMD";
            lv_DSMD.Size = new Size(654, 253);
            lv_DSMD.TabIndex = 3;
            lv_DSMD.UseCompatibleStateImageBehavior = false;
            lv_DSMD.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Phòng";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Số Ngày Thuê";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tỉ Lệ";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 200;
            // 
            // lv_DSLP
            // 
            lv_DSLP.Columns.AddRange(new ColumnHeader[] { STT, columnHeader5, columnHeader6, columnHeader7 });
            lv_DSLP.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lv_DSLP.GridLines = true;
            lv_DSLP.Location = new Point(935, 117);
            lv_DSLP.Margin = new Padding(5);
            lv_DSLP.Name = "lv_DSLP";
            lv_DSLP.Size = new Size(525, 253);
            lv_DSLP.TabIndex = 7;
            lv_DSLP.UseCompatibleStateImageBehavior = false;
            lv_DSLP.View = View.Details;
            // 
            // STT
            // 
            STT.Text = "STT";
            STT.Width = 70;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Loại Phòng";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Doanh Thu";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Tỉ Lệ";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 100;
            // 
            // cbbox_thanglp
            // 
            cbbox_thanglp.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbox_thanglp.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_thanglp.FormattingEnabled = true;
            cbbox_thanglp.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbbox_thanglp.Location = new Point(953, 67);
            cbbox_thanglp.Margin = new Padding(5);
            cbbox_thanglp.Name = "cbbox_thanglp";
            cbbox_thanglp.Size = new Size(150, 41);
            cbbox_thanglp.TabIndex = 6;
            // 
            // lb_thanglp
            // 
            lb_thanglp.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lb_thanglp.Location = new Point(828, 70);
            lb_thanglp.Margin = new Padding(5, 0, 5, 0);
            lb_thanglp.Name = "lb_thanglp";
            lb_thanglp.Size = new Size(115, 38);
            lb_thanglp.TabIndex = 5;
            lb_thanglp.Text = "Tháng :";
            lb_thanglp.TextAlign = ContentAlignment.TopCenter;
            // 
            // lb_Doannthu
            // 
            lb_Doannthu.BackColor = SystemColors.ActiveCaption;
            lb_Doannthu.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Doannthu.Location = new Point(822, 9);
            lb_Doannthu.Margin = new Padding(5, 0, 5, 0);
            lb_Doannthu.Name = "lb_Doannthu";
            lb_Doannthu.Size = new Size(708, 38);
            lb_Doannthu.TabIndex = 4;
            lb_Doannthu.Text = "Báo Cáo Doanh Thu Theo Loại Phòng";
            lb_Doannthu.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_Locmd
            // 
            btn_Locmd.Location = new Point(547, 378);
            btn_Locmd.Margin = new Padding(4, 3, 4, 3);
            btn_Locmd.Name = "btn_Locmd";
            btn_Locmd.Size = new Size(134, 34);
            btn_Locmd.TabIndex = 8;
            btn_Locmd.Text = "Lọc";
            btn_Locmd.UseVisualStyleBackColor = true;
            btn_Locmd.Click += btn_Locmd_Click;
            // 
            // cbb_nammd
            // 
            cbb_nammd.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_nammd.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_nammd.FormattingEnabled = true;
            cbb_nammd.Location = new Point(479, 69);
            cbb_nammd.Margin = new Padding(5);
            cbb_nammd.Name = "cbb_nammd";
            cbb_nammd.Size = new Size(150, 41);
            cbb_nammd.TabIndex = 10;
            // 
            // cbb_namlp
            // 
            cbb_namlp.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_namlp.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_namlp.FormattingEnabled = true;
            cbb_namlp.Location = new Point(1310, 66);
            cbb_namlp.Margin = new Padding(5);
            cbb_namlp.Name = "cbb_namlp";
            cbb_namlp.Size = new Size(150, 41);
            cbb_namlp.TabIndex = 11;
            // 
            // lb_nammd
            // 
            lb_nammd.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lb_nammd.Location = new Point(354, 71);
            lb_nammd.Margin = new Padding(5, 0, 5, 0);
            lb_nammd.Name = "lb_nammd";
            lb_nammd.Size = new Size(115, 38);
            lb_nammd.TabIndex = 12;
            lb_nammd.Text = "Năm :";
            lb_nammd.TextAlign = ContentAlignment.TopCenter;
            // 
            // lb_namlp
            // 
            lb_namlp.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lb_namlp.Location = new Point(1185, 66);
            lb_namlp.Margin = new Padding(5, 0, 5, 0);
            lb_namlp.Name = "lb_namlp";
            lb_namlp.Size = new Size(115, 38);
            lb_namlp.TabIndex = 13;
            lb_namlp.Text = "Năm :";
            lb_namlp.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_Loclp
            // 
            btn_Loclp.Location = new Point(1326, 381);
            btn_Loclp.Margin = new Padding(4, 3, 4, 3);
            btn_Loclp.Name = "btn_Loclp";
            btn_Loclp.Size = new Size(134, 34);
            btn_Loclp.TabIndex = 14;
            btn_Loclp.Text = "Lọc";
            btn_Loclp.UseVisualStyleBackColor = true;
            btn_Loclp.Click += btn_Loclp_Click;
            // 
            // Form_Baocao
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1572, 425);
            Controls.Add(btn_Loclp);
            Controls.Add(lb_namlp);
            Controls.Add(lb_nammd);
            Controls.Add(cbb_namlp);
            Controls.Add(cbb_nammd);
            Controls.Add(btn_Locmd);
            Controls.Add(lv_DSLP);
            Controls.Add(cbbox_thanglp);
            Controls.Add(lb_thanglp);
            Controls.Add(lb_Doannthu);
            Controls.Add(lv_DSMD);
            Controls.Add(cbbox_thangmd);
            Controls.Add(lb_thangmd);
            Controls.Add(lb_MatDo);
            Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form_Baocao";
            Text = "Form1";
            Load += Form_Baocaomatdo_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lb_MatDo;
        private Label lb_thangmd;
        private ComboBox cbbox_thangmd;
        private ListView lv_DSMD;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView lv_DSLP;
        private ColumnHeader STT;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ComboBox cbbox_thanglp;
        private Label lb_thanglp;
        private Label lb_Doannthu;
        private Button btn_Locmd;
        private ComboBox cbb_nammd;
        private ComboBox cbb_namlp;
        private Label lb_nammd;
        private Label lb_namlp;
        private Button btn_Loclp;
    }
}
