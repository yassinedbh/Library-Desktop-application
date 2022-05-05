
namespace Projet_Bibliotheque
{
    partial class Empruntform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empruntform));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckBox3 = new System.Windows.Forms.CheckBox();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(516, 313);
            this.dataGridView1.TabIndex = 66;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(266, 473);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 36);
            this.button3.TabIndex = 65;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(77, 473);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(159, 36);
            this.Button1.TabIndex = 63;
            this.Button1.Text = "Ajouter";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button5
            // 
            this.Button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.Location = new System.Drawing.Point(953, 499);
            this.Button5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(151, 55);
            this.Button5.TabIndex = 62;
            this.Button5.Text = "Précédent";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(570, 350);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 28);
            this.label3.TabIndex = 60;
            this.label3.Text = "Debut Emprunt :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(570, 120);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(75, 28);
            this.Label1.TabIndex = 56;
            this.Label1.Text = "CIN :";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label6.Location = new System.Drawing.Point(15, 57);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(437, 40);
            this.Label6.TabIndex = 55;
            this.Label6.Text = "Liste des Emprunts en cours";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(807, 356);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 22);
            this.dateTimePicker1.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(570, 393);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 28);
            this.label4.TabIndex = 70;
            this.label4.Text = "Fin Emprunt:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(807, 398);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(275, 22);
            this.dateTimePicker2.TabIndex = 71;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.CheckBox3);
            this.GroupBox1.Controls.Add(this.CheckBox2);
            this.GroupBox1.Controls.Add(this.CheckBox1);
            this.GroupBox1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(562, 172);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.GroupBox1.Size = new System.Drawing.Size(520, 148);
            this.GroupBox1.TabIndex = 72;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Ouvrages";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // CheckBox3
            // 
            this.CheckBox3.AutoSize = true;
            this.CheckBox3.Location = new System.Drawing.Point(303, 98);
            this.CheckBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.Size(168, 32);
            this.CheckBox3.TabIndex = 6;
            this.CheckBox3.Text = "Periodicité";
            this.CheckBox3.UseVisualStyleBackColor = true;
            this.CheckBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Location = new System.Drawing.Point(303, 59);
            this.CheckBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(72, 32);
            this.CheckBox2.TabIndex = 5;
            this.CheckBox2.Text = "CD";
            this.CheckBox2.UseVisualStyleBackColor = true;
            this.CheckBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(303, 18);
            this.CheckBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(97, 32);
            this.CheckBox1.TabIndex = 4;
            this.CheckBox1.Text = "Livre";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(807, 116);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 32);
            this.textBox1.TabIndex = 74;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(615, 500);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(281, 55);
            this.button2.TabIndex = 75;
            this.button2.Text = "Afficher liste emprunt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(832, 3);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(272, 70);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 73;
            this.pictureBox5.TabStop = false;
            // 
            // Empruntform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1110, 566);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Empruntform";
            this.Text = "Empruntform";
            this.Load += new System.EventHandler(this.Empruntform_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.CheckBox CheckBox3;
        internal System.Windows.Forms.CheckBox CheckBox2;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.PictureBox pictureBox5;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Button button2;
    }
}