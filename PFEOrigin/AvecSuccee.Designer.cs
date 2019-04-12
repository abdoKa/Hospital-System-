namespace PFEOrigin
{
    partial class AvecSuccee
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
            this.picsuccee = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picsuccee)).BeginInit();
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
            this.bunifuDragControl1.TargetControl = this.picsuccee;
            this.bunifuDragControl1.Vertical = true;
            // 
            // picsuccee
            // 
            this.picsuccee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picsuccee.Image = global::PFEOrigin.Properties.Resources._011_flash_message;
            this.picsuccee.Location = new System.Drawing.Point(0, 0);
            this.picsuccee.Name = "picsuccee";
            this.picsuccee.Size = new System.Drawing.Size(745, 450);
            this.picsuccee.TabIndex = 49;
            this.picsuccee.TabStop = false;
            this.picsuccee.Click += new System.EventHandler(this.picsuccee_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(112, 94);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(554, 23);
            this.linkLabel1.TabIndex = 50;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ajouté Avec Succès , Cliquez ici pour revenir à votre espace.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // AvecSuccee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.picsuccee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AvecSuccee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AvecSuccee";
            ((System.ComponentModel.ISupportInitialize)(this.picsuccee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox picsuccee;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}