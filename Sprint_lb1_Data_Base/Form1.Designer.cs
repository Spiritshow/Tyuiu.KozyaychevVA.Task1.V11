namespace Sprint_lb1_Data_Base
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.employee = new System.Windows.Forms.Button();
            this.program = new System.Windows.Forms.Button();
            this.graphics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employee
            // 
            this.employee.Location = new System.Drawing.Point(72, 48);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(173, 85);
            this.employee.TabIndex = 0;
            this.employee.Text = "Сотрудники";
            this.employee.UseVisualStyleBackColor = true;
            this.employee.Click += new System.EventHandler(this.employee_Click);
            // 
            // program
            // 
            this.program.Location = new System.Drawing.Point(72, 304);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(173, 78);
            this.program.TabIndex = 1;
            this.program.Text = "О программе";
            this.program.UseVisualStyleBackColor = true;
            this.program.Click += new System.EventHandler(this.program_Click);
            // 
            // graphics
            // 
            this.graphics.Location = new System.Drawing.Point(72, 175);
            this.graphics.Name = "graphics";
            this.graphics.Size = new System.Drawing.Size(173, 78);
            this.graphics.TabIndex = 2;
            this.graphics.Text = "Графики";
            this.graphics.UseVisualStyleBackColor = true;
            this.graphics.Click += new System.EventHandler(this.graphics_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 450);
            this.Controls.Add(this.graphics);
            this.Controls.Add(this.program);
            this.Controls.Add(this.employee);
            this.Name = "MainMenu";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button employee;
        private System.Windows.Forms.Button program;
        private System.Windows.Forms.Button graphics;
    }
}

