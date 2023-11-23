namespace FortRating.Forms.Admin
{
    partial class PerfomanceOneStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.PerfomanceDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idDesciplinesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discipline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionalButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.PerfomanceDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Успеваемость учащегося:";
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOLabel.Location = new System.Drawing.Point(546, 20);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(97, 39);
            this.FIOLabel.TabIndex = 7;
            this.FIOLabel.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Группа:";
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupLabel.Location = new System.Drawing.Point(216, 99);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(129, 39);
            this.GroupLabel.TabIndex = 9;
            this.GroupLabel.Text = "Группа";
            // 
            // PerfomanceDataGrid
            // 
            this.PerfomanceDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PerfomanceDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.PerfomanceDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PerfomanceDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.PerfomanceDataGrid.ColumnHeadersHeight = 40;
            this.PerfomanceDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDesciplinesColumn,
            this.Discipline,
            this.Mark});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PerfomanceDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.PerfomanceDataGrid.GridColor = System.Drawing.Color.White;
            this.PerfomanceDataGrid.Location = new System.Drawing.Point(19, 169);
            this.PerfomanceDataGrid.Name = "PerfomanceDataGrid";
            this.PerfomanceDataGrid.ReadOnly = true;
            this.PerfomanceDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PerfomanceDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.PerfomanceDataGrid.RowHeadersVisible = false;
            this.PerfomanceDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.PerfomanceDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.PerfomanceDataGrid.RowTemplate.Height = 24;
            this.PerfomanceDataGrid.Size = new System.Drawing.Size(972, 345);
            this.PerfomanceDataGrid.TabIndex = 13;
            this.PerfomanceDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PerfomanceDataGrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PerfomanceDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PerfomanceDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PerfomanceDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PerfomanceDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PerfomanceDataGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.PerfomanceDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PerfomanceDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PerfomanceDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PerfomanceDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PerfomanceDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PerfomanceDataGrid.ThemeStyle.HeaderStyle.Height = 40;
            this.PerfomanceDataGrid.ThemeStyle.ReadOnly = true;
            this.PerfomanceDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PerfomanceDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PerfomanceDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PerfomanceDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PerfomanceDataGrid.ThemeStyle.RowsStyle.Height = 24;
            this.PerfomanceDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PerfomanceDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idDesciplinesColumn
            // 
            this.idDesciplinesColumn.HeaderText = "Код дисциплины";
            this.idDesciplinesColumn.MinimumWidth = 6;
            this.idDesciplinesColumn.Name = "idDesciplinesColumn";
            this.idDesciplinesColumn.ReadOnly = true;
            this.idDesciplinesColumn.Visible = false;
            // 
            // Discipline
            // 
            this.Discipline.HeaderText = "Дисциплина";
            this.Discipline.MinimumWidth = 6;
            this.Discipline.Name = "Discipline";
            this.Discipline.ReadOnly = true;
            // 
            // Mark
            // 
            this.Mark.HeaderText = "Отметка";
            this.Mark.MinimumWidth = 6;
            this.Mark.Name = "Mark";
            this.Mark.ReadOnly = true;
            // 
            // AdditionalButton
            // 
            this.AdditionalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AdditionalButton.BorderRadius = 5;
            this.AdditionalButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AdditionalButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AdditionalButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AdditionalButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AdditionalButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AdditionalButton.ForeColor = System.Drawing.Color.White;
            this.AdditionalButton.Location = new System.Drawing.Point(19, 535);
            this.AdditionalButton.Name = "AdditionalButton";
            this.AdditionalButton.Size = new System.Drawing.Size(280, 42);
            this.AdditionalButton.TabIndex = 14;
            this.AdditionalButton.Text = "Дополнительные баллы";
            this.AdditionalButton.Click += new System.EventHandler(this.AdditionalButton_Click);
            // 
            // PerfomanceOneStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 589);
            this.Controls.Add(this.AdditionalButton);
            this.Controls.Add(this.PerfomanceDataGrid);
            this.Controls.Add(this.GroupLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FIOLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PerfomanceOneStudent";
            this.Text = "PerfomanceOneStudent";
            this.Load += new System.EventHandler(this.PerfomanceOneStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PerfomanceDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label GroupLabel;
        private Guna.UI2.WinForms.Guna2DataGridView PerfomanceDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDesciplinesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discipline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
        private Guna.UI2.WinForms.Guna2Button AdditionalButton;
    }
}