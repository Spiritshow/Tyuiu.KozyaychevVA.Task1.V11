using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sprint_lb1_Data_Base
{

    public partial class AddEmployee : Form
    {

        String file = @"C:\Users\vkozy\Desktop\soft\DataOut\Output.csv";

        String separator = ";";
        StringBuilder output = new StringBuilder();

        public AddEmployee()
        {
            InitializeComponent();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') < -1))
            {
                e.Handled = true;
            }
        }



        private void cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {


            //string name = Name.Text;
            //string secondName = SecondName.Text;
            //string patronymic = Patronymic.Text;
            //string address = Address.Text;
            //string phoneNumber = PhoneNumber.Text;
            //string dataOfBirth = DataOfBirth.Text;
            //string post = Post.Text;
            //string dataOfEnrollment = DataOfEnrollment.Text;
            //string experience = Experience.Text;
            //string education = Education.Text;
            //string salary = Salary.Text;

            //Employee employee = new Employee(Name.Text, SecondName.Text, Patronymic.Text, Address.Text, PhoneNumber.Text, DataOfBirth.Text, Post.Text, DataOfEnrollment.Text, Experience.Text, Education.Text, Salary.Text);

            String[] newLine = { Name.Text, SecondName.Text, Patronymic.Text, Address.Text, PhoneNumber.Text, DataOfBirth.Text, Post.Text, DataOfEnrollment.Text, Experience.Text, Education.Text, Salary.Text };
            output.AppendLine(string.Join(separator, newLine));

            File.AppendAllText(file, output.ToString(), Encoding.GetEncoding(1251));

            //Employee.updateWorker();
            //Employee.updateTable();


            Hide();
        }

        private void SecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled |= true;
            }
        }
    }
}
