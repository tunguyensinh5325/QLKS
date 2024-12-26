namespace Form_BaoCaoMatDo
{
    partial class Form_Baocaomatdo
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
            lb_thang = new Label();
            cbbox_thang = new ComboBox();
            lv_DS = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // lb_MatDo
            // 
            lb_MatDo.BackColor = SystemColors.ActiveCaption;
            lb_MatDo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_MatDo.Location = new Point(163, 15);
            lb_MatDo.Margin = new Padding(4, 0, 4, 0);
            lb_MatDo.Name = "lb_MatDo";
            lb_MatDo.Size = new Size(566, 38);
            lb_MatDo.TabIndex = 0;
            lb_MatDo.Text = "Báo Cáo Mật Độ Sử Dụng Phòng ";
            lb_MatDo.TextAlign = ContentAlignment.TopCenter;
            // 
            // lb_thang
            // 
            lb_thang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_thang.Location = new Point(256, 72);
            lb_thang.Margin = new Padding(4, 0, 4, 0);
            lb_thang.Name = "lb_thang";
            lb_thang.Size = new Size(143, 38);
            lb_thang.TabIndex = 1;
            lb_thang.Text = "Tháng :";
            lb_thang.TextAlign = ContentAlignment.TopCenter;
            // 
            // cbbox_thang
            // 
            cbbox_thang.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbbox_thang.FormattingEnabled = true;
            cbbox_thang.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbbox_thang.Location = new Point(381, 68);
            cbbox_thang.Margin = new Padding(4, 5, 4, 5);
            cbbox_thang.Name = "cbbox_thang";
            cbbox_thang.Size = new Size(171, 39);
            cbbox_thang.TabIndex = 2;
            // 
            // lv_DS
            // 
            lv_DS.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lv_DS.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lv_DS.GridLines = true;
            lv_DS.Location = new Point(3, 162);
            lv_DS.Margin = new Padding(4, 5, 4, 5);
            lv_DS.Name = "lv_DS";
            lv_DS.Size = new Size(885, 547);
            lv_DS.TabIndex = 3;
            lv_DS.UseCompatibleStateImageBehavior = false;
            lv_DS.View = View.Details;
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
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Số Ngày Thuê";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tỉ Lệ";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 200;
            // 
            // Form_Baocaomatdo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 717);
            Controls.Add(lv_DS);
            Controls.Add(cbbox_thang);
            Controls.Add(lb_thang);
            Controls.Add(lb_MatDo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form_Baocaomatdo";
            Text = "Form1";
            Load += Form_Baocaomatdo_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lb_MatDo;
        private Label lb_thang;
        private ComboBox cbbox_thang;
        private ListView lv_DS;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
