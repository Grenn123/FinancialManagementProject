namespace FMP_WinForm_Version
{
    partial class RegistrationScreen
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_NewLogin = new System.Windows.Forms.TextBox();
            this.textBox_NewPassword = new System.Windows.Forms.TextBox();
            this.textBox_CofirmPassword = new System.Windows.Forms.TextBox();
            this.button_Registry = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация нового пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Подтверждение пароля";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // textBox_NewLogin
            // 
            this.textBox_NewLogin.Location = new System.Drawing.Point(208, 117);
            this.textBox_NewLogin.Name = "textBox_NewLogin";
            this.textBox_NewLogin.Size = new System.Drawing.Size(255, 22);
            this.textBox_NewLogin.TabIndex = 4;
            // 
            // textBox_NewPassword
            // 
            this.textBox_NewPassword.Location = new System.Drawing.Point(208, 173);
            this.textBox_NewPassword.Name = "textBox_NewPassword";
            this.textBox_NewPassword.Size = new System.Drawing.Size(255, 22);
            this.textBox_NewPassword.TabIndex = 5;
            // 
            // textBox_CofirmPassword
            // 
            this.textBox_CofirmPassword.Location = new System.Drawing.Point(208, 223);
            this.textBox_CofirmPassword.Name = "textBox_CofirmPassword";
            this.textBox_CofirmPassword.Size = new System.Drawing.Size(255, 22);
            this.textBox_CofirmPassword.TabIndex = 6;
            // 
            // button_Registry
            // 
            this.button_Registry.Location = new System.Drawing.Point(346, 292);
            this.button_Registry.Name = "button_Registry";
            this.button_Registry.Size = new System.Drawing.Size(117, 23);
            this.button_Registry.TabIndex = 7;
            this.button_Registry.Text = "Создать";
            this.button_Registry.UseVisualStyleBackColor = true;
            this.button_Registry.Click += new System.EventHandler(this.button_Registry_Click);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(208, 292);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 23);
            this.button_Back.TabIndex = 8;
            this.button_Back.Text = "Назад";
            this.button_Back.UseVisualStyleBackColor = true;
            // 
            // RegistrationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 347);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Registry);
            this.Controls.Add(this.textBox_CofirmPassword);
            this.Controls.Add(this.textBox_NewPassword);
            this.Controls.Add(this.textBox_NewLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationScreen";
            this.Text = "RegistrationScreen";
            this.Load += new System.EventHandler(this.RegistrationScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_NewLogin;
        private System.Windows.Forms.TextBox textBox_NewPassword;
        private System.Windows.Forms.TextBox textBox_CofirmPassword;
        private System.Windows.Forms.Button button_Registry;
        private System.Windows.Forms.Button button_Back;
    }
}