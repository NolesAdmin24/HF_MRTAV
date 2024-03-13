
namespace ESI_5590_ProjectApp_Group2_SP24
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
            this.webBrowser4 = new System.Windows.Forms.WebBrowser();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.AvoidLeft = new System.Windows.Forms.Button();
            this.AvoidRight = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser4
            // 
            this.webBrowser4.Location = new System.Drawing.Point(0, 57);
            this.webBrowser4.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser4.Name = "webBrowser4";
            this.webBrowser4.Size = new System.Drawing.Size(1106, 365);
            this.webBrowser4.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(606, 22);
            this.textBox1.TabIndex = 5;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(681, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start Sim";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.Start_Click);
            // 
            // AvoidLeft
            // 
            this.AvoidLeft.Location = new System.Drawing.Point(304, 487);
            this.AvoidLeft.Name = "AvoidLeft";
            this.AvoidLeft.Size = new System.Drawing.Size(94, 32);
            this.AvoidLeft.TabIndex = 7;
            this.AvoidLeft.Text = "Avoid Left";
            this.AvoidLeft.UseVisualStyleBackColor = true;
            this.AvoidLeft.Click += new System.EventHandler(this.AvoidLeft_Click);
            // 
            // AvoidRight
            // 
            this.AvoidRight.Location = new System.Drawing.Point(535, 487);
            this.AvoidRight.Name = "AvoidRight";
            this.AvoidRight.Size = new System.Drawing.Size(99, 32);
            this.AvoidRight.TabIndex = 8;
            this.AvoidRight.Text = "Avoid Right";
            this.AvoidRight.UseVisualStyleBackColor = true;
            this.AvoidRight.Click += new System.EventHandler(this.AvoidRight_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Stop.Location = new System.Drawing.Point(776, 487);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(91, 32);
            this.Stop.TabIndex = 9;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1106, 540);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.AvoidRight);
            this.Controls.Add(this.AvoidLeft);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.webBrowser4);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Driving Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button AvoidLeft;
        private System.Windows.Forms.Button AvoidRight;
        private System.Windows.Forms.Button Stop;
    }
}

