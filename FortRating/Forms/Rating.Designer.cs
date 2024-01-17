namespace FortRating.Forms
{
    partial class Rating
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PlaceInRatingLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RatingDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PlaceInRatingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIOStudentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ReportButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.RatingDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PlaceInRatingLabel
            // 
            this.PlaceInRatingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlaceInRatingLabel.AutoSize = true;
            this.PlaceInRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaceInRatingLabel.Location = new System.Drawing.Point(327, 484);
            this.PlaceInRatingLabel.Name = "PlaceInRatingLabel";
            this.PlaceInRatingLabel.Size = new System.Drawing.Size(218, 29);
            this.PlaceInRatingLabel.TabIndex = 23;
            this.PlaceInRatingLabel.Text = "Место в рейтинге";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "Место в рейтинге:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(381, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 39);
            this.label1.TabIndex = 24;
            this.label1.Text = "Рейтинг";
            // 
            // RatingDataGrid
            // 
            this.RatingDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RatingDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RatingDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RatingDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RatingDataGrid.ColumnHeadersHeight = 40;
            this.RatingDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlaceInRatingColumn,
            this.FIOStudentColumn,
            this.PointsColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RatingDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.RatingDataGrid.GridColor = System.Drawing.Color.White;
            this.RatingDataGrid.Location = new System.Drawing.Point(33, 126);
            this.RatingDataGrid.Name = "RatingDataGrid";
            this.RatingDataGrid.ReadOnly = true;
            this.RatingDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RatingDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.RatingDataGrid.RowHeadersVisible = false;
            this.RatingDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.RatingDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.RatingDataGrid.RowTemplate.Height = 24;
            this.RatingDataGrid.Size = new System.Drawing.Size(835, 298);
            this.RatingDataGrid.TabIndex = 25;
            this.RatingDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RatingDataGrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RatingDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RatingDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RatingDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RatingDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RatingDataGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.RatingDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RatingDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RatingDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RatingDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RatingDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RatingDataGrid.ThemeStyle.HeaderStyle.Height = 40;
            this.RatingDataGrid.ThemeStyle.ReadOnly = true;
            this.RatingDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RatingDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RatingDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RatingDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RatingDataGrid.ThemeStyle.RowsStyle.Height = 24;
            this.RatingDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RatingDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // PlaceInRatingColumn
            // 
            this.PlaceInRatingColumn.HeaderText = "Место в рейтинге";
            this.PlaceInRatingColumn.MinimumWidth = 6;
            this.PlaceInRatingColumn.Name = "PlaceInRatingColumn";
            this.PlaceInRatingColumn.ReadOnly = true;
            // 
            // FIOStudentColumn
            // 
            this.FIOStudentColumn.HeaderText = "ФИО";
            this.FIOStudentColumn.MinimumWidth = 6;
            this.FIOStudentColumn.Name = "FIOStudentColumn";
            this.FIOStudentColumn.ReadOnly = true;
            // 
            // PointsColumn
            // 
            this.PointsColumn.HeaderText = "Кол-во баллов";
            this.PointsColumn.MinimumWidth = 6;
            this.PointsColumn.Name = "PointsColumn";
            this.PointsColumn.ReadOnly = true;
            // 
            // GroupComboBox
            // 
            this.GroupComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupComboBox.BackColor = System.Drawing.Color.Transparent;
            this.GroupComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GroupComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GroupComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GroupComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.GroupComboBox.ItemHeight = 30;
            this.GroupComboBox.Location = new System.Drawing.Point(618, 22);
            this.GroupComboBox.Name = "GroupComboBox";
            this.GroupComboBox.Size = new System.Drawing.Size(265, 36);
            this.GroupComboBox.TabIndex = 26;
            this.GroupComboBox.SelectedValueChanged += new System.EventHandler(this.GroupComboBox_SelectedValueChanged);
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Location = new System.Drawing.Point(787, 67);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(103, 20);
            this.guna2CheckBox1.TabIndex = 33;
            this.guna2CheckBox1.Text = "Все группы";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged_1);
            // 
            // ReportButton
            // 
            this.ReportButton.BorderRadius = 5;
            this.ReportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ReportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ReportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ReportButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ReportButton.ForeColor = System.Drawing.Color.White;
            this.ReportButton.Location = new System.Drawing.Point(33, 22);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(144, 45);
            this.ReportButton.TabIndex = 34;
            this.ReportButton.Text = "Отчет";
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // Rating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 533);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.guna2CheckBox1);
            this.Controls.Add(this.GroupComboBox);
            this.Controls.Add(this.RatingDataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlaceInRatingLabel);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rating";
            this.Load += new System.EventHandler(this.Rating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RatingDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlaceInRatingLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView RatingDataGrid;
        private Guna.UI2.WinForms.Guna2ComboBox GroupComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceInRatingColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIOStudentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointsColumn;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2Button ReportButton;
    }
}