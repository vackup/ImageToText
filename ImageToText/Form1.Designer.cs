namespace ImageToText
{
    partial class Form1
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
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.txtImageText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImageToText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(76, 12);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(503, 20);
            this.txtImagePath.TabIndex = 0;
            // 
            // txtImageText
            // 
            this.txtImageText.Location = new System.Drawing.Point(12, 38);
            this.txtImageText.Multiline = true;
            this.txtImageText.Name = "txtImageText";
            this.txtImageText.Size = new System.Drawing.Size(1217, 500);
            this.txtImageText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image Path";
            // 
            // btnImageToText
            // 
            this.btnImageToText.Location = new System.Drawing.Point(586, 8);
            this.btnImageToText.Name = "btnImageToText";
            this.btnImageToText.Size = new System.Drawing.Size(100, 23);
            this.btnImageToText.TabIndex = 3;
            this.btnImageToText.Text = "Image To Text";
            this.btnImageToText.UseVisualStyleBackColor = true;
            this.btnImageToText.Click += new System.EventHandler(this.btnImageToText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 550);
            this.Controls.Add(this.btnImageToText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImageText);
            this.Controls.Add(this.txtImagePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.TextBox txtImageText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImageToText;
    }
}

