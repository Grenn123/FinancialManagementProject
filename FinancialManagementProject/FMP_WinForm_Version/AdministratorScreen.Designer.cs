namespace FMP_WinForm_Version
{
    partial class AdministratorScreen
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
            this.dataGridView_AdminScreen = new System.Windows.Forms.DataGridView();
            this.button_Select = new System.Windows.Forms.Button();
            this.button_NewClient = new System.Windows.Forms.Button();
            this.button_NewMeneger = new System.Windows.Forms.Button();
            this.comboBox1_AdministratorScreen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AdminScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_AdminScreen
            // 
            this.dataGridView_AdminScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AdminScreen.Location = new System.Drawing.Point(0, 1);
            this.dataGridView_AdminScreen.Name = "dataGridView_AdminScreen";
            this.dataGridView_AdminScreen.Size = new System.Drawing.Size(802, 312);
            this.dataGridView_AdminScreen.TabIndex = 0;
            // 
            // button_Select
            // 
            this.button_Select.Location = new System.Drawing.Point(282, 343);
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size(156, 34);
            this.button_Select.TabIndex = 2;
            this.button_Select.Text = "Вывести";
            this.button_Select.UseVisualStyleBackColor = true;
            this.button_Select.Click += new System.EventHandler(this.button_Select_Click);
            // 
            // button_NewClient
            // 
            this.button_NewClient.Location = new System.Drawing.Point(625, 343);
            this.button_NewClient.Name = "button_NewClient";
            this.button_NewClient.Size = new System.Drawing.Size(144, 34);
            this.button_NewClient.TabIndex = 3;
            this.button_NewClient.Text = "Новый клиент";
            this.button_NewClient.UseVisualStyleBackColor = true;
            this.button_NewClient.Click += new System.EventHandler(this.button_NewClient_Click);
            // 
            // button_NewMeneger
            // 
            this.button_NewMeneger.Location = new System.Drawing.Point(625, 392);
            this.button_NewMeneger.Name = "button_NewMeneger";
            this.button_NewMeneger.Size = new System.Drawing.Size(144, 34);
            this.button_NewMeneger.TabIndex = 4;
            this.button_NewMeneger.Text = "Новый менеджер";
            this.button_NewMeneger.UseVisualStyleBackColor = true;
            this.button_NewMeneger.Click += new System.EventHandler(this.button_NewMeneger_Click);
            // 
            // comboBox1_AdministratorScreen
            // 
            this.comboBox1_AdministratorScreen.DisplayMember = "Text";
            this.comboBox1_AdministratorScreen.FormattingEnabled = true;
            this.comboBox1_AdministratorScreen.Location = new System.Drawing.Point(23, 343);
            this.comboBox1_AdministratorScreen.Name = "comboBox1_AdministratorScreen";
            this.comboBox1_AdministratorScreen.Size = new System.Drawing.Size(244, 21);
            this.comboBox1_AdministratorScreen.TabIndex = 1;
            this.comboBox1_AdministratorScreen.ValueMember = "Value";
            // 
            // AdministratorScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 467);
            this.Controls.Add(this.button_NewMeneger);
            this.Controls.Add(this.button_NewClient);
            this.Controls.Add(this.button_Select);
            this.Controls.Add(this.comboBox1_AdministratorScreen);
            this.Controls.Add(this.dataGridView_AdminScreen);
            this.Name = "AdministratorScreen";
            this.Text = "AdministratorScreen";
            this.Load += new System.EventHandler(this.AdministratorScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AdminScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_AdminScreen;
        private System.Windows.Forms.Button button_Select;
        private System.Windows.Forms.Button button_NewClient;
        private System.Windows.Forms.Button button_NewMeneger;
        private System.Windows.Forms.ComboBox comboBox1_AdministratorScreen;
    }
}