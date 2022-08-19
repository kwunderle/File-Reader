
namespace FileReader___Katharine_Wunderle
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
            this.filePathInpt = new System.Windows.Forms.TextBox();
            this.readFileBtn = new System.Windows.Forms.Button();
            this.inputBx = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filePathInpt
            // 
            this.filePathInpt.Location = new System.Drawing.Point(36, 51);
            this.filePathInpt.Name = "filePathInpt";
            this.filePathInpt.Size = new System.Drawing.Size(286, 20);
            this.filePathInpt.TabIndex = 0;
            // 
            // readFileBtn
            // 
            this.readFileBtn.AutoSize = true;
            this.readFileBtn.Location = new System.Drawing.Point(337, 49);
            this.readFileBtn.Name = "readFileBtn";
            this.readFileBtn.Size = new System.Drawing.Size(80, 23);
            this.readFileBtn.TabIndex = 1;
            this.readFileBtn.Text = "Read the File";
            this.readFileBtn.UseVisualStyleBackColor = true;
            this.readFileBtn.Click += new System.EventHandler(this.readFileBtn_Click);
            // 
            // inputBx
            // 
            this.inputBx.FormattingEnabled = true;
            this.inputBx.Location = new System.Drawing.Point(36, 97);
            this.inputBx.Name = "inputBx";
            this.inputBx.Size = new System.Drawing.Size(381, 225);
            this.inputBx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the name of the file you wish to read.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputBx);
            this.Controls.Add(this.readFileBtn);
            this.Controls.Add(this.filePathInpt);
            this.Name = "Form1";
            this.Text = "File Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePathInpt;
        private System.Windows.Forms.Button readFileBtn;
        private System.Windows.Forms.ListBox inputBx;
        private System.Windows.Forms.Label label1;
    }
}

