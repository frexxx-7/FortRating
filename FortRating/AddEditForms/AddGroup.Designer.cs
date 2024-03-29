﻿namespace FortRating.AddEditForms
{
    partial class AddGroup
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
            this.headPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.NameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddGroupButton = new Guna.UI2.WinForms.Guna2Button();
            this.CanceledButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.YearComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SpecialityTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.headPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.Controls.Add(this.guna2ControlBox1);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(903, 40);
            this.headPanel.TabIndex = 7;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(857, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 33);
            this.guna2ControlBox1.TabIndex = 1;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.headPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTextBox.DefaultText = "";
            this.NameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTextBox.Location = new System.Drawing.Point(96, 138);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.PlaceholderText = "Название группы";
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.Size = new System.Drawing.Size(717, 36);
            this.NameTextBox.TabIndex = 10;
            // 
            // AddGroupButton
            // 
            this.AddGroupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddGroupButton.BorderRadius = 5;
            this.AddGroupButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddGroupButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddGroupButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddGroupButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddGroupButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddGroupButton.ForeColor = System.Drawing.Color.White;
            this.AddGroupButton.Location = new System.Drawing.Point(21, 467);
            this.AddGroupButton.Name = "AddGroupButton";
            this.AddGroupButton.Size = new System.Drawing.Size(143, 41);
            this.AddGroupButton.TabIndex = 17;
            this.AddGroupButton.Text = "Добавить";
            this.AddGroupButton.Click += new System.EventHandler(this.AddGroupButton_Click);
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
            this.CanceledButton.Location = new System.Drawing.Point(748, 482);
            this.CanceledButton.Name = "CanceledButton";
            this.CanceledButton.Size = new System.Drawing.Size(143, 41);
            this.CanceledButton.TabIndex = 18;
            this.CanceledButton.Text = "Отмена";
            this.CanceledButton.Click += new System.EventHandler(this.CanceledButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(298, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "Добавить группу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(91, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Год:";
            // 
            // YearComboBox
            // 
            this.YearComboBox.BackColor = System.Drawing.Color.Transparent;
            this.YearComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.YearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.YearComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.YearComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.YearComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.YearComboBox.ItemHeight = 30;
            this.YearComboBox.Items.AddRange(new object[] {
            "2017/2018",
            "2018/2019",
            "2019/2020",
            "2020/2021",
            "2021/2022",
            "2022/2023",
            "2023/2024"});
            this.YearComboBox.Location = new System.Drawing.Point(183, 209);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(630, 36);
            this.YearComboBox.TabIndex = 21;
            // 
            // SpecialityTextBox
            // 
            this.SpecialityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SpecialityTextBox.DefaultText = "";
            this.SpecialityTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SpecialityTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SpecialityTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SpecialityTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SpecialityTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SpecialityTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SpecialityTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SpecialityTextBox.Location = new System.Drawing.Point(96, 313);
            this.SpecialityTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SpecialityTextBox.Name = "SpecialityTextBox";
            this.SpecialityTextBox.PasswordChar = '\0';
            this.SpecialityTextBox.PlaceholderText = "Специальность";
            this.SpecialityTextBox.SelectedText = "";
            this.SpecialityTextBox.Size = new System.Drawing.Size(717, 36);
            this.SpecialityTextBox.TabIndex = 22;
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 535);
            this.Controls.Add(this.SpecialityTextBox);
            this.Controls.Add(this.YearComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CanceledButton);
            this.Controls.Add(this.AddGroupButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddGroup";
            this.Load += new System.EventHandler(this.AddGroup_Load);
            this.headPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel headPanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox NameTextBox;
        private Guna.UI2.WinForms.Guna2Button CanceledButton;
        private Guna.UI2.WinForms.Guna2Button AddGroupButton;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox SpecialityTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox YearComboBox;
        private System.Windows.Forms.Label label2;
    }
}