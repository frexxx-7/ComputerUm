namespace ComputerUm
{
    partial class Computers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.RequestsDataGridView = new System.Windows.Forms.DataGridView();
            this.idDocrors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfPurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatingSystem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RequestsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(506, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Компьютеры";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(117, 41);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateButton.Location = new System.Drawing.Point(167, 12);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(117, 41);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // RequestsDataGridView
            // 
            this.RequestsDataGridView.AllowUserToAddRows = false;
            this.RequestsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RequestsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.RequestsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RequestsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RequestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RequestsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDocrors,
            this.Model,
            this.DateOfPurchase,
            this.OperatingSystem});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RequestsDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.RequestsDataGridView.Location = new System.Drawing.Point(12, 74);
            this.RequestsDataGridView.Name = "RequestsDataGridView";
            this.RequestsDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RequestsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.RequestsDataGridView.RowTemplate.Height = 24;
            this.RequestsDataGridView.Size = new System.Drawing.Size(1176, 353);
            this.RequestsDataGridView.TabIndex = 15;
            // 
            // idDocrors
            // 
            this.idDocrors.HeaderText = "id";
            this.idDocrors.MinimumWidth = 6;
            this.idDocrors.Name = "idDocrors";
            this.idDocrors.Visible = false;
            // 
            // Model
            // 
            this.Model.HeaderText = "Модель";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            // 
            // DateOfPurchase
            // 
            this.DateOfPurchase.HeaderText = "Дата покупки";
            this.DateOfPurchase.MinimumWidth = 6;
            this.DateOfPurchase.Name = "DateOfPurchase";
            // 
            // OperatingSystem
            // 
            this.OperatingSystem.HeaderText = "Операционная система";
            this.OperatingSystem.MinimumWidth = 6;
            this.OperatingSystem.Name = "OperatingSystem";
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(22, 454);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(117, 41);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(167, 454);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(117, 41);
            this.EditButton.TabIndex = 17;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(322, 454);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(117, 41);
            this.DeleteButton.TabIndex = 18;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(699, 454);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(117, 41);
            this.SearchButton.TabIndex = 19;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Location = new System.Drawing.Point(822, 464);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(366, 22);
            this.SearchTextBox.TabIndex = 20;
            // 
            // Computers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 549);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RequestsDataGridView);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label1);
            this.Name = "Computers";
            this.Text = "Компьютеры";
            ((System.ComponentModel.ISupportInitialize)(this.RequestsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridView RequestsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocrors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperatingSystem;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
    }
}