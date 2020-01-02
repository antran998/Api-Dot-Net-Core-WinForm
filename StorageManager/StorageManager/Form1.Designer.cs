namespace StorageManager
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
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.MinimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.FullScreenBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.ExitBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.activeBar = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.InfoBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuPages1 = new Bunifu.UI.WinForms.BunifuPages();
            this.productTypePg = new System.Windows.Forms.TabPage();
            this.StatisticPg = new System.Windows.Forms.TabPage();
            this.BillMngPg = new System.Windows.Forms.TabPage();
            this.UserInfo = new System.Windows.Forms.TabPage();
            this.DashboardPg = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullScreenBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.bunifuPages1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.MinimizeBtn);
            this.panel1.Controls.Add(this.FullScreenBtn);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 23);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(53, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Warehouse Manager";
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeBtn.Image")));
            this.MinimizeBtn.ImageActive = null;
            this.MinimizeBtn.Location = new System.Drawing.Point(833, 0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(40, 23);
            this.MinimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeBtn.TabIndex = 4;
            this.MinimizeBtn.TabStop = false;
            this.MinimizeBtn.Zoom = 0;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            this.MinimizeBtn.MouseEnter += new System.EventHandler(this.MinimizeBtn_MouseEnter);
            this.MinimizeBtn.MouseLeave += new System.EventHandler(this.MinimizeBtn_MouseLeave);
            // 
            // FullScreenBtn
            // 
            this.FullScreenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FullScreenBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.FullScreenBtn.Image = ((System.Drawing.Image)(resources.GetObject("FullScreenBtn.Image")));
            this.FullScreenBtn.ImageActive = null;
            this.FullScreenBtn.Location = new System.Drawing.Point(873, 0);
            this.FullScreenBtn.Name = "FullScreenBtn";
            this.FullScreenBtn.Size = new System.Drawing.Size(40, 23);
            this.FullScreenBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FullScreenBtn.TabIndex = 3;
            this.FullScreenBtn.TabStop = false;
            this.FullScreenBtn.Zoom = 0;
            this.FullScreenBtn.Click += new System.EventHandler(this.FullScreenBtn_Click);
            this.FullScreenBtn.MouseEnter += new System.EventHandler(this.FullScreenBtn_MouseEnter);
            this.FullScreenBtn.MouseLeave += new System.EventHandler(this.FullScreenBtn_MouseLeave);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.ImageActive = null;
            this.ExitBtn.Location = new System.Drawing.Point(913, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(40, 23);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Zoom = 0;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            this.ExitBtn.MouseEnter += new System.EventHandler(this.ExitBtn_MouseEnter);
            this.ExitBtn.MouseLeave += new System.EventHandler(this.ExitBtn_MouseLeave);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(50, 23);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Controls.Add(this.bunifuFlatButton2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 513);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.activeBar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 182);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 259);
            this.panel5.TabIndex = 4;
            // 
            // activeBar
            // 
            this.activeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.activeBar.Location = new System.Drawing.Point(0, 0);
            this.activeBar.Name = "activeBar";
            this.activeBar.Size = new System.Drawing.Size(8, 48);
            this.activeBar.TabIndex = 9;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 441);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(200, 24);
            this.bunifuSeparator1.TabIndex = 3;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Logout";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 50D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 465);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(200, 48);
            this.bunifuFlatButton2.TabIndex = 2;
            this.bunifuFlatButton2.Text = "Logout";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel4.Controls.Add(this.InfoBtn);
            this.panel4.Controls.Add(this.bunifuPictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 182);
            this.panel4.TabIndex = 0;
            // 
            // InfoBtn
            // 
            this.InfoBtn.AllowToggling = false;
            this.InfoBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.InfoBtn.AnimationSpeed = 200;
            this.InfoBtn.AutoGenerateColors = false;
            this.InfoBtn.BackColor = System.Drawing.Color.Transparent;
            this.InfoBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.InfoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InfoBtn.BackgroundImage")));
            this.InfoBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.InfoBtn.ButtonText = "INFO";
            this.InfoBtn.ButtonTextMarginLeft = 0;
            this.InfoBtn.ColorContrastOnClick = 45;
            this.InfoBtn.ColorContrastOnHover = 45;
            this.InfoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.InfoBtn.CustomizableEdges = borderEdges1;
            this.InfoBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.InfoBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.InfoBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.InfoBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.InfoBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.InfoBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.InfoBtn.ForeColor = System.Drawing.Color.White;
            this.InfoBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.InfoBtn.IconMarginLeft = 11;
            this.InfoBtn.IconPadding = 10;
            this.InfoBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.InfoBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.InfoBtn.IdleBorderRadius = 3;
            this.InfoBtn.IdleBorderThickness = 1;
            this.InfoBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.InfoBtn.IdleIconLeftImage = null;
            this.InfoBtn.IdleIconRightImage = null;
            this.InfoBtn.IndicateFocus = false;
            this.InfoBtn.Location = new System.Drawing.Point(40, 131);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.InfoBtn.onHoverState.BorderRadius = 3;
            this.InfoBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.InfoBtn.onHoverState.BorderThickness = 1;
            this.InfoBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.InfoBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.InfoBtn.onHoverState.IconLeftImage = null;
            this.InfoBtn.onHoverState.IconRightImage = null;
            this.InfoBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.InfoBtn.OnIdleState.BorderRadius = 3;
            this.InfoBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.InfoBtn.OnIdleState.BorderThickness = 1;
            this.InfoBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.InfoBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.InfoBtn.OnIdleState.IconLeftImage = null;
            this.InfoBtn.OnIdleState.IconRightImage = null;
            this.InfoBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.InfoBtn.OnPressedState.BorderRadius = 3;
            this.InfoBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.InfoBtn.OnPressedState.BorderThickness = 1;
            this.InfoBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.InfoBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.InfoBtn.OnPressedState.IconLeftImage = null;
            this.InfoBtn.OnPressedState.IconRightImage = null;
            this.InfoBtn.Size = new System.Drawing.Size(118, 31);
            this.InfoBtn.TabIndex = 1;
            this.InfoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoBtn.TextMarginLeft = 0;
            this.InfoBtn.UseDefaultRadiusAndThickness = true;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuPictureBox1.BorderRadius = 50;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(48, 21);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(104, 104);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bunifuPages1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(753, 513);
            this.panel3.TabIndex = 2;
            // 
            // bunifuPages1
            // 
            this.bunifuPages1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.bunifuPages1.AllowTransitions = true;
            this.bunifuPages1.Controls.Add(this.productTypePg);
            this.bunifuPages1.Controls.Add(this.StatisticPg);
            this.bunifuPages1.Controls.Add(this.BillMngPg);
            this.bunifuPages1.Controls.Add(this.UserInfo);
            this.bunifuPages1.Controls.Add(this.DashboardPg);
            this.bunifuPages1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPages1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPages1.Multiline = true;
            this.bunifuPages1.Name = "bunifuPages1";
            this.bunifuPages1.Page = this.UserInfo;
            this.bunifuPages1.PageIndex = 3;
            this.bunifuPages1.PageName = "UserInfo";
            this.bunifuPages1.PageTitle = "User Info";
            this.bunifuPages1.SelectedIndex = 0;
            this.bunifuPages1.Size = new System.Drawing.Size(753, 513);
            this.bunifuPages1.TabIndex = 0;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuPages1.Transition = animation1;
            this.bunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // productTypePg
            // 
            this.productTypePg.AutoScroll = true;
            this.productTypePg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.productTypePg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.productTypePg.Location = new System.Drawing.Point(4, 4);
            this.productTypePg.Name = "productTypePg";
            this.productTypePg.Padding = new System.Windows.Forms.Padding(3);
            this.productTypePg.Size = new System.Drawing.Size(745, 487);
            this.productTypePg.TabIndex = 0;
            this.productTypePg.Text = "ProductType";
            // 
            // StatisticPg
            // 
            this.StatisticPg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.StatisticPg.Location = new System.Drawing.Point(4, 4);
            this.StatisticPg.Name = "StatisticPg";
            this.StatisticPg.Padding = new System.Windows.Forms.Padding(3);
            this.StatisticPg.Size = new System.Drawing.Size(745, 487);
            this.StatisticPg.TabIndex = 3;
            this.StatisticPg.Text = "Statistic";
            // 
            // BillMngPg
            // 
            this.BillMngPg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.BillMngPg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BillMngPg.Location = new System.Drawing.Point(4, 4);
            this.BillMngPg.Name = "BillMngPg";
            this.BillMngPg.Padding = new System.Windows.Forms.Padding(3);
            this.BillMngPg.Size = new System.Drawing.Size(745, 487);
            this.BillMngPg.TabIndex = 4;
            this.BillMngPg.Text = "Bill Mng";
            // 
            // UserInfo
            // 
            this.UserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.UserInfo.Location = new System.Drawing.Point(4, 4);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.UserInfo.Size = new System.Drawing.Size(745, 487);
            this.UserInfo.TabIndex = 5;
            this.UserInfo.Text = "User Info";
            // 
            // DashboardPg
            // 
            this.DashboardPg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.DashboardPg.Location = new System.Drawing.Point(4, 4);
            this.DashboardPg.Name = "DashboardPg";
            this.DashboardPg.Padding = new System.Windows.Forms.Padding(3);
            this.DashboardPg.Size = new System.Drawing.Size(745, 487);
            this.DashboardPg.TabIndex = 6;
            this.DashboardPg.Text = "Dashboard";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(953, 536);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SW";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullScreenBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.bunifuPages1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton InfoBtn;
        private Bunifu.UI.WinForms.BunifuPages bunifuPages1;
        private Bunifu.Framework.UI.BunifuImageButton MinimizeBtn;
        private Bunifu.Framework.UI.BunifuImageButton FullScreenBtn;
        private Bunifu.Framework.UI.BunifuImageButton ExitBtn;
        private System.Windows.Forms.TabPage productTypePg;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel activeBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage StatisticPg;
        private System.Windows.Forms.TabPage BillMngPg;
        private System.Windows.Forms.TabPage UserInfo;
        private System.Windows.Forms.TabPage DashboardPg;
    }
}

