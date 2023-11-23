namespace FortRating.UserControls
{
    partial class UsersControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersControl1));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelAvatar = new Guna.UI2.WinForms.Guna2Panel();
            this.avatarPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.panelAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.panelAvatar);
            this.guna2Panel1.Controls.Add(this.flowLayoutPanel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(605, 248);
            this.guna2Panel1.TabIndex = 0;
            // 
            // panelAvatar
            // 
            this.panelAvatar.AutoRoundedCorners = true;
            this.panelAvatar.BorderColor = System.Drawing.Color.Black;
            this.panelAvatar.BorderRadius = 88;
            this.panelAvatar.BorderThickness = 2;
            this.panelAvatar.Controls.Add(this.avatarPicture);
            this.panelAvatar.Location = new System.Drawing.Point(17, 32);
            this.panelAvatar.Name = "panelAvatar";
            this.panelAvatar.Padding = new System.Windows.Forms.Padding(2);
            this.panelAvatar.Size = new System.Drawing.Size(179, 179);
            this.panelAvatar.TabIndex = 10;
            // 
            // avatarPicture
            // 
            this.avatarPicture.AutoRoundedCorners = true;
            this.avatarPicture.BackColor = System.Drawing.Color.Transparent;
            this.avatarPicture.BorderRadius = 86;
            this.avatarPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.avatarPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avatarPicture.Image = ((System.Drawing.Image)(resources.GetObject("avatarPicture.Image")));
            this.avatarPicture.ImageRotate = 0F;
            this.avatarPicture.Location = new System.Drawing.Point(2, 2);
            this.avatarPicture.Name = "avatarPicture";
            this.avatarPicture.Size = new System.Drawing.Size(175, 175);
            this.avatarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPicture.TabIndex = 7;
            this.avatarPicture.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.LoginLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(199, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(381, 78);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(3, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(72, 26);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "Логин";
            this.LoginLabel.Click += new System.EventHandler(this.LoginLabel_Click);
            this.LoginLabel.MouseLeave += new System.EventHandler(this.LoginLabel_MouseLeave);
            this.LoginLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginLabel_MouseMove);
            // 
            // UsersControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UsersControl1";
            this.Size = new System.Drawing.Size(605, 248);
            this.Load += new System.EventHandler(this.UsersControl1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.panelAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LoginLabel;
        private Guna.UI2.WinForms.Guna2Panel panelAvatar;
        private Guna.UI2.WinForms.Guna2PictureBox avatarPicture;
    }
}
