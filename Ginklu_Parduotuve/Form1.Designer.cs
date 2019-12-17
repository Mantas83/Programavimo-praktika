namespace Ginklu_Parduotuve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listGunsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gotokrepselis = new System.Windows.Forms.Button();
            this.addtobasket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 92);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // listGunsListBox
            // 
            this.listGunsListBox.FormattingEnabled = true;
            this.listGunsListBox.Location = new System.Drawing.Point(132, 158);
            this.listGunsListBox.Name = "listGunsListBox";
            this.listGunsListBox.Size = new System.Drawing.Size(167, 160);
            this.listGunsListBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(145, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Turimi sandelyje ginklai";
            // 
            // gotokrepselis
            // 
            this.gotokrepselis.Location = new System.Drawing.Point(213, 324);
            this.gotokrepselis.Name = "gotokrepselis";
            this.gotokrepselis.Size = new System.Drawing.Size(75, 23);
            this.gotokrepselis.TabIndex = 8;
            this.gotokrepselis.Text = "Krepšelis";
            this.gotokrepselis.UseVisualStyleBackColor = true;
            this.gotokrepselis.Click += new System.EventHandler(this.Gotokrepselis_Click);
            // 
            // addtobasket
            // 
            this.addtobasket.Location = new System.Drawing.Point(132, 324);
            this.addtobasket.Name = "addtobasket";
            this.addtobasket.Size = new System.Drawing.Size(75, 23);
            this.addtobasket.TabIndex = 9;
            this.addtobasket.Text = "Į Krepšelį";
            this.addtobasket.UseVisualStyleBackColor = true;
            this.addtobasket.Click += new System.EventHandler(this.Addtobasket_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(436, 390);
            this.Controls.Add(this.addtobasket);
            this.Controls.Add(this.gotokrepselis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listGunsListBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listGunsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gotokrepselis;
        private System.Windows.Forms.Button addtobasket;
    }
}

