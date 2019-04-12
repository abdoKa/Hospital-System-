namespace PFEOrigin
{
    partial class FDoctorSpace
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlquiter = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlRV = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlImprimer = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDocPatiant = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGcom = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlquiter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.pnlRV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlImprimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlDocPatiant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlGcom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pictureBox1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::PFEOrigin.Properties.Resources.did_doctor_for_dribs;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 626);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlquiter
            // 
            this.pnlquiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(180)))), ((int)(((byte)(75)))));
            this.pnlquiter.Controls.Add(this.pictureBox6);
            this.pnlquiter.Controls.Add(this.label4);
            this.pnlquiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlquiter.Location = new System.Drawing.Point(900, 484);
            this.pnlquiter.Name = "pnlquiter";
            this.pnlquiter.Size = new System.Drawing.Size(351, 105);
            this.pnlquiter.TabIndex = 4;
            this.pnlquiter.Click += new System.EventHandler(this.Panel4_Click);
            this.pnlquiter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlquiter_Paint);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox6.Image = global::PFEOrigin.Properties.Resources.logout;
            this.pictureBox6.Location = new System.Drawing.Point(6, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(132, 105);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Déconnecter";
            // 
            // pnlRV
            // 
            this.pnlRV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(219)))), ((int)(((byte)(223)))));
            this.pnlRV.Controls.Add(this.pictureBox5);
            this.pnlRV.Controls.Add(this.label3);
            this.pnlRV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlRV.Location = new System.Drawing.Point(900, 145);
            this.pnlRV.Name = "pnlRV";
            this.pnlRV.Size = new System.Drawing.Size(351, 105);
            this.pnlRV.TabIndex = 5;
            this.pnlRV.Click += new System.EventHandler(this.Panel3_Click);
            this.pnlRV.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox5.Image = global::PFEOrigin.Properties.Resources.timely_dribbble;
            this.pictureBox5.Location = new System.Drawing.Point(6, 1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(132, 105);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rendez-vous \r\nd\'aujourd\'hui";
            // 
            // pnlImprimer
            // 
            this.pnlImprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(138)))), ((int)(((byte)(180)))));
            this.pnlImprimer.Controls.Add(this.pictureBox2);
            this.pnlImprimer.Controls.Add(this.label5);
            this.pnlImprimer.Controls.Add(this.label2);
            this.pnlImprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlImprimer.Location = new System.Drawing.Point(900, 258);
            this.pnlImprimer.Name = "pnlImprimer";
            this.pnlImprimer.Size = new System.Drawing.Size(351, 105);
            this.pnlImprimer.TabIndex = 6;
            this.pnlImprimer.Click += new System.EventHandler(this.Panel2_Click);
            this.pnlImprimer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = global::PFEOrigin.Properties.Resources.francispaper_animate1;
            this.pictureBox2.Location = new System.Drawing.Point(6, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, -56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 40);
            this.label5.TabIndex = 2;
            this.label5.Text = "Rendez-vous \r\nd\'aujourd\'hui";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imprimer \r\nl\'ordonance";
            // 
            // pnlDocPatiant
            // 
            this.pnlDocPatiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.pnlDocPatiant.Controls.Add(this.pictureBox3);
            this.pnlDocPatiant.Controls.Add(this.label1);
            this.pnlDocPatiant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlDocPatiant.Location = new System.Drawing.Point(900, 32);
            this.pnlDocPatiant.Name = "pnlDocPatiant";
            this.pnlDocPatiant.Size = new System.Drawing.Size(351, 103);
            this.pnlDocPatiant.TabIndex = 3;
            this.pnlDocPatiant.Click += new System.EventHandler(this.Panel1_Click);
            this.pnlDocPatiant.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDocPatiant_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox3.Image = global::PFEOrigin.Properties.Resources.doctor1;
            this.pictureBox3.Location = new System.Drawing.Point(6, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(132, 103);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Document \r\ndu Patiants";
            // 
            // pnlGcom
            // 
            this.pnlGcom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(190)))), ((int)(((byte)(213)))));
            this.pnlGcom.Controls.Add(this.pictureBox7);
            this.pnlGcom.Controls.Add(this.label6);
            this.pnlGcom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlGcom.Location = new System.Drawing.Point(900, 371);
            this.pnlGcom.Name = "pnlGcom";
            this.pnlGcom.Size = new System.Drawing.Size(351, 105);
            this.pnlGcom.TabIndex = 9;
            this.pnlGcom.Click += new System.EventHandler(this.panel5_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox7.Image = global::PFEOrigin.Properties.Resources.yosemite_settings;
            this.pictureBox7.Location = new System.Drawing.Point(6, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(132, 105);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(154, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Gestion de compte";
            // 
            // FDoctorSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 626);
            this.Controls.Add(this.pnlGcom);
            this.Controls.Add(this.pnlquiter);
            this.Controls.Add(this.pnlRV);
            this.Controls.Add(this.pnlImprimer);
            this.Controls.Add(this.pnlDocPatiant);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDoctorSpace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDoctorSpace";
            this.Load += new System.EventHandler(this.FDoctorSpace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlquiter.ResumeLayout(false);
            this.pnlquiter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.pnlRV.ResumeLayout(false);
            this.pnlRV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlImprimer.ResumeLayout(false);
            this.pnlImprimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlDocPatiant.ResumeLayout(false);
            this.pnlDocPatiant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlGcom.ResumeLayout(false);
            this.pnlGcom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Panel pnlquiter;
        public System.Windows.Forms.Panel pnlRV;
        public System.Windows.Forms.Panel pnlImprimer;
        public System.Windows.Forms.Panel pnlDocPatiant;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Panel pnlGcom;
    }
}