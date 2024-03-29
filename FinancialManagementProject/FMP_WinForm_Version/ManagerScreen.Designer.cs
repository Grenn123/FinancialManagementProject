﻿namespace FMP_WinForm_Version
{
    partial class ManagerScreen
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
            this.dataGridView_MainScreen = new System.Windows.Forms.DataGridView();
            this.comboBox_ClientStatus_ManagerScreen = new System.Windows.Forms.ComboBox();
            this.textBox_ManagerScreen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_NewClient = new System.Windows.Forms.Button();
            this.button_ClientDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MainScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_MainScreen
            // 
            this.dataGridView_MainScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MainScreen.Location = new System.Drawing.Point(0, 1);
            this.dataGridView_MainScreen.Name = "dataGridView_MainScreen";
            this.dataGridView_MainScreen.Size = new System.Drawing.Size(601, 233);
            this.dataGridView_MainScreen.TabIndex = 0;
            // 
            // comboBox_ClientStatus_ManagerScreen
            // 
            this.comboBox_ClientStatus_ManagerScreen.FormattingEnabled = true;
            this.comboBox_ClientStatus_ManagerScreen.Location = new System.Drawing.Point(76, 317);
            this.comboBox_ClientStatus_ManagerScreen.Name = "comboBox_ClientStatus_ManagerScreen";
            this.comboBox_ClientStatus_ManagerScreen.Size = new System.Drawing.Size(135, 21);
            this.comboBox_ClientStatus_ManagerScreen.TabIndex = 1;
            this.comboBox_ClientStatus_ManagerScreen.SelectedIndexChanged += new System.EventHandler(this.comboBox_ClientStatus_MainScreen_SelectedIndexChanged);
            // 
            // textBox_ManagerScreen
            // 
            this.textBox_ManagerScreen.Location = new System.Drawing.Point(76, 279);
            this.textBox_ManagerScreen.Name = "textBox_ManagerScreen";
            this.textBox_ManagerScreen.Size = new System.Drawing.Size(135, 20);
            this.textBox_ManagerScreen.TabIndex = 2;
            this.textBox_ManagerScreen.TextChanged += new System.EventHandler(this.textBox_MainScreen_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "по типу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "по имени";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(73, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Фильтрация";
            // 
            // button_NewClient
            // 
            this.button_NewClient.Location = new System.Drawing.Point(432, 254);
            this.button_NewClient.Name = "button_NewClient";
            this.button_NewClient.Size = new System.Drawing.Size(156, 40);
            this.button_NewClient.TabIndex = 6;
            this.button_NewClient.Text = "Новый клиент";
            this.button_NewClient.UseVisualStyleBackColor = true;
            this.button_NewClient.Click += new System.EventHandler(this.button_NewClient_Click);
            // 
            // button_ClientDelete
            // 
            this.button_ClientDelete.Location = new System.Drawing.Point(432, 331);
            this.button_ClientDelete.Name = "button_ClientDelete";
            this.button_ClientDelete.Size = new System.Drawing.Size(75, 23);
            this.button_ClientDelete.TabIndex = 7;
            this.button_ClientDelete.Text = "Удалить клиента";
            this.button_ClientDelete.UseVisualStyleBackColor = true;
            this.button_ClientDelete.Click += new System.EventHandler(this.button_ClientDelete_Click);
            // 
            // ManagerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button_ClientDelete);
            this.Controls.Add(this.button_NewClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ManagerScreen);
            this.Controls.Add(this.comboBox_ClientStatus_ManagerScreen);
            this.Controls.Add(this.dataGridView_MainScreen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerScreen";
            this.Text = "Manager Screen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MainScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_MainScreen;
        private System.Windows.Forms.ComboBox comboBox_ClientStatus_ManagerScreen;
        private System.Windows.Forms.TextBox textBox_ManagerScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_NewClient;
        private System.Windows.Forms.Button button_ClientDelete;
    }
}