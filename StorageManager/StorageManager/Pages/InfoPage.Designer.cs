namespace StorageManager.Pages
{
    partial class InfoPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoPage));
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.idTb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.phoneTb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.emailTb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.nameTb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel13.SuspendLayout();
            this.panel15.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel13
            // 
            this.panel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel13.Controls.Add(this.panel15);
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Location = new System.Drawing.Point(142, 6);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(460, 475);
            this.panel13.TabIndex = 1;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel15.Controls.Add(this.tableLayoutPanel2);
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(0, 152);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(460, 323);
            this.panel15.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.idTb, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.phoneTb, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.emailTb, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.nameTb, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(460, 181);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // idTb
            // 
            this.idTb.BorderColorFocused = System.Drawing.Color.Blue;
            this.idTb.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.idTb.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.idTb.BorderThickness = 3;
            this.idTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.idTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.idTb.ForeColor = System.Drawing.Color.White;
            this.idTb.isPassword = false;
            this.idTb.Location = new System.Drawing.Point(234, 94);
            this.idTb.Margin = new System.Windows.Forms.Padding(4);
            this.idTb.MaxLength = 32767;
            this.idTb.Name = "idTb";
            this.idTb.Size = new System.Drawing.Size(200, 44);
            this.idTb.TabIndex = 3;
            this.idTb.Text = "Id";
            this.idTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // phoneTb
            // 
            this.phoneTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTb.BorderColorFocused = System.Drawing.Color.Blue;
            this.phoneTb.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.phoneTb.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.phoneTb.BorderThickness = 3;
            this.phoneTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.phoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.phoneTb.ForeColor = System.Drawing.Color.White;
            this.phoneTb.isPassword = false;
            this.phoneTb.Location = new System.Drawing.Point(26, 94);
            this.phoneTb.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTb.MaxLength = 32767;
            this.phoneTb.Name = "phoneTb";
            this.phoneTb.Size = new System.Drawing.Size(200, 44);
            this.phoneTb.TabIndex = 2;
            this.phoneTb.Text = "Phone";
            this.phoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // emailTb
            // 
            this.emailTb.BorderColorFocused = System.Drawing.Color.Blue;
            this.emailTb.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.emailTb.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.emailTb.BorderThickness = 3;
            this.emailTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.emailTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailTb.ForeColor = System.Drawing.Color.White;
            this.emailTb.isPassword = false;
            this.emailTb.Location = new System.Drawing.Point(234, 4);
            this.emailTb.Margin = new System.Windows.Forms.Padding(4);
            this.emailTb.MaxLength = 32767;
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(200, 44);
            this.emailTb.TabIndex = 1;
            this.emailTb.Text = "Email";
            this.emailTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // nameTb
            // 
            this.nameTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTb.BorderColorFocused = System.Drawing.Color.Blue;
            this.nameTb.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.nameTb.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.nameTb.BorderThickness = 3;
            this.nameTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nameTb.ForeColor = System.Drawing.Color.White;
            this.nameTb.isPassword = false;
            this.nameTb.Location = new System.Drawing.Point(26, 4);
            this.nameTb.Margin = new System.Windows.Forms.Padding(4);
            this.nameTb.MaxLength = 32767;
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(200, 44);
            this.nameTb.TabIndex = 0;
            this.nameTb.Text = "Name";
            this.nameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel16.Location = new System.Drawing.Point(0, 256);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(460, 67);
            this.panel16.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel14.Controls.Add(this.bunifuPictureBox2);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(460, 152);
            this.panel14.TabIndex = 1;
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuPictureBox2.BorderRadius = 50;
            this.bunifuPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox2.Image")));
            this.bunifuPictureBox2.IsCircle = true;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(178, 6);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(104, 104);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 1;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // InfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.panel13);
            this.Name = "InfoPage";
            this.Size = new System.Drawing.Size(745, 487);
            this.Load += new System.EventHandler(this.InfoPage_Load);
            this.panel13.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox idTb;
        private Bunifu.Framework.UI.BunifuMetroTextbox phoneTb;
        private Bunifu.Framework.UI.BunifuMetroTextbox emailTb;
        private Bunifu.Framework.UI.BunifuMetroTextbox nameTb;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel14;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
    }
}
