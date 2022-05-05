
namespace Projet_Bibliotheque
{
    partial class Motdepasseform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Motdepasseform));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(396, 77);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(133, 108);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 7;
            this.PictureBox1.TabStop = false;
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button1.Location = new System.Drawing.Point(281, 347);
            this.Button1.Margin = new System.Windows.Forms.Padding(4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(356, 47);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "Recuperer Mot De Passe";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(281, 270);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(356, 34);
            this.TextBox1.TabIndex = 5;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(351, 207);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(221, 27);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Saisissez votre EMail";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(743, 418);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Motdepasseform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(918, 472);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.Name = "Motdepasseform";
            this.Text = "Motdepasseform";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button button2;
    }
}