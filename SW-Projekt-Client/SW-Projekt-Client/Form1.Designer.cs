namespace SW_Projekt_Client
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
            this.StartBut = new System.Windows.Forms.Button();
            this.IpBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartBut
            // 
            this.StartBut.Location = new System.Drawing.Point(298, 236);
            this.StartBut.Name = "StartBut";
            this.StartBut.Size = new System.Drawing.Size(75, 23);
            this.StartBut.TabIndex = 0;
            this.StartBut.Text = "Start";
            this.StartBut.UseVisualStyleBackColor = true;
            this.StartBut.Click += new System.EventHandler(this.StartBut_Click);
            // 
            // IpBox
            // 
            this.IpBox.Location = new System.Drawing.Point(24, 73);
            this.IpBox.Name = "IpBox";
            this.IpBox.Size = new System.Drawing.Size(100, 22);
            this.IpBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 314);
            this.Controls.Add(this.IpBox);
            this.Controls.Add(this.StartBut);
            this.Name = "Form1";
            this.Text = "WatchDog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBut;
        private System.Windows.Forms.TextBox IpBox;
    }
}

