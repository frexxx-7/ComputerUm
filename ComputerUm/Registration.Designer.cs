namespace ComputerUm
{
    partial class Registration
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
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RepeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(296, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Регистрация";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Пароль";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordTextBox.Location = new System.Drawing.Point(321, 239);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(401, 22);
            this.PasswordTextBox.TabIndex = 7;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginTextBox.Location = new System.Drawing.Point(321, 131);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(401, 22);
            this.LoginTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Повторите пароль";
            // 
            // RepeatPasswordTextBox
            // 
            this.RepeatPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RepeatPasswordTextBox.Location = new System.Drawing.Point(321, 337);
            this.RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            this.RepeatPasswordTextBox.Size = new System.Drawing.Size(401, 22);
            this.RepeatPasswordTextBox.TabIndex = 9;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationButton.Location = new System.Drawing.Point(301, 444);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(156, 41);
            this.RegistrationButton.TabIndex = 11;
            this.RegistrationButton.Text = "Регистрация";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(12, 13);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(117, 41);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ComputerUm.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(765, 516);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RepeatPasswordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RepeatPasswordTextBox;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Button BackButton;
    }
}