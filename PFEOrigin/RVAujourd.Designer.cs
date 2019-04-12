namespace PFEOrigin
{
    partial class RVAujourd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RVAujourd));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DGVRVaujour = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PicDown = new System.Windows.Forms.PictureBox();
            this.picUp = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRVaujour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).BeginInit();
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
            this.pictureBox1.Image = global::PFEOrigin.Properties.Resources.dribbble_export_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // DGVRVaujour
            // 
            this.DGVRVaujour.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DGVRVaujour.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVRVaujour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVRVaujour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVRVaujour.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVRVaujour.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVRVaujour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVRVaujour.ColumnHeadersHeight = 40;
            this.DGVRVaujour.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.DGVRVaujour.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DGVRVaujour.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVRVaujour.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.DGVRVaujour.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DGVRVaujour.CurrentTheme.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DGVRVaujour.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.DGVRVaujour.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DGVRVaujour.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DGVRVaujour.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVRVaujour.CurrentTheme.Name = null;
            this.DGVRVaujour.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.DGVRVaujour.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DGVRVaujour.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVRVaujour.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.DGVRVaujour.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVRVaujour.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVRVaujour.EnableHeadersVisualStyles = false;
            this.DGVRVaujour.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.DGVRVaujour.HeaderBackColor = System.Drawing.Color.DarkSlateGray;
            this.DGVRVaujour.HeaderBgColor = System.Drawing.Color.Empty;
            this.DGVRVaujour.HeaderForeColor = System.Drawing.Color.White;
            this.DGVRVaujour.Location = new System.Drawing.Point(49, 90);
            this.DGVRVaujour.Name = "DGVRVaujour";
            this.DGVRVaujour.RowHeadersVisible = false;
            this.DGVRVaujour.RowTemplate.Height = 40;
            this.DGVRVaujour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVRVaujour.Size = new System.Drawing.Size(735, 499);
            this.DGVRVaujour.TabIndex = 3;
            this.DGVRVaujour.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkSlateGray;
            this.DGVRVaujour.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click_1);
            // 
            // PicDown
            // 
            this.PicDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicDown.Image = ((System.Drawing.Image)(resources.GetObject("PicDown.Image")));
            this.PicDown.Location = new System.Drawing.Point(365, 34);
            this.PicDown.Name = "PicDown";
            this.PicDown.Size = new System.Drawing.Size(63, 50);
            this.PicDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicDown.TabIndex = 2;
            this.PicDown.TabStop = false;
            this.PicDown.Click += new System.EventHandler(this.PicDown_Click);
            // 
            // picUp
            // 
            this.picUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUp.Image = ((System.Drawing.Image)(resources.GetObject("picUp.Image")));
            this.picUp.Location = new System.Drawing.Point(365, 34);
            this.picUp.Name = "picUp";
            this.picUp.Size = new System.Drawing.Size(63, 50);
            this.picUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUp.TabIndex = 1;
            this.picUp.TabStop = false;
            this.picUp.Visible = false;
            this.picUp.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 645);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 123);
            this.panel1.TabIndex = 5;
            // 
            // RVAujourd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DGVRVaujour);
            this.Controls.Add(this.PicDown);
            this.Controls.Add(this.picUp);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RVAujourd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RVAujourd";
            this.Load += new System.EventHandler(this.RVAujourd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRVaujour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PicDown;
        private System.Windows.Forms.PictureBox picUp;
        private Bunifu.UI.WinForms.BunifuDataGridView DGVRVaujour;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}