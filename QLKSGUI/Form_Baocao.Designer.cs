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
            tableLayoutPanel2 = new TableLayoutPanel();
            tblp_TieuDe2 = new TableLayoutPanel();
            label1 = new Label();
            tblp_btn2 = new TableLayoutPanel();
            button1 = new Button();
            tblp_thangnam2 = new TableLayoutPanel();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            tblp_lv2 = new TableLayoutPanel();
            listView1 = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            tableLayoutPanel1 = new TableLayoutPanel();
            tblp_TieuDe1 = new TableLayoutPanel();
            label4 = new Label();
            tblp_thangnam1 = new TableLayoutPanel();
            label5 = new Label();
            comboBox3 = new ComboBox();
            label6 = new Label();
            comboBox4 = new ComboBox();
            tblp_lv1 = new TableLayoutPanel();
            listView2 = new ListView();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            tblp_btn1 = new TableLayoutPanel();
            button2 = new Button();
            tblp_BaoCao = new TableLayoutPanel();
            tableLayoutPanel2.SuspendLayout();
            tblp_TieuDe2.SuspendLayout();
            tblp_btn2.SuspendLayout();
            tblp_thangnam2.SuspendLayout();
            tblp_lv2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tblp_TieuDe1.SuspendLayout();
            tblp_thangnam1.SuspendLayout();
            tblp_lv1.SuspendLayout();
            tblp_btn1.SuspendLayout();
            tblp_BaoCao.SuspendLayout();
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
            btn_Locmd.Text = "Lọc 12";
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tblp_TieuDe2, 0, 0);
            tableLayoutPanel2.Controls.Add(tblp_btn2, 0, 3);
            tableLayoutPanel2.Controls.Add(tblp_thangnam2, 0, 1);
            tableLayoutPanel2.Controls.Add(tblp_lv2, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(789, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.47F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 57.37F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.16F));
            tableLayoutPanel2.Size = new Size(780, 419);
            tableLayoutPanel2.TabIndex = 24;
            // 
            // tblp_TieuDe2
            // 
            tblp_TieuDe2.ColumnCount = 1;
            tblp_TieuDe2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblp_TieuDe2.Controls.Add(label1, 0, 0);
            tblp_TieuDe2.Dock = DockStyle.Top;
            tblp_TieuDe2.Location = new Point(3, 3);
            tblp_TieuDe2.Name = "tblp_TieuDe2";
            tblp_TieuDe2.RowCount = 1;
            tblp_TieuDe2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblp_TieuDe2.Size = new Size(774, 51);
            tblp_TieuDe2.TabIndex = 20;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 0);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(764, 51);
            label1.TabIndex = 4;
            label1.Text = "Báo Cáo Doanh Thu Theo Loại Phòng";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tblp_btn2
            // 
            tblp_btn2.ColumnCount = 1;
            tblp_btn2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblp_btn2.Controls.Add(button1, 0, 0);
            tblp_btn2.Dock = DockStyle.Right;
            tblp_btn2.Location = new Point(649, 365);
            tblp_btn2.Name = "tblp_btn2";
            tblp_btn2.RowCount = 1;
            tblp_btn2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblp_btn2.Size = new Size(128, 51);
            tblp_btn2.TabIndex = 23;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(4, 3);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(120, 45);
            button1.TabIndex = 14;
            button1.Text = "Lọc";
            button1.UseVisualStyleBackColor = true;
            // 
            // tblp_thangnam2
            // 
            tblp_thangnam2.ColumnCount = 4;
            tblp_thangnam2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblp_thangnam2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblp_thangnam2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblp_thangnam2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblp_thangnam2.Controls.Add(label2, 0, 0);
            tblp_thangnam2.Controls.Add(comboBox1, 1, 0);
            tblp_thangnam2.Controls.Add(label3, 2, 0);
            tblp_thangnam2.Controls.Add(comboBox2, 3, 0);
            tblp_thangnam2.Dock = DockStyle.Fill;
            tblp_thangnam2.Location = new Point(3, 65);
            tblp_thangnam2.Name = "tblp_thangnam2";
            tblp_thangnam2.RowCount = 1;
            tblp_thangnam2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblp_thangnam2.Size = new Size(774, 54);
            tblp_thangnam2.TabIndex = 21;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 0);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 54);
            label2.TabIndex = 5;
            label2.Text = "Tháng :";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Left;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox1.Location = new Point(198, 5);
            comboBox1.Margin = new Padding(5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 41);
            comboBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Right;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(459, 0);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 54);
            label3.TabIndex = 13;
            label3.Text = "Năm :";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Left;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(584, 5);
            comboBox2.Margin = new Padding(5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(150, 41);
            comboBox2.TabIndex = 11;
            // 
            // tblp_lv2
            // 
            tblp_lv2.ColumnCount = 1;
            tblp_lv2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblp_lv2.Controls.Add(listView1, 0, 0);
            tblp_lv2.Dock = DockStyle.Fill;
            tblp_lv2.Location = new Point(3, 125);
            tblp_lv2.Name = "tblp_lv2";
            tblp_lv2.RowCount = 1;
            tblp_lv2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblp_lv2.Size = new Size(774, 234);
            tblp_lv2.TabIndex = 22;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listView1.Dock = DockStyle.Fill;
            listView1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.GridLines = true;
            listView1.Location = new Point(5, 5);
            listView1.Margin = new Padding(5);
            listView1.Name = "listView1";
            listView1.Size = new Size(764, 224);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "STT";
            columnHeader8.Width = 70;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Loại Phòng";
            columnHeader9.TextAlign = HorizontalAlignment.Center;
            columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Doanh Thu";
            columnHeader10.TextAlign = HorizontalAlignment.Center;
            columnHeader10.Width = 200;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Tỉ Lệ";
            columnHeader11.TextAlign = HorizontalAlignment.Center;
            columnHeader11.Width = 200;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tblp_TieuDe1, 0, 0);
            tableLayoutPanel1.Controls.Add(tblp_thangnam1, 0, 1);
            tableLayoutPanel1.Controls.Add(tblp_lv1, 0, 2);
            tableLayoutPanel1.Controls.Add(tblp_btn1, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.4736843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 57.36842F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.1578951F));
            tableLayoutPanel1.Size = new Size(780, 419);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // tblp_TieuDe1
            // 
            tblp_TieuDe1.ColumnCount = 1;
            tblp_TieuDe1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblp_TieuDe1.Controls.Add(label4, 0, 0);
            tblp_TieuDe1.Dock = DockStyle.Top;
            tblp_TieuDe1.Location = new Point(3, 3);
            tblp_TieuDe1.Name = "tblp_TieuDe1";
            tblp_TieuDe1.RowCount = 1;
            tblp_TieuDe1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblp_TieuDe1.Size = new Size(774, 51);
            tblp_TieuDe1.TabIndex = 15;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(5, 0);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(764, 51);
            label4.TabIndex = 0;
            label4.Text = "Báo Cáo Mật Độ Sử Dụng Phòng ";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // tblp_thangnam1
            // 
            tblp_thangnam1.ColumnCount = 4;
            tblp_thangnam1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblp_thangnam1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblp_thangnam1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblp_thangnam1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblp_thangnam1.Controls.Add(label5, 0, 0);
            tblp_thangnam1.Controls.Add(comboBox3, 1, 0);
            tblp_thangnam1.Controls.Add(label6, 2, 0);
            tblp_thangnam1.Controls.Add(comboBox4, 3, 0);
            tblp_thangnam1.Dock = DockStyle.Fill;
            tblp_thangnam1.Location = new Point(3, 65);
            tblp_thangnam1.Name = "tblp_thangnam1";
            tblp_thangnam1.RowCount = 1;
            tblp_thangnam1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblp_thangnam1.Size = new Size(774, 54);
            tblp_thangnam1.TabIndex = 16;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Right;
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(56, 0);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(132, 54);
            label5.TabIndex = 1;
            label5.Text = "Tháng :";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBox3
            // 
            comboBox3.Dock = DockStyle.Left;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox3.Location = new Point(198, 5);
            comboBox3.Margin = new Padding(5);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(149, 41);
            comboBox3.TabIndex = 2;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Right;
            label6.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(459, 0);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(115, 54);
            label6.TabIndex = 12;
            label6.Text = "Năm :";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBox4
            // 
            comboBox4.Dock = DockStyle.Left;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(584, 5);
            comboBox4.Margin = new Padding(5);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(150, 41);
            comboBox4.TabIndex = 10;
            // 
            // tblp_lv1
            // 
            tblp_lv1.ColumnCount = 1;
            tblp_lv1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblp_lv1.Controls.Add(listView2, 0, 0);
            tblp_lv1.Dock = DockStyle.Fill;
            tblp_lv1.Location = new Point(3, 125);
            tblp_lv1.Name = "tblp_lv1";
            tblp_lv1.RowCount = 1;
            tblp_lv1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblp_lv1.Size = new Size(774, 234);
            tblp_lv1.TabIndex = 17;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader12, columnHeader13, columnHeader14, columnHeader15 });
            listView2.Dock = DockStyle.Fill;
            listView2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listView2.GridLines = true;
            listView2.Location = new Point(5, 5);
            listView2.Margin = new Padding(5);
            listView2.Name = "listView2";
            listView2.Size = new Size(764, 224);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "STT";
            columnHeader12.Width = 70;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Phòng";
            columnHeader13.TextAlign = HorizontalAlignment.Center;
            columnHeader13.Width = 150;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Số Ngày Thuê";
            columnHeader14.TextAlign = HorizontalAlignment.Center;
            columnHeader14.Width = 200;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Tỉ Lệ";
            columnHeader15.TextAlign = HorizontalAlignment.Center;
            columnHeader15.Width = 200;
            // 
            // tblp_btn1
            // 
            tblp_btn1.ColumnCount = 1;
            tblp_btn1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblp_btn1.Controls.Add(button2, 0, 0);
            tblp_btn1.Dock = DockStyle.Right;
            tblp_btn1.Location = new Point(627, 365);
            tblp_btn1.Name = "tblp_btn1";
            tblp_btn1.RowCount = 1;
            tblp_btn1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblp_btn1.Size = new Size(150, 51);
            tblp_btn1.TabIndex = 18;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(4, 3);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(142, 45);
            button2.TabIndex = 8;
            button2.Text = "Lọc";
            button2.UseVisualStyleBackColor = true;
            // 
            // tblp_BaoCao
            // 
            tblp_BaoCao.ColumnCount = 2;
            tblp_BaoCao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblp_BaoCao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblp_BaoCao.Controls.Add(tableLayoutPanel1, 0, 0);
            tblp_BaoCao.Controls.Add(tableLayoutPanel2, 1, 0);
            tblp_BaoCao.Dock = DockStyle.Fill;
            tblp_BaoCao.Location = new Point(0, 0);
            tblp_BaoCao.Name = "tblp_BaoCao";
            tblp_BaoCao.RowCount = 1;
            tblp_BaoCao.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblp_BaoCao.Size = new Size(1572, 425);
            tblp_BaoCao.TabIndex = 26;
            // 
            // Form_Baocao
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1572, 425);
            Controls.Add(tblp_BaoCao);
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
            tableLayoutPanel2.ResumeLayout(false);
            tblp_TieuDe2.ResumeLayout(false);
            tblp_btn2.ResumeLayout(false);
            tblp_thangnam2.ResumeLayout(false);
            tblp_lv2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tblp_TieuDe1.ResumeLayout(false);
            tblp_thangnam1.ResumeLayout(false);
            tblp_lv1.ResumeLayout(false);
            tblp_btn1.ResumeLayout(false);
            tblp_BaoCao.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tblp_TieuDe2;
        private Label label1;
        private TableLayoutPanel tblp_btn2;
        private Button button1;
        private TableLayoutPanel tblp_thangnam2;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox2;
        private TableLayoutPanel tblp_lv2;
        private ListView listView1;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tblp_TieuDe1;
        private Label label4;
        private TableLayoutPanel tblp_thangnam1;
        private Label label5;
        private ComboBox comboBox3;
        private Label label6;
        private ComboBox comboBox4;
        private TableLayoutPanel tblp_lv1;
        private ListView listView2;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private TableLayoutPanel tblp_btn1;
        private Button button2;
        private TableLayoutPanel tblp_BaoCao;
    }
}
