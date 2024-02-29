namespace Sprint_lb1_Data_Base
{
    partial class Employee
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortLastName = new System.Windows.Forms.ToolStripMenuItem();
            this.SortPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.SortWorkExperience = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.NextStation = new System.Windows.Forms.Button();
            this.BackStation = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mainMenuToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.mainMenuToolStripMenuItem.Text = "Главное меню";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.searchToolStripMenuItem.Text = "Поиск";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortLastName,
            this.SortPosition,
            this.SortWorkExperience});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.sortToolStripMenuItem.Text = "Сортировка";
            // 
            // SortLastName
            // 
            this.SortLastName.Name = "SortLastName";
            this.SortLastName.Size = new System.Drawing.Size(213, 26);
            this.SortLastName.Text = "По Фамилии";
            // 
            // SortPosition
            // 
            this.SortPosition.Name = "SortPosition";
            this.SortPosition.Size = new System.Drawing.Size(213, 26);
            this.SortPosition.Text = "По Должности";
            // 
            // SortWorkExperience
            // 
            this.SortWorkExperience.Name = "SortWorkExperience";
            this.SortWorkExperience.Size = new System.Drawing.Size(213, 26);
            this.SortWorkExperience.Text = "По Стажу работы";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.filterToolStripMenuItem.Text = "Фильтр";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(767, 349);
            this.dataGridView1.TabIndex = 1;
            // 
            // AddEmployee
            // 
            this.AddEmployee.Location = new System.Drawing.Point(21, 386);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(114, 53);
            this.AddEmployee.TabIndex = 2;
            this.AddEmployee.Text = "Добавить сотрудника";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(166, 386);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(132, 53);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Редактрировать";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // NextStation
            // 
            this.NextStation.Location = new System.Drawing.Point(707, 386);
            this.NextStation.Name = "NextStation";
            this.NextStation.Size = new System.Drawing.Size(72, 53);
            this.NextStation.TabIndex = 4;
            this.NextStation.Text = "button1";
            this.NextStation.UseVisualStyleBackColor = true;
            // 
            // BackStation
            // 
            this.BackStation.Location = new System.Drawing.Point(629, 386);
            this.BackStation.Name = "BackStation";
            this.BackStation.Size = new System.Drawing.Size(72, 53);
            this.BackStation.TabIndex = 5;
            this.BackStation.Text = "button2";
            this.BackStation.UseVisualStyleBackColor = true;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackStation);
            this.Controls.Add(this.NextStation);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Employee";
            this.Text = "Сотрудники";
            this.Activated += new System.EventHandler(this.Employee_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button NextStation;
        private System.Windows.Forms.Button BackStation;
        private System.Windows.Forms.ToolStripMenuItem SortLastName;
        private System.Windows.Forms.ToolStripMenuItem SortPosition;
        private System.Windows.Forms.ToolStripMenuItem SortWorkExperience;
    }
}