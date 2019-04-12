namespace PFEOrigin
{
    partial class GcompteDoct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GcompteDoct));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcurrenpassDoc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNomEtulisateurDoc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAnnuler = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSaveSetti = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtConfirmPasswrodDoc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNouvPasswordDoc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNuvnomUtilisateurDoc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusernameDoc = new System.Windows.Forms.Label();
            this.lblnewusernameDoc = new System.Windows.Forms.Label();
            this.lblcurentpasswordDoc = new System.Windows.Forms.Label();
            this.lblNewPasswordDoc = new System.Windows.Forms.Label();
            this.lblconfirmePasswordDoc = new System.Windows.Forms.Label();
            this.lblpasswordlevel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::PFEOrigin.Properties.Resources.form_error;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(641, 603);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(671, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 21);
            this.label9.TabIndex = 30;
            this.label9.Text = "Mot de passe actuel";
            // 
            // txtcurrenpassDoc
            // 
            this.txtcurrenpassDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtcurrenpassDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtcurrenpassDoc.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcurrenpassDoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcurrenpassDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtcurrenpassDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcurrenpassDoc.HintForeColor = System.Drawing.Color.Empty;
            this.txtcurrenpassDoc.HintText = "";
            this.txtcurrenpassDoc.isPassword = true;
            this.txtcurrenpassDoc.LineFocusedColor = System.Drawing.Color.LightSteelBlue;
            this.txtcurrenpassDoc.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcurrenpassDoc.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.txtcurrenpassDoc.LineThickness = 3;
            this.txtcurrenpassDoc.Location = new System.Drawing.Point(674, 276);
            this.txtcurrenpassDoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtcurrenpassDoc.MaxLength = 32767;
            this.txtcurrenpassDoc.Name = "txtcurrenpassDoc";
            this.txtcurrenpassDoc.Size = new System.Drawing.Size(206, 33);
            this.txtcurrenpassDoc.TabIndex = 29;
            this.txtcurrenpassDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcurrenpassDoc.OnValueChanged += new System.EventHandler(this.txtcurrenpassDoc_OnValueChanged);
            // 
            // txtNomEtulisateurDoc
            // 
            this.txtNomEtulisateurDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNomEtulisateurDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNomEtulisateurDoc.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNomEtulisateurDoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomEtulisateurDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNomEtulisateurDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNomEtulisateurDoc.HintForeColor = System.Drawing.Color.Empty;
            this.txtNomEtulisateurDoc.HintText = "";
            this.txtNomEtulisateurDoc.isPassword = false;
            this.txtNomEtulisateurDoc.LineFocusedColor = System.Drawing.Color.LightSteelBlue;
            this.txtNomEtulisateurDoc.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNomEtulisateurDoc.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.txtNomEtulisateurDoc.LineThickness = 3;
            this.txtNomEtulisateurDoc.Location = new System.Drawing.Point(674, 150);
            this.txtNomEtulisateurDoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomEtulisateurDoc.MaxLength = 32767;
            this.txtNomEtulisateurDoc.Name = "txtNomEtulisateurDoc";
            this.txtNomEtulisateurDoc.Size = new System.Drawing.Size(173, 33);
            this.txtNomEtulisateurDoc.TabIndex = 28;
            this.txtNomEtulisateurDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNomEtulisateurDoc.OnValueChanged += new System.EventHandler(this.txtNomEtulisateurDoc_OnValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(668, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = " Nom d\'utilisateur";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.btnAnnuler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnnuler.BackgroundImage")));
            this.btnAnnuler.ButtonText = "Annuler";
            this.btnAnnuler.ButtonTextMarginLeft = 0;
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAnnuler.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnAnnuler.DisabledForecolor = System.Drawing.Color.White;
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAnnuler.IconPadding = 10;
            this.btnAnnuler.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAnnuler.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAnnuler.IdleBorderRadius = 1;
            this.btnAnnuler.IdleBorderThickness = 0;
            this.btnAnnuler.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAnnuler.IdleIconLeftImage = null;
            this.btnAnnuler.IdleIconRightImage = null;
            this.btnAnnuler.Location = new System.Drawing.Point(939, 513);
            this.btnAnnuler.Name = "btnAnnuler";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnAnnuler.onHoverState = stateProperties1;
            this.btnAnnuler.Size = new System.Drawing.Size(93, 45);
            this.btnAnnuler.TabIndex = 26;
            this.btnAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSaveSetti
            // 
            this.btnSaveSetti.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveSetti.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveSetti.BackgroundImage")));
            this.btnSaveSetti.ButtonText = "Enregistrer";
            this.btnSaveSetti.ButtonTextMarginLeft = 0;
            this.btnSaveSetti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveSetti.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSaveSetti.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnSaveSetti.DisabledForecolor = System.Drawing.Color.White;
            this.btnSaveSetti.ForeColor = System.Drawing.Color.White;
            this.btnSaveSetti.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveSetti.IconPadding = 10;
            this.btnSaveSetti.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveSetti.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSaveSetti.IdleBorderRadius = 1;
            this.btnSaveSetti.IdleBorderThickness = 0;
            this.btnSaveSetti.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSaveSetti.IdleIconLeftImage = null;
            this.btnSaveSetti.IdleIconRightImage = null;
            this.btnSaveSetti.Location = new System.Drawing.Point(756, 513);
            this.btnSaveSetti.Name = "btnSaveSetti";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnSaveSetti.onHoverState = stateProperties2;
            this.btnSaveSetti.Size = new System.Drawing.Size(93, 45);
            this.btnSaveSetti.TabIndex = 25;
            this.btnSaveSetti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveSetti.Click += new System.EventHandler(this.btnSaveSetti_Click);
            // 
            // txtConfirmPasswrodDoc
            // 
            this.txtConfirmPasswrodDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtConfirmPasswrodDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtConfirmPasswrodDoc.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtConfirmPasswrodDoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPasswrodDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtConfirmPasswrodDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPasswrodDoc.HintForeColor = System.Drawing.Color.Empty;
            this.txtConfirmPasswrodDoc.HintText = "";
            this.txtConfirmPasswrodDoc.isPassword = true;
            this.txtConfirmPasswrodDoc.LineFocusedColor = System.Drawing.Color.LightSteelBlue;
            this.txtConfirmPasswrodDoc.LineIdleColor = System.Drawing.Color.Gray;
            this.txtConfirmPasswrodDoc.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.txtConfirmPasswrodDoc.LineThickness = 3;
            this.txtConfirmPasswrodDoc.Location = new System.Drawing.Point(962, 379);
            this.txtConfirmPasswrodDoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPasswrodDoc.MaxLength = 32767;
            this.txtConfirmPasswrodDoc.Name = "txtConfirmPasswrodDoc";
            this.txtConfirmPasswrodDoc.Size = new System.Drawing.Size(206, 33);
            this.txtConfirmPasswrodDoc.TabIndex = 24;
            this.txtConfirmPasswrodDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfirmPasswrodDoc.OnValueChanged += new System.EventHandler(this.txtConfirmPasswrodDoc_OnValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(958, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Confirmer votre mot de passe";
            // 
            // txtNouvPasswordDoc
            // 
            this.txtNouvPasswordDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNouvPasswordDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNouvPasswordDoc.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNouvPasswordDoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNouvPasswordDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNouvPasswordDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNouvPasswordDoc.HintForeColor = System.Drawing.Color.Empty;
            this.txtNouvPasswordDoc.HintText = "";
            this.txtNouvPasswordDoc.isPassword = true;
            this.txtNouvPasswordDoc.LineFocusedColor = System.Drawing.Color.LightSteelBlue;
            this.txtNouvPasswordDoc.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNouvPasswordDoc.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.txtNouvPasswordDoc.LineThickness = 3;
            this.txtNouvPasswordDoc.Location = new System.Drawing.Point(685, 379);
            this.txtNouvPasswordDoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNouvPasswordDoc.MaxLength = 32767;
            this.txtNouvPasswordDoc.Name = "txtNouvPasswordDoc";
            this.txtNouvPasswordDoc.Size = new System.Drawing.Size(208, 33);
            this.txtNouvPasswordDoc.TabIndex = 22;
            this.txtNouvPasswordDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNouvPasswordDoc.OnValueChanged += new System.EventHandler(this.txtNouvPasswordDoc_OnValueChanged);
            // 
            // txtNuvnomUtilisateurDoc
            // 
            this.txtNuvnomUtilisateurDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNuvnomUtilisateurDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNuvnomUtilisateurDoc.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNuvnomUtilisateurDoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNuvnomUtilisateurDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNuvnomUtilisateurDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNuvnomUtilisateurDoc.HintForeColor = System.Drawing.Color.Empty;
            this.txtNuvnomUtilisateurDoc.HintText = "";
            this.txtNuvnomUtilisateurDoc.isPassword = false;
            this.txtNuvnomUtilisateurDoc.LineFocusedColor = System.Drawing.Color.LightSteelBlue;
            this.txtNuvnomUtilisateurDoc.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNuvnomUtilisateurDoc.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.txtNuvnomUtilisateurDoc.LineThickness = 3;
            this.txtNuvnomUtilisateurDoc.Location = new System.Drawing.Point(939, 150);
            this.txtNuvnomUtilisateurDoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNuvnomUtilisateurDoc.MaxLength = 32767;
            this.txtNuvnomUtilisateurDoc.Name = "txtNuvnomUtilisateurDoc";
            this.txtNuvnomUtilisateurDoc.Size = new System.Drawing.Size(175, 33);
            this.txtNuvnomUtilisateurDoc.TabIndex = 21;
            this.txtNuvnomUtilisateurDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNuvnomUtilisateurDoc.OnValueChanged += new System.EventHandler(this.txtNuvnomUtilisateurDoc_OnValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(682, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nouveau mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(937, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nouveau Nom d\'utilisateur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(813, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Paramètre Du Compte";
            // 
            // lblusernameDoc
            // 
            this.lblusernameDoc.AutoSize = true;
            this.lblusernameDoc.ForeColor = System.Drawing.Color.Red;
            this.lblusernameDoc.Location = new System.Drawing.Point(672, 187);
            this.lblusernameDoc.Name = "lblusernameDoc";
            this.lblusernameDoc.Size = new System.Drawing.Size(10, 13);
            this.lblusernameDoc.TabIndex = 31;
            this.lblusernameDoc.Text = " ";
            this.lblusernameDoc.Click += new System.EventHandler(this.lblusernameDoc_Click);
            // 
            // lblnewusernameDoc
            // 
            this.lblnewusernameDoc.AutoSize = true;
            this.lblnewusernameDoc.ForeColor = System.Drawing.Color.Red;
            this.lblnewusernameDoc.Location = new System.Drawing.Point(938, 187);
            this.lblnewusernameDoc.Name = "lblnewusernameDoc";
            this.lblnewusernameDoc.Size = new System.Drawing.Size(10, 13);
            this.lblnewusernameDoc.TabIndex = 32;
            this.lblnewusernameDoc.Text = " ";
            this.lblnewusernameDoc.Click += new System.EventHandler(this.lblnewusernameDoc_Click);
            // 
            // lblcurentpasswordDoc
            // 
            this.lblcurentpasswordDoc.AutoSize = true;
            this.lblcurentpasswordDoc.ForeColor = System.Drawing.Color.Red;
            this.lblcurentpasswordDoc.Location = new System.Drawing.Point(672, 313);
            this.lblcurentpasswordDoc.Name = "lblcurentpasswordDoc";
            this.lblcurentpasswordDoc.Size = new System.Drawing.Size(10, 13);
            this.lblcurentpasswordDoc.TabIndex = 33;
            this.lblcurentpasswordDoc.Text = " ";
            this.lblcurentpasswordDoc.Click += new System.EventHandler(this.lblcurentpasswordDoc_Click);
            // 
            // lblNewPasswordDoc
            // 
            this.lblNewPasswordDoc.AutoSize = true;
            this.lblNewPasswordDoc.ForeColor = System.Drawing.Color.Red;
            this.lblNewPasswordDoc.Location = new System.Drawing.Point(683, 416);
            this.lblNewPasswordDoc.Name = "lblNewPasswordDoc";
            this.lblNewPasswordDoc.Size = new System.Drawing.Size(10, 13);
            this.lblNewPasswordDoc.TabIndex = 34;
            this.lblNewPasswordDoc.Text = " ";
            // 
            // lblconfirmePasswordDoc
            // 
            this.lblconfirmePasswordDoc.AutoSize = true;
            this.lblconfirmePasswordDoc.ForeColor = System.Drawing.Color.Red;
            this.lblconfirmePasswordDoc.Location = new System.Drawing.Point(959, 416);
            this.lblconfirmePasswordDoc.Name = "lblconfirmePasswordDoc";
            this.lblconfirmePasswordDoc.Size = new System.Drawing.Size(10, 13);
            this.lblconfirmePasswordDoc.TabIndex = 35;
            this.lblconfirmePasswordDoc.Text = " ";
            this.lblconfirmePasswordDoc.Click += new System.EventHandler(this.lblconfirmePasswordDoc_Click);
            // 
            // lblpasswordlevel
            // 
            this.lblpasswordlevel.AutoSize = true;
            this.lblpasswordlevel.Location = new System.Drawing.Point(683, 438);
            this.lblpasswordlevel.Name = "lblpasswordlevel";
            this.lblpasswordlevel.Size = new System.Drawing.Size(10, 13);
            this.lblpasswordlevel.TabIndex = 36;
            this.lblpasswordlevel.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.AliceBlue;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(822, 571);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 30);
            this.label6.TabIndex = 37;
            this.label6.Text = "© Fandi && Kabou ";
            // 
            // GcompteDoct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 603);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblpasswordlevel);
            this.Controls.Add(this.lblconfirmePasswordDoc);
            this.Controls.Add(this.lblNewPasswordDoc);
            this.Controls.Add(this.lblcurentpasswordDoc);
            this.Controls.Add(this.lblnewusernameDoc);
            this.Controls.Add(this.lblusernameDoc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtcurrenpassDoc);
            this.Controls.Add(this.txtNomEtulisateurDoc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSaveSetti);
            this.Controls.Add(this.txtConfirmPasswrodDoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNouvPasswordDoc);
            this.Controls.Add(this.txtNuvnomUtilisateurDoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GcompteDoct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcurrenpassDoc;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNomEtulisateurDoc;
        private System.Windows.Forms.Label label8;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAnnuler;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSaveSetti;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtConfirmPasswrodDoc;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNouvPasswordDoc;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNuvnomUtilisateurDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblconfirmePasswordDoc;
        private System.Windows.Forms.Label lblNewPasswordDoc;
        private System.Windows.Forms.Label lblcurentpasswordDoc;
        private System.Windows.Forms.Label lblnewusernameDoc;
        private System.Windows.Forms.Label lblusernameDoc;
        private System.Windows.Forms.Label lblpasswordlevel;
        private System.Windows.Forms.Label label6;
    }
}