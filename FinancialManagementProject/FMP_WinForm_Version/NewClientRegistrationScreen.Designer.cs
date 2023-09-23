namespace FMP_WinForm_Version
{
    partial class NewClientRegistrationScreen
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
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.comboBox_Entity = new System.Windows.Forms.ComboBox();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.comboBox_Subscription = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Юр. лицо";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Статус";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Подписка";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(100, 45);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(269, 20);
            this.textBox_Name.TabIndex = 5;
            // 
            // comboBox_Entity
            // 
            this.comboBox_Entity.FormattingEnabled = true;
            this.comboBox_Entity.Location = new System.Drawing.Point(100, 90);
            this.comboBox_Entity.Name = "comboBox_Entity";
            this.comboBox_Entity.Size = new System.Drawing.Size(269, 21);
            this.comboBox_Entity.TabIndex = 6;
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Location = new System.Drawing.Point(100, 139);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(269, 21);
            this.comboBox_Status.TabIndex = 7;
            // 
            // comboBox_Subscription
            // 
            this.comboBox_Subscription.FormattingEnabled = true;
            this.comboBox_Subscription.Location = new System.Drawing.Point(100, 193);
            this.comboBox_Subscription.Name = "comboBox_Subscription";
            this.comboBox_Subscription.Size = new System.Drawing.Size(269, 21);
            this.comboBox_Subscription.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(275, 260);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(94, 47);
            this.button_Cancel.TabIndex = 10;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // NewClientRegistrationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 355);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_Subscription);
            this.Controls.Add(this.comboBox_Status);
            this.Controls.Add(this.comboBox_Entity);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewClientRegistrationScreen";
            this.Text = "NewClientRegistrationScreen";
            this.Load += new System.EventHandler(this.NewClientRegistrationScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.ComboBox comboBox_Entity;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.ComboBox comboBox_Subscription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Cancel;
    }
}