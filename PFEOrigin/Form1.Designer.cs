namespace PFEOrigin
{
    partial class FStart
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FStart));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnCommancer = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtusername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtpassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PicDoc = new System.Windows.Forms.PictureBox();
            this.PicInfermier = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsernam = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblChoix = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInfermier)).BeginInit();
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
            this.pictureBox1.Image = global::PFEOrigin.Properties.Resources.nymbl_doc_entry;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 583);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(843, 79);
            this.bunifuDropdown1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.Aqua;
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(217, 35);
            this.bunifuDropdown1.TabIndex = 1;
            this.bunifuDropdown1.onItemSelected += new System.EventHandler(this.BunifuDropdown1_onItemSelected);
            // 
            // btnCommancer
            // 
            this.btnCommancer.BackColor = System.Drawing.Color.Transparent;
            this.btnCommancer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCommancer.BackgroundImage")));
            this.btnCommancer.ButtonText = "Commencer";
            this.btnCommancer.ButtonTextMarginLeft = 0;
            this.btnCommancer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCommancer.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnCommancer.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnCommancer.DisabledForecolor = System.Drawing.Color.White;
            this.btnCommancer.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommancer.ForeColor = System.Drawing.Color.White;
            this.btnCommancer.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCommancer.IconPadding = 10;
            this.btnCommancer.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCommancer.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnCommancer.IdleBorderRadius = 1;
            this.btnCommancer.IdleBorderThickness = 0;
            this.btnCommancer.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnCommancer.IdleIconLeftImage = null;
            this.btnCommancer.IdleIconRightImage = null;
            this.btnCommancer.Location = new System.Drawing.Point(992, 466);
            this.btnCommancer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCommancer.Name = "btnCommancer";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnCommancer.onHoverState = stateProperties2;
            this.btnCommancer.Size = new System.Drawing.Size(118, 45);
            this.btnCommancer.TabIndex = 2;
            this.btnCommancer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCommancer.Click += new System.EventHandler(this.BtnCommancer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // txtusername
            // 
            this.txtusername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtusername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtusername.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtusername.HintForeColor = System.Drawing.Color.Empty;
            this.txtusername.HintText = "";
            this.txtusername.isPassword = false;
            this.txtusername.LineFocusedColor = System.Drawing.Color.LightSteelBlue;
            this.txtusername.LineIdleColor = System.Drawing.Color.Gray;
            this.txtusername.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.txtusername.LineThickness = 3;
            this.txtusername.Location = new System.Drawing.Point(898, 260);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4);
            this.txtusername.MaxLength = 32767;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(319, 33);
            this.txtusername.TabIndex = 4;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtusername.OnValueChanged += new System.EventHandler(this.Txtusername_OnValueChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtpassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtpassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtpassword.HintText = "";
            this.txtpassword.isPassword = true;
            this.txtpassword.LineFocusedColor = System.Drawing.Color.LightSteelBlue;
            this.txtpassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtpassword.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.txtpassword.LineThickness = 3;
            this.txtpassword.Location = new System.Drawing.Point(898, 368);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(319, 33);
            this.txtpassword.TabIndex = 5;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpassword.OnValueChanged += new System.EventHandler(this.BunifuMaterialTextbox2_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(898, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(898, 324);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // PicDoc
            // 
            this.PicDoc.Image = ((System.Drawing.Image)(resources.GetObject("PicDoc.Image")));
            this.PicDoc.Location = new System.Drawing.Point(1084, 23);
            this.PicDoc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PicDoc.Name = "PicDoc";
            this.PicDoc.Size = new System.Drawing.Size(190, 166);
            this.PicDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicDoc.TabIndex = 8;
            this.PicDoc.TabStop = false;
            this.PicDoc.Visible = false;
            // 
            // PicInfermier
            // 
            this.PicInfermier.Image = ((System.Drawing.Image)(resources.GetObject("PicInfermier.Image")));
            this.PicInfermier.Location = new System.Drawing.Point(1084, 23);
            this.PicInfermier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PicInfermier.Name = "PicInfermier";
            this.PicInfermier.Size = new System.Drawing.Size(190, 166);
            this.PicInfermier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicInfermier.TabIndex = 9;
            this.PicInfermier.TabStop = false;
            this.PicInfermier.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(241)))));
            this.label3.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bienvenu...";
            // 
            // lblUsernam
            // 
            this.lblUsernam.AutoSize = true;
            this.lblUsernam.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernam.ForeColor = System.Drawing.Color.Red;
            this.lblUsernam.Location = new System.Drawing.Point(898, 297);
            this.lblUsernam.Name = "lblUsernam";
            this.lblUsernam.Size = new System.Drawing.Size(0, 13);
            this.lblUsernam.TabIndex = 11;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.Red;
            this.lblpassword.Location = new System.Drawing.Point(898, 405);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(0, 13);
            this.lblpassword.TabIndex = 12;
            // 
            // lblChoix
            // 
            this.lblChoix.AutoSize = true;
            this.lblChoix.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoix.ForeColor = System.Drawing.Color.Red;
            this.lblChoix.Location = new System.Drawing.Point(847, 62);
            this.lblChoix.Name = "lblChoix";
            this.lblChoix.Size = new System.Drawing.Size(0, 13);
            this.lblChoix.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(241)))));
            this.label4.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(603, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cliquez sur le menu déroulant \r\net choisissez pour commencer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.AliceBlue;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 544);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 30);
            this.label6.TabIndex = 16;
            this.label6.Text = "© Fandi && Kabou ";
            // 
            // FStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1287, 583);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblChoix);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblUsernam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PicInfermier);
            this.Controls.Add(this.PicDoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCommancer);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInfermier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCommancer;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicInfermier;
        private System.Windows.Forms.PictureBox PicDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblUsernam;
        private System.Windows.Forms.Label lblChoix;
        private System.Windows.Forms.Label label4;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtusername;
        private System.Windows.Forms.Label label6;
    }
}

