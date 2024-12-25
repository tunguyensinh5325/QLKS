namespace QLKSGUI
{
    partial class Form_Main
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
            btn_test = new Button();
            SuspendLayout();
            // 
            // btn_test
            // 
            btn_test.Location = new Point(320, 123);
            btn_test.Name = "btn_test";
            btn_test.Size = new Size(112, 34);
            btn_test.TabIndex = 0;
            btn_test.Text = "Test";
            btn_test.UseVisualStyleBackColor = true;
            btn_test.Click += btn_test_Click;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_test);
            Name = "Form_Main";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_test;
    }
}