namespace StorageManager.CustomElement
{
    partial class DeleteAlert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAlert));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.alertText = new Bunifu.UI.WinForms.BunifuLabel();
            this.alertGif = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.denyDe = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.confirmDe = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertGif)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.bunifuGradientPanel1.TabIndex = 1;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.bunifuTransition1.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 49);
            this.panel2.TabIndex = 1;
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
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.confirmDe, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.denyDe, 0, 0);
            this.bunifuTransition1.SetDecoration(this.tableLayoutPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 49);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // denyDe
            // 
            this.denyDe.AllowToggling = false;
            this.denyDe.AnimationSpeed = 200;
            this.denyDe.AutoGenerateColors = false;
            this.denyDe.BackColor = System.Drawing.Color.Transparent;
            this.denyDe.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.denyDe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("denyDe.BackgroundImage")));
            this.denyDe.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.denyDe.ButtonText = "Deny";
            this.denyDe.ButtonTextMarginLeft = 0;
            this.denyDe.ColorContrastOnClick = 45;
            this.denyDe.ColorContrastOnHover = 45;
            this.denyDe.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.denyDe.CustomizableEdges = borderEdges3;
            this.bunifuTransition1.SetDecoration(this.denyDe, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.denyDe.DialogResult = System.Windows.Forms.DialogResult.None;
            this.denyDe.DisabledBorderColor = System.Drawing.Color.Empty;
            this.denyDe.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.denyDe.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.denyDe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.denyDe.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.denyDe.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.denyDe.ForeColor = System.Drawing.Color.White;
            this.denyDe.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.denyDe.IconMarginLeft = 11;
            this.denyDe.IconPadding = 10;
            this.denyDe.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.denyDe.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.denyDe.IdleBorderRadius = 3;
            this.denyDe.IdleBorderThickness = 1;
            this.denyDe.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.denyDe.IdleIconLeftImage = null;
            this.denyDe.IdleIconRightImage = null;
            this.denyDe.IndicateFocus = false;
            this.denyDe.Location = new System.Drawing.Point(3, 10);
            this.denyDe.Name = "denyDe";
            this.denyDe.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.denyDe.onHoverState.BorderRadius = 3;
            this.denyDe.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.denyDe.onHoverState.BorderThickness = 1;
            this.denyDe.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.denyDe.onHoverState.ForeColor = System.Drawing.Color.White;
            this.denyDe.onHoverState.IconLeftImage = null;
            this.denyDe.onHoverState.IconRightImage = null;
            this.denyDe.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.denyDe.OnIdleState.BorderRadius = 3;
            this.denyDe.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.denyDe.OnIdleState.BorderThickness = 1;
            this.denyDe.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.denyDe.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.denyDe.OnIdleState.IconLeftImage = null;
            this.denyDe.OnIdleState.IconRightImage = null;
            this.denyDe.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.denyDe.OnPressedState.BorderRadius = 3;
            this.denyDe.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.denyDe.OnPressedState.BorderThickness = 1;
            this.denyDe.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.denyDe.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.denyDe.OnPressedState.IconLeftImage = null;
            this.denyDe.OnPressedState.IconRightImage = null;
            this.denyDe.Size = new System.Drawing.Size(153, 36);
            this.denyDe.TabIndex = 3;
            this.denyDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.denyDe.TextMarginLeft = 0;
            this.denyDe.UseDefaultRadiusAndThickness = true;
            this.denyDe.Click += new System.EventHandler(this.denyDe_Click);
            // 
            // confirmDe
            // 
            this.confirmDe.AllowToggling = false;
            this.confirmDe.AnimationSpeed = 200;
            this.confirmDe.AutoGenerateColors = false;
            this.confirmDe.BackColor = System.Drawing.Color.Transparent;
            this.confirmDe.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.confirmDe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmDe.BackgroundImage")));
            this.confirmDe.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.confirmDe.ButtonText = "Confirm";
            this.confirmDe.ButtonTextMarginLeft = 0;
            this.confirmDe.ColorContrastOnClick = 45;
            this.confirmDe.ColorContrastOnHover = 45;
            this.confirmDe.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.confirmDe.CustomizableEdges = borderEdges4;
            this.bunifuTransition1.SetDecoration(this.confirmDe, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.confirmDe.DialogResult = System.Windows.Forms.DialogResult.None;
            this.confirmDe.DisabledBorderColor = System.Drawing.Color.Empty;
            this.confirmDe.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.confirmDe.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.confirmDe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.confirmDe.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.confirmDe.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.confirmDe.ForeColor = System.Drawing.Color.White;
            this.confirmDe.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.confirmDe.IconMarginLeft = 11;
            this.confirmDe.IconPadding = 10;
            this.confirmDe.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.confirmDe.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.confirmDe.IdleBorderRadius = 3;
            this.confirmDe.IdleBorderThickness = 1;
            this.confirmDe.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.confirmDe.IdleIconLeftImage = null;
            this.confirmDe.IdleIconRightImage = null;
            this.confirmDe.IndicateFocus = false;
            this.confirmDe.Location = new System.Drawing.Point(162, 10);
            this.confirmDe.Name = "confirmDe";
            this.confirmDe.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.confirmDe.onHoverState.BorderRadius = 3;
            this.confirmDe.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.confirmDe.onHoverState.BorderThickness = 1;
            this.confirmDe.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.confirmDe.onHoverState.ForeColor = System.Drawing.Color.White;
            this.confirmDe.onHoverState.IconLeftImage = null;
            this.confirmDe.onHoverState.IconRightImage = null;
            this.confirmDe.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.confirmDe.OnIdleState.BorderRadius = 3;
            this.confirmDe.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.confirmDe.OnIdleState.BorderThickness = 1;
            this.confirmDe.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.confirmDe.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.confirmDe.OnIdleState.IconLeftImage = null;
            this.confirmDe.OnIdleState.IconRightImage = null;
            this.confirmDe.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.confirmDe.OnPressedState.BorderRadius = 3;
            this.confirmDe.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.confirmDe.OnPressedState.BorderThickness = 1;
            this.confirmDe.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.confirmDe.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.confirmDe.OnPressedState.IconLeftImage = null;
            this.confirmDe.OnPressedState.IconRightImage = null;
            this.confirmDe.Size = new System.Drawing.Size(153, 36);
            this.confirmDe.TabIndex = 4;
            this.confirmDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.confirmDe.TextMarginLeft = 0;
            this.confirmDe.UseDefaultRadiusAndThickness = true;
            this.confirmDe.Click += new System.EventHandler(this.confirmDe_Click);
            // 
            // DeleteAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 200);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteAlert";
            this.Load += new System.EventHandler(this.DeleteAlert_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alertGif)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuLabel alertText;
        private Bunifu.UI.WinForms.BunifuPictureBox alertGif;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton denyDe;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton confirmDe;
    }
}