namespace FortRating.AddEditForms
{
    partial class EditMark
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameDisciplineLabel = new System.Windows.Forms.Label();
            this.MarkTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SaveButton = new Guna.UI2.WinForms.Guna2Button();
            this.headPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.headPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(253, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Изменить отметку";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дисциплина:";
            // 
            // NameDisciplineLabel
            // 
            this.NameDisciplineLabel.AutoSize = true;
            this.NameDisciplineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameDisciplineLabel.Location = new System.Drawing.Point(223, 130);
            this.NameDisciplineLabel.Name = "NameDisciplineLabel";
            this.NameDisciplineLabel.Size = new System.Drawing.Size(157, 29);
            this.NameDisciplineLabel.TabIndex = 6;
            this.NameDisciplineLabel.Text = "Дисциплина";
            // 
            // MarkTextBox
            // 
            this.MarkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MarkTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MarkTextBox.DefaultText = "";
            this.MarkTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MarkTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MarkTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MarkTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MarkTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MarkTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MarkTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MarkTextBox.Location = new System.Drawing.Point(28, 206);
            this.MarkTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MarkTextBox.Name = "MarkTextBox";
            this.MarkTextBox.PasswordChar = '\0';
            this.MarkTextBox.PlaceholderText = "Отметка";
            this.MarkTextBox.SelectedText = "";
            this.MarkTextBox.Size = new System.Drawing.Size(761, 40);
            this.MarkTextBox.TabIndex = 7;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveButton.BorderRadius = 5;
            this.SaveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(28, 349);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(159, 42);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // headPanel
            // 
            this.headPanel.Controls.Add(this.guna2ControlBox1);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(821, 40);
            this.headPanel.TabIndex = 15;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(775, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 33);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // EditMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 403);
            this.Controls.Add(this.headPanel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MarkTextBox);
            this.Controls.Add(this.NameDisciplineLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditMark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditMark";
            this.headPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NameDisciplineLabel;
        private Guna.UI2.WinForms.Guna2TextBox MarkTextBox;
        private Guna.UI2.WinForms.Guna2Button SaveButton;
        private Guna.UI2.WinForms.Guna2Panel headPanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}