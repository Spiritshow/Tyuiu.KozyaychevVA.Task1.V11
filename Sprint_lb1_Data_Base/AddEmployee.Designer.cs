namespace Sprint_lb1_Data_Base
{
    partial class AddEmployee
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.Patronymic = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.DataOfBirth = new System.Windows.Forms.TextBox();
            this.Post = new System.Windows.Forms.TextBox();
            this.DataOfEnrollment = new System.Windows.Forms.TextBox();
            this.Experience = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.TextBox();
            this.Education = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Домашний адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Дата рождения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Должность";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Дата зачисления";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Стаж работы";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Образование";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(178, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Оклад";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(30, 55);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 22);
            this.Name.TabIndex = 11;
            this.Name.Text = "AddEmployee";
            // 
            // SecondName
            // 
            this.SecondName.Location = new System.Drawing.Point(167, 55);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(122, 22);
            this.SecondName.TabIndex = 12;
            this.SecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondName_KeyPress);
            // 
            // Patronymic
            // 
            this.Patronymic.Location = new System.Drawing.Point(317, 55);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(100, 22);
            this.Patronymic.TabIndex = 13;
            this.Patronymic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondName_KeyPress);
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(30, 119);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(100, 22);
            this.Address.TabIndex = 14;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(167, 119);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(122, 22);
            this.PhoneNumber.TabIndex = 15;
            this.PhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // DataOfBirth
            // 
            this.DataOfBirth.Location = new System.Drawing.Point(314, 119);
            this.DataOfBirth.Name = "DataOfBirth";
            this.DataOfBirth.Size = new System.Drawing.Size(100, 22);
            this.DataOfBirth.TabIndex = 16;
            this.DataOfBirth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // Post
            // 
            this.Post.Location = new System.Drawing.Point(30, 177);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(100, 22);
            this.Post.TabIndex = 17;
            // 
            // DataOfEnrollment
            // 
            this.DataOfEnrollment.Location = new System.Drawing.Point(167, 177);
            this.DataOfEnrollment.Name = "DataOfEnrollment";
            this.DataOfEnrollment.Size = new System.Drawing.Size(100, 22);
            this.DataOfEnrollment.TabIndex = 18;
            this.DataOfEnrollment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // Experience
            // 
            this.Experience.Location = new System.Drawing.Point(311, 177);
            this.Experience.Name = "Experience";
            this.Experience.Size = new System.Drawing.Size(100, 22);
            this.Experience.TabIndex = 19;
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(181, 240);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(100, 22);
            this.Salary.TabIndex = 20;
            this.Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // Education
            // 
            this.Education.FormattingEnabled = true;
            this.Education.Items.AddRange(new object[] {
            "Среднее образование",
            "Бакалавриат",
            "Специалитет",
            "Магистратура"});
            this.Education.Location = new System.Drawing.Point(30, 238);
            this.Education.Name = "Education";
            this.Education.Size = new System.Drawing.Size(121, 24);
            this.Education.TabIndex = 21;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(212, 305);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(94, 47);
            this.Add.TabIndex = 22;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(320, 305);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(94, 47);
            this.cancel.TabIndex = 23;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 374);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Education);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.Experience);
            this.Controls.Add(this.DataOfEnrollment);
            this.Controls.Add(this.Post);
            this.Controls.Add(this.DataOfBirth);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Patronymic);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name.Text = "AddEmployee";
            this.Text = "Форма добавления";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox SecondName;
        private System.Windows.Forms.TextBox Patronymic;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.TextBox DataOfBirth;
        private System.Windows.Forms.TextBox Post;
        private System.Windows.Forms.TextBox DataOfEnrollment;
        private System.Windows.Forms.TextBox Experience;
        private System.Windows.Forms.TextBox Salary;
        private System.Windows.Forms.ComboBox Education;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button cancel;
    }
}