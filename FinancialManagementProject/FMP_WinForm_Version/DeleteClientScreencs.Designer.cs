namespace FMP_WinForm_Version
{
    partial class DeleteClientScreen
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
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBox_CllientDeleteScreen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_DeleteClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(143, 98);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(122, 29);
            this.button_Cancel.TabIndex = 0;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // textBox_CllientDeleteScreen
            // 
            this.textBox_CllientDeleteScreen.Location = new System.Drawing.Point(15, 57);
            this.textBox_CllientDeleteScreen.Name = "textBox_CllientDeleteScreen";
            this.textBox_CllientDeleteScreen.Size = new System.Drawing.Size(250, 20);
            this.textBox_CllientDeleteScreen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите название клиента";
            // 
            // button_DeleteClient
            // 
            this.button_DeleteClient.Location = new System.Drawing.Point(15, 98);
            this.button_DeleteClient.Name = "button_DeleteClient";
            this.button_DeleteClient.Size = new System.Drawing.Size(122, 29);
            this.button_DeleteClient.TabIndex = 3;
            this.button_DeleteClient.Text = "Удалить";
            this.button_DeleteClient.UseVisualStyleBackColor = true;
            this.button_DeleteClient.Click += new System.EventHandler(this.button_DeleteClient_Click);
            // 
            // DeleteClientScreencs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 208);
            this.Controls.Add(this.button_DeleteClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_CllientDeleteScreen);
            this.Controls.Add(this.button_Cancel);
            this.Name = "DeleteClientScreencs";
            this.Text = "DeleteClientScreencs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox textBox_CllientDeleteScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_DeleteClient;
    }
}