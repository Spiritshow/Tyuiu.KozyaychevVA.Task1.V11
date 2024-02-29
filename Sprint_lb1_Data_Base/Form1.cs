using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprint_lb1_Data_Base
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void employee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            Hide();
        }

        private void graphics_Click(object sender, EventArgs e)
        {
            Graphics graphics = new Graphics();
            graphics.Show();
            Hide();
        }

        private void program_Click(object sender, EventArgs e)
        {
            aboutProgram aboutProgram = new aboutProgram();
            aboutProgram.Show();
            Hide();
        }
    }
}
