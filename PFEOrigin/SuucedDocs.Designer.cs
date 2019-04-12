namespace PFEOrigin
{
    partial class SuucedDocs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuucedDocs));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRenregister = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.picSuuceAddDocs = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSuuceAddDocs)).BeginInit();
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
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PFEOrigin.Properties.Resources._02;
            this.pictureBox1.Location = new System.Drawing.Point(273, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRenregister
            // 
            this.btnRenregister.BackColor = System.Drawing.Color.Transparent;
            this.btnRenregister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRenregister.BackgroundImage")));
            this.btnRenregister.ButtonText = "Retour";
            this.btnRenregister.ButtonTextMarginLeft = 0;
            this.btnRenregister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRenregister.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnRenregister.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnRenregister.DisabledForecolor = System.Drawing.Color.White;
            this.btnRenregister.ForeColor = System.Drawing.Color.White;
            this.btnRenregister.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRenregister.IconPadding = 10;
            this.btnRenregister.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRenregister.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnRenregister.IdleBorderRadius = 1;
            this.btnRenregister.IdleBorderThickness = 0;
            this.btnRenregister.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnRenregister.IdleIconLeftImage = null;
            this.btnRenregister.IdleIconRightImage = null;
            this.btnRenregister.Location = new System.Drawing.Point(414, 347);
            this.btnRenregister.Name = "btnRenregister";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnRenregister.onHoverState = stateProperties2;
            this.btnRenregister.Size = new System.Drawing.Size(93, 45);
            this.btnRenregister.TabIndex = 11;
            this.btnRenregister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRenregister.Click += new System.EventHandler(this.btnRenregister_Click);
            // 
            // picSuuceAddDocs
            // 
            this.picSuuceAddDocs.Image = global::PFEOrigin.Properties.Resources._011_flash_message1;
            this.picSuuceAddDocs.Location = new System.Drawing.Point(273, 41);
            this.picSuuceAddDocs.Name = "picSuuceAddDocs";
            this.picSuuceAddDocs.Size = new System.Drawing.Size(400, 300);
            this.picSuuceAddDocs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSuuceAddDocs.TabIndex = 12;
            this.picSuuceAddDocs.TabStop = false;
            this.picSuuceAddDocs.Visible = false;
            // 
            // SuucedDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 417);
            this.Controls.Add(this.picSuuceAddDocs);
            this.Controls.Add(this.btnRenregister);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuucedDocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuucedDocs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSuuceAddDocs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRenregister;
        public System.Windows.Forms.PictureBox picSuuceAddDocs;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}