namespace FortRating.AddEditForms
{
    partial class AddParticipantEvent
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
            this.headPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentsComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.CanceledButton = new Guna.UI2.WinForms.Guna2Button();
            this.headPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.Controls.Add(this.guna2ControlBox1);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(800, 40);
            this.headPanel.TabIndex = 9;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(754, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 33);
            this.guna2ControlBox1.TabIndex = 1;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(139, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 39);
            this.label1.TabIndex = 21;
            this.label1.Text = "Добавить участника мероприятия";
            // 
            // StudentsComboBox
            // 
            this.StudentsComboBox.BackColor = System.Drawing.Color.Transparent;
            this.StudentsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StudentsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentsComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StudentsComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StudentsComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StudentsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.StudentsComboBox.ItemHeight = 30;
            this.StudentsComboBox.Location = new System.Drawing.Point(62, 159);
            this.StudentsComboBox.Name = "StudentsComboBox";
            this.StudentsComboBox.Size = new System.Drawing.Size(662, 36);
            this.StudentsComboBox.TabIndex = 22;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.BorderRadius = 5;
            this.AddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(12, 304);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(143, 41);
            this.AddButton.TabIndex = 23;
            this.AddButton.Text = "Добавить";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CanceledButton
            // 
            this.CanceledButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CanceledButton.BorderRadius = 5;
            this.CanceledButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CanceledButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CanceledButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CanceledButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CanceledButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CanceledButton.ForeColor = System.Drawing.Color.White;
            this.CanceledButton.Location = new System.Drawing.Point(645, 304);
            this.CanceledButton.Name = "CanceledButton";
            this.CanceledButton.Size = new System.Drawing.Size(143, 41);
            this.CanceledButton.TabIndex = 24;
            this.CanceledButton.Text = "Отмена";
            this.CanceledButton.Click += new System.EventHandler(this.CanceledButton_Click);
            // 
            // AddParticipantEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.Controls.Add(this.CanceledButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.StudentsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddParticipantEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddParticipantEvent";
            this.headPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel headPanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox StudentsComboBox;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private Guna.UI2.WinForms.Guna2Button CanceledButton;
    }
}