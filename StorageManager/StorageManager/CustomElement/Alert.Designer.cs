namespace StorageManager.CustomElement
{
    partial class Alert
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
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation2 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alert));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.alertText = new Bunifu.UI.WinForms.BunifuLabel();
            this.alertGif = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.confirm = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertGif)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            this.bunifuTransition1.MaxAnimationTime = 1000;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Controls.Add(this.alertGif);
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(320, 200);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.alertText);
            this.bunifuTransition1.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 79);
            this.panel1.TabIndex = 7;
            // 
            // alertText
            // 
            this.alertText.AutoEllipsis = false;
            this.alertText.AutoSize = false;
            this.alertText.CursorType = null;
            this.bunifuTransition1.SetDecoration(this.alertText, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.alertText.Dock = System.Windows.Forms.DockStyle.Top;
            this.alertText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.alertText.Location = new System.Drawing.Point(0, 0);
            this.alertText.Name = "alertText";
            this.alertText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.alertText.Size = new System.Drawing.Size(318, 19);
            this.alertText.TabIndex = 0;
            this.alertText.Text = "Text Here";
            this.alertText.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.alertText.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // alertGif
            // 
            this.alertGif.AllowFocused = false;
            this.alertGif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alertGif.BorderRadius = 0;
            this.bunifuTransition1.SetDecoration(this.alertGif, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.alertGif.Image = ((System.Drawing.Image)(resources.GetObject("alertGif.Image")));
            this.alertGif.IsCircle = false;
            this.alertGif.Location = new System.Drawing.Point(108, 0);
            this.alertGif.Name = "alertGif";
            this.alertGif.Size = new System.Drawing.Size(98, 98);
            this.alertGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alertGif.TabIndex = 6;
            this.alertGif.TabStop = false;
            this.alertGif.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.confirm);
            this.bunifuTransition1.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 49);
            this.panel2.TabIndex = 1;
            // 
            // confirm
            // 
            this.confirm.AllowToggling = false;
            this.confirm.AnimationSpeed = 200;
            this.confirm.AutoGenerateColors = false;
            this.confirm.BackColor = System.Drawing.Color.Transparent;
            this.confirm.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.confirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirm.BackgroundImage")));
            this.confirm.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.confirm.ButtonText = "Confirm";
            this.confirm.ButtonTextMarginLeft = 0;
            this.confirm.ColorContrastOnClick = 45;
            this.confirm.ColorContrastOnHover = 45;
            this.confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.confirm.CustomizableEdges = borderEdges2;
            this.bunifuTransition1.SetDecoration(this.confirm, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.confirm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.confirm.DisabledBorderColor = System.Drawing.Color.Empty;
            this.confirm.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.confirm.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.confirm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.confirm.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.confirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.confirm.ForeColor = System.Drawing.Color.White;
            this.confirm.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.confirm.IconMarginLeft = 11;
            this.confirm.IconPadding = 10;
            this.confirm.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.confirm.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.confirm.IdleBorderRadius = 3;
            this.confirm.IdleBorderThickness = 1;
            this.confirm.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.confirm.IdleIconLeftImage = null;
            this.confirm.IdleIconRightImage = null;
            this.confirm.IndicateFocus = false;
            this.confirm.Location = new System.Drawing.Point(0, 13);
            this.confirm.Name = "confirm";
            this.confirm.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.confirm.onHoverState.BorderRadius = 3;
            this.confirm.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.confirm.onHoverState.BorderThickness = 1;
            this.confirm.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.confirm.onHoverState.ForeColor = System.Drawing.Color.White;
            this.confirm.onHoverState.IconLeftImage = null;
            this.confirm.onHoverState.IconRightImage = null;
            this.confirm.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.confirm.OnIdleState.BorderRadius = 3;
            this.confirm.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.confirm.OnIdleState.BorderThickness = 1;
            this.confirm.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.confirm.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.confirm.OnIdleState.IconLeftImage = null;
            this.confirm.OnIdleState.IconRightImage = null;
            this.confirm.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.confirm.OnPressedState.BorderRadius = 3;
            this.confirm.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.confirm.OnPressedState.BorderThickness = 1;
            this.confirm.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.confirm.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.confirm.OnPressedState.IconLeftImage = null;
            this.confirm.OnPressedState.IconRightImage = null;
            this.confirm.Size = new System.Drawing.Size(318, 36);
            this.confirm.TabIndex = 2;
            this.confirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.confirm.TextMarginLeft = 0;
            this.confirm.UseDefaultRadiusAndThickness = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 200);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alert";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Alert_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alertGif)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton confirm;
        private Bunifu.UI.WinForms.BunifuLabel alertText;
        private Bunifu.UI.WinForms.BunifuPictureBox alertGif;
    }
}