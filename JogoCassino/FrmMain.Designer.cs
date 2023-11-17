namespace JogoCassino
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.BoxMain = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ImgTree = new Guna.UI2.WinForms.Guna2PictureBox();
            this.imgOne = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ImgTwo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.MsgInfo = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_totalGiros = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Numerador = new System.Windows.Forms.NumericUpDown();
            this.btnComprar = new System.Windows.Forms.Button();
            this.guna2GradientPanel1.SuspendLayout();
            this.BoxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numerador)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(0)))), ((int)(((byte)(54)))));
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(0)))), ((int)(((byte)(54)))));
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(2)))), ((int)(((byte)(17)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(4, 240);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(108, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "SPIN";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.guna2GradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2GradientPanel1.Controls.Add(this.BoxMain);
            this.guna2GradientPanel1.Controls.Add(this.guna2ControlBox3);
            this.guna2GradientPanel1.Controls.Add(this.guna2ControlBox1);
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1050, 720);
            this.guna2GradientPanel1.TabIndex = 1;
            // 
            // BoxMain
            // 
            this.BoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.BoxMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.BoxMain.BorderRadius = 10;
            this.BoxMain.BorderThickness = 0;
            this.BoxMain.Controls.Add(this.btnComprar);
            this.BoxMain.Controls.Add(this.Numerador);
            this.BoxMain.Controls.Add(this.label1);
            this.BoxMain.Controls.Add(this.ImgTree);
            this.BoxMain.Controls.Add(this.imgOne);
            this.BoxMain.Controls.Add(this.btn_totalGiros);
            this.BoxMain.Controls.Add(this.guna2Button2);
            this.BoxMain.Controls.Add(this.guna2Button1);
            this.BoxMain.Controls.Add(this.ImgTwo);
            this.BoxMain.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.BoxMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.BoxMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BoxMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.BoxMain.Location = new System.Drawing.Point(243, 3);
            this.BoxMain.Name = "BoxMain";
            this.BoxMain.ShadowDecoration.BorderRadius = 10;
            this.BoxMain.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(0)))), ((int)(((byte)(81)))));
            this.BoxMain.ShadowDecoration.Depth = 20;
            this.BoxMain.Size = new System.Drawing.Size(693, 289);
            this.BoxMain.TabIndex = 8;
            // 
            // ImgTree
            // 
            this.ImgTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(0)))), ((int)(((byte)(54)))));
            this.ImgTree.BorderRadius = 8;
            this.ImgTree.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.ImgTree.ImageRotate = 0F;
            this.ImgTree.Location = new System.Drawing.Point(491, 24);
            this.ImgTree.Name = "ImgTree";
            this.ImgTree.Size = new System.Drawing.Size(80, 85);
            this.ImgTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgTree.TabIndex = 7;
            this.ImgTree.TabStop = false;
            // 
            // imgOne
            // 
            this.imgOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(0)))), ((int)(((byte)(54)))));
            this.imgOne.BorderRadius = 8;
            this.imgOne.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.imgOne.ImageRotate = 0F;
            this.imgOne.Location = new System.Drawing.Point(111, 24);
            this.imgOne.Name = "imgOne";
            this.imgOne.Size = new System.Drawing.Size(80, 85);
            this.imgOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOne.TabIndex = 5;
            this.imgOne.TabStop = false;
            // 
            // ImgTwo
            // 
            this.ImgTwo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(0)))), ((int)(((byte)(54)))));
            this.ImgTwo.BorderRadius = 8;
            this.ImgTwo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.ImgTwo.ImageRotate = 0F;
            this.ImgTwo.Location = new System.Drawing.Point(301, 24);
            this.ImgTwo.Name = "ImgTwo";
            this.ImgTwo.Size = new System.Drawing.Size(80, 85);
            this.ImgTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgTwo.TabIndex = 6;
            this.ImgTwo.TabStop = false;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(45)))), ((int)(((byte)(190)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1012, 1);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(34, 25);
            this.guna2ControlBox3.TabIndex = 4;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(45)))), ((int)(((byte)(190)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(977, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 25);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 12;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.guna2PictureBox1.Image = global::JogoCassino.Properties.Resources.B116YDg1_4S;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1050, 720);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 10;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 8;
            this.guna2Elipse1.TargetControl = this;
            // 
            // MsgInfo
            // 
            this.MsgInfo.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OKCancel;
            this.MsgInfo.Caption = null;
            this.MsgInfo.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.MsgInfo.Parent = null;
            this.MsgInfo.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.MsgInfo.Text = null;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Button2.Animated = true;
            this.guna2Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(0)))), ((int)(((byte)(54)))));
            this.guna2Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(0)))), ((int)(((byte)(54)))));
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(139, 240);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(169, 45);
            this.guna2Button2.TabIndex = 0;
            this.guna2Button2.Text = "Comprar Giros";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btn_totalGiros
            // 
            this.btn_totalGiros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_totalGiros.Animated = true;
            this.btn_totalGiros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(0)))), ((int)(((byte)(54)))));
            this.btn_totalGiros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_totalGiros.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(0)))), ((int)(((byte)(54)))));
            this.btn_totalGiros.BorderRadius = 8;
            this.btn_totalGiros.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn_totalGiros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_totalGiros.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.btn_totalGiros.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_totalGiros.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_totalGiros.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_totalGiros.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_totalGiros.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(170)))), ((int)(((byte)(44)))));
            this.btn_totalGiros.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_totalGiros.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_totalGiros.Location = new System.Drawing.Point(620, 240);
            this.btn_totalGiros.Name = "btn_totalGiros";
            this.btn_totalGiros.Size = new System.Drawing.Size(70, 45);
            this.btn_totalGiros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(633, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Giros";
            // 
            // Numerador
            // 
            this.Numerador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.Numerador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Numerador.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numerador.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Numerador.Location = new System.Drawing.Point(385, 247);
            this.Numerador.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Numerador.Name = "Numerador";
            this.Numerador.Size = new System.Drawing.Size(47, 29);
            this.Numerador.TabIndex = 9;
            this.Numerador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnComprar
            // 
            this.btnComprar.AutoSize = true;
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnComprar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Location = new System.Drawing.Point(440, 247);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(49, 32);
            this.btnComprar.TabIndex = 10;
            this.btnComprar.Text = "OK!";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1050, 720);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CsssinoOfline";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.BoxMain.ResumeLayout(false);
            this.BoxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numerador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2GroupBox BoxMain;
        private Guna.UI2.WinForms.Guna2PictureBox ImgTree;
        private Guna.UI2.WinForms.Guna2PictureBox imgOne;
        private Guna.UI2.WinForms.Guna2PictureBox ImgTwo;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        public Guna.UI2.WinForms.Guna2MessageDialog MsgInfo;
        private Guna.UI2.WinForms.Guna2Button btn_totalGiros;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.NumericUpDown Numerador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComprar;
    }
}

