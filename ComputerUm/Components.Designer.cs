namespace ComputerUm
{
    partial class Components
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
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ComponentsDataGridView = new System.Windows.Forms.DataGridView();
            this.idDocrors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ComponentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Location = new System.Drawing.Point(916, 413);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(366, 22);
            this.SearchTextBox.TabIndex = 29;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(793, 403);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(117, 41);
            this.SearchButton.TabIndex = 28;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(312, 413);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(117, 41);
            this.DeleteButton.TabIndex = 27;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(157, 413);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(117, 41);
            this.EditButton.TabIndex = 26;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(12, 413);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(117, 41);
            this.AddButton.TabIndex = 25;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ComponentsDataGridView
            // 
            this.ComponentsDataGridView.AllowUserToAddRows = false;
            this.ComponentsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ComponentsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ComponentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComponentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ComponentsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ComponentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComponentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDocrors,
            this.NameColumn,
            this.SerialNumber,
            this.State});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ComponentsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ComponentsDataGridView.Location = new System.Drawing.Point(12, 80);
            this.ComponentsDataGridView.Name = "ComponentsDataGridView";
            this.ComponentsDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ComponentsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ComponentsDataGridView.RowTemplate.Height = 24;
            this.ComponentsDataGridView.Size = new System.Drawing.Size(1270, 298);
            this.ComponentsDataGridView.TabIndex = 24;
            // 
            // idDocrors
            // 
            this.idDocrors.HeaderText = "id";
            this.idDocrors.MinimumWidth = 6;
            this.idDocrors.Name = "idDocrors";
            this.idDocrors.Visible = false;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Название";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            // 
            // SerialNumber
            // 
            this.SerialNumber.HeaderText = "Серийный номер";
            this.SerialNumber.MinimumWidth = 6;
            this.SerialNumber.Name = "SerialNumber";
            // 
            // State
            // 
            this.State.HeaderText = "Состояние";
            this.State.MinimumWidth = 6;
            this.State.Name = "State";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateButton.Location = new System.Drawing.Point(167, 18);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(117, 41);
            this.UpdateButton.TabIndex = 23;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(12, 18);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(117, 41);
            this.BackButton.TabIndex = 22;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(533, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Комплектующие";
            // 
            // OutputButton
            // 
            this.OutputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputButton.Location = new System.Drawing.Point(458, 413);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(117, 41);
            this.OutputButton.TabIndex = 41;
            this.OutputButton.Text = "Вывод";
            this.OutputButton.UseVisualStyleBackColor = true;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // Components
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1306, 466);
            this.Controls.Add(this.OutputButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ComponentsDataGridView);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label1);
            this.Name = "Components";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Комплектующие";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Components_FormClosed);
            this.Load += new System.EventHandler(this.Components_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComponentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView ComponentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocrors;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OutputButton;
    }
}