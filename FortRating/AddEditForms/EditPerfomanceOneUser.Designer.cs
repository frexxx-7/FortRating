﻿namespace FortRating.Forms.Admin
{
    partial class EditPerfomanceOneUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PerfomanceDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.AddDisciplines = new Guna.UI2.WinForms.Guna2Button();
            this.EditMark = new Guna.UI2.WinForms.Guna2Button();
            this.idDesciplinesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discipline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PerfomanceDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(676, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Редактировать успеваемость учащегося:";
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOLabel.Location = new System.Drawing.Point(754, 9);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(97, 39);
            this.FIOLabel.TabIndex = 8;
            this.FIOLabel.Text = "ФИО";
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupLabel.Location = new System.Drawing.Point(216, 75);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(129, 39);
            this.GroupLabel.TabIndex = 11;
            this.GroupLabel.Text = "Группа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 39);
            this.label2.TabIndex = 10;
            this.label2.Text = "Группа:";
            // 
            // PerfomanceDataGrid
            // 
            this.PerfomanceDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PerfomanceDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PerfomanceDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PerfomanceDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PerfomanceDataGrid.ColumnHeadersHeight = 40;
            this.PerfomanceDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDesciplinesColumn,
            this.Discipline,
            this.Mark});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PerfomanceDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.PerfomanceDataGrid.GridColor = System.Drawing.Color.White;
            this.PerfomanceDataGrid.Location = new System.Drawing.Point(19, 134);
            this.PerfomanceDataGrid.Name = "PerfomanceDataGrid";
            this.PerfomanceDataGrid.ReadOnly = true;
            this.PerfomanceDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PerfomanceDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PerfomanceDataGrid.RowHeadersVisible = false;
            this.PerfomanceDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.PerfomanceDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.PerfomanceDataGrid.RowTemplate.Height = 24;
            this.PerfomanceDataGrid.Size = new System.Drawing.Size(972, 379);
            this.PerfomanceDataGrid.TabIndex = 12;
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
            // AddDisciplines
            // 
            this.AddDisciplines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddDisciplines.BorderRadius = 5;
            this.AddDisciplines.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddDisciplines.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddDisciplines.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddDisciplines.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddDisciplines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddDisciplines.ForeColor = System.Drawing.Color.White;
            this.AddDisciplines.Location = new System.Drawing.Point(19, 541);
            this.AddDisciplines.Name = "AddDisciplines";
            this.AddDisciplines.Size = new System.Drawing.Size(277, 42);
            this.AddDisciplines.TabIndex = 13;
            this.AddDisciplines.Text = "Добавить дисциплину";
            this.AddDisciplines.Click += new System.EventHandler(this.AddDisciplines_Click);
            // 
            // EditMark
            // 
            this.EditMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditMark.BorderRadius = 5;
            this.EditMark.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditMark.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditMark.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditMark.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditMark.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditMark.ForeColor = System.Drawing.Color.White;
            this.EditMark.Location = new System.Drawing.Point(440, 541);
            this.EditMark.Name = "EditMark";
            this.EditMark.Size = new System.Drawing.Size(224, 42);
            this.EditMark.TabIndex = 14;
            this.EditMark.Text = "Изменить отметку";
            this.EditMark.Click += new System.EventHandler(this.EditMark_Click);
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
            // EditPerfomanceOneUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 634);
            this.Controls.Add(this.EditMark);
            this.Controls.Add(this.AddDisciplines);
            this.Controls.Add(this.PerfomanceDataGrid);
            this.Controls.Add(this.GroupLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FIOLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditPerfomanceOneUser";
            this.Text = "EditPerfomanceOneUser";
            this.Load += new System.EventHandler(this.EditPerfomanceOneUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PerfomanceDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView PerfomanceDataGrid;
        private Guna.UI2.WinForms.Guna2Button AddDisciplines;
        private Guna.UI2.WinForms.Guna2Button EditMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDesciplinesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discipline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
    }
}