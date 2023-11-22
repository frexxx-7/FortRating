namespace FortRating.Forms.Admin
{
    partial class StudentsOnEvent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EventLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentsDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.AddParticipantButton = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.idParticipantColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIOStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EventLabel
            // 
            this.EventLabel.AutoSize = true;
            this.EventLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EventLabel.Location = new System.Drawing.Point(270, 9);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(231, 39);
            this.EventLabel.TabIndex = 11;
            this.EventLabel.Text = "Мероприятие";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Мероприятие:";
            // 
            // StudentsDataGrid
            // 
            this.StudentsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StudentsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.StudentsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.StudentsDataGrid.ColumnHeadersHeight = 40;
            this.StudentsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idParticipantColumn,
            this.FIOStudent});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentsDataGrid.DefaultCellStyle = dataGridViewCellStyle13;
            this.StudentsDataGrid.GridColor = System.Drawing.Color.White;
            this.StudentsDataGrid.Location = new System.Drawing.Point(12, 81);
            this.StudentsDataGrid.Name = "StudentsDataGrid";
            this.StudentsDataGrid.ReadOnly = true;
            this.StudentsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.StudentsDataGrid.RowHeadersVisible = false;
            this.StudentsDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            this.StudentsDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.StudentsDataGrid.RowTemplate.Height = 24;
            this.StudentsDataGrid.Size = new System.Drawing.Size(934, 421);
            this.StudentsDataGrid.TabIndex = 14;
            this.StudentsDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.StudentsDataGrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentsDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StudentsDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StudentsDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StudentsDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.StudentsDataGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.StudentsDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.StudentsDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.StudentsDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentsDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StudentsDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StudentsDataGrid.ThemeStyle.HeaderStyle.Height = 40;
            this.StudentsDataGrid.ThemeStyle.ReadOnly = true;
            this.StudentsDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StudentsDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StudentsDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentsDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StudentsDataGrid.ThemeStyle.RowsStyle.Height = 24;
            this.StudentsDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StudentsDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // AddParticipantButton
            // 
            this.AddParticipantButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddParticipantButton.BorderRadius = 5;
            this.AddParticipantButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddParticipantButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddParticipantButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddParticipantButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddParticipantButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddParticipantButton.ForeColor = System.Drawing.Color.White;
            this.AddParticipantButton.Location = new System.Drawing.Point(12, 543);
            this.AddParticipantButton.Name = "AddParticipantButton";
            this.AddParticipantButton.Size = new System.Drawing.Size(246, 41);
            this.AddParticipantButton.TabIndex = 17;
            this.AddParticipantButton.Text = "Добавить участника";
            this.AddParticipantButton.Click += new System.EventHandler(this.AddParticipantButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.BorderRadius = 5;
            this.DeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(277, 543);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(148, 41);
            this.DeleteButton.TabIndex = 18;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // idParticipantColumn
            // 
            this.idParticipantColumn.HeaderText = "Код участника";
            this.idParticipantColumn.MinimumWidth = 6;
            this.idParticipantColumn.Name = "idParticipantColumn";
            this.idParticipantColumn.ReadOnly = true;
            this.idParticipantColumn.Visible = false;
            // 
            // FIOStudent
            // 
            this.FIOStudent.HeaderText = "ФИО студента";
            this.FIOStudent.MinimumWidth = 6;
            this.FIOStudent.Name = "FIOStudent";
            this.FIOStudent.ReadOnly = true;
            // 
            // StudentsOnEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 596);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddParticipantButton);
            this.Controls.Add(this.StudentsDataGrid);
            this.Controls.Add(this.EventLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentsOnEvent";
            this.Text = "StudentsOnEvent";
            this.Load += new System.EventHandler(this.StudentsOnEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EventLabel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView StudentsDataGrid;
        private Guna.UI2.WinForms.Guna2Button AddParticipantButton;
        private Guna.UI2.WinForms.Guna2Button DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idParticipantColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIOStudent;
    }
}