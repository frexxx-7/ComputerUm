namespace ComputerUm
{
    partial class Main
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
            this.ComputersButton = new System.Windows.Forms.Button();
            this.ComponentsButton = new System.Windows.Forms.Button();
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(244, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Главная";
            // 
            // ComputersButton
            // 
            this.ComputersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComputersButton.Location = new System.Drawing.Point(198, 130);
            this.ComputersButton.Name = "ComputersButton";
            this.ComputersButton.Size = new System.Drawing.Size(201, 41);
            this.ComputersButton.TabIndex = 6;
            this.ComputersButton.Text = "Компьютеры";
            this.ComputersButton.UseVisualStyleBackColor = true;
            this.ComputersButton.Click += new System.EventHandler(this.ComputersButton_Click);
            // 
            // ComponentsButton
            // 
            this.ComponentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComponentsButton.Location = new System.Drawing.Point(198, 229);
            this.ComponentsButton.Name = "ComponentsButton";
            this.ComponentsButton.Size = new System.Drawing.Size(201, 41);
            this.ComponentsButton.TabIndex = 7;
            this.ComponentsButton.Text = "Комплектующие";
            this.ComponentsButton.UseVisualStyleBackColor = true;
            this.ComponentsButton.Click += new System.EventHandler(this.ComponentsButton_Click);
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeesButton.Location = new System.Drawing.Point(198, 333);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(201, 41);
            this.EmployeesButton.TabIndex = 8;
            this.EmployeesButton.Text = "Сотрудники";
            this.EmployeesButton.UseVisualStyleBackColor = true;
            this.EmployeesButton.Click += new System.EventHandler(this.EmployeesButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ComputerUm.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(621, 546);
            this.Controls.Add(this.EmployeesButton);
            this.Controls.Add(this.ComponentsButton);
            this.Controls.Add(this.ComputersButton);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ComputersButton;
        private System.Windows.Forms.Button ComponentsButton;
        private System.Windows.Forms.Button EmployeesButton;
    }
}