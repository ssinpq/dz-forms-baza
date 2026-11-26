namespace WinFormsApp2
{
    partial class Form1
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
            txtMyInput = new TextBox();
            txtFileContent = new TextBox();
            btnOk = new Button();
            SuspendLayout();
            // 
            // txtMyInput
            // 
            txtMyInput.Location = new Point(12, 12);
            txtMyInput.Name = "txtMyInput";
            txtMyInput.Size = new Size(240, 23);
            txtMyInput.TabIndex = 0;
            // 
            // txtFileContent
            // 
            txtFileContent.Location = new Point(12, 41);
            txtFileContent.Multiline = true;
            txtFileContent.Name = "txtFileContent";
            txtFileContent.Size = new Size(240, 56);
            txtFileContent.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(12, 103);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(106, 31);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOk);
            Controls.Add(txtFileContent);
            Controls.Add(txtMyInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMyInput;
        private TextBox txtFileContent;
        private Button btnOk;
    }
}
