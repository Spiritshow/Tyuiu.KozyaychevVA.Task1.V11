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
    public partial class Employee : Form
    {

        public class Worker
        {
            public string Name;
            public string SecondName;
            public string Patronymic;
            public string Address;
            public string PhoneNumber;
            public string DataOfBirth;
            public string Post;
            public string DataOfEnrollment;
            public string Experience;
            public string Education;
            public string Salary;

            public Worker(string Name, string SecondName, string Patronymic, string Address, string PhoneNumber, string DataOfBirth, string Post, string DataOfEnrollment, string Experience, string Education, string Salary)
            {
                this.Name = Name;
                this.SecondName = SecondName;
                this.Patronymic = Patronymic;
                this.Address = Address;
                this.PhoneNumber = PhoneNumber;
                this.DataOfBirth = DataOfBirth;
                this.Post = Post;
                this.DataOfEnrollment = DataOfEnrollment;
                this.Experience = Experience;
                this.Education = Education;
                this.Salary = Salary;
            }
        }

        public static List<Worker> workers = new List<Worker>();
        public static DataTable table = new DataTable();


        public void updateWorker()
        {
            workers.Clear();
            using (StreamReader rd = new StreamReader(@"C:\Users\vkozy\Desktop\soft\DataOut\Output.csv", Encoding.GetEncoding(1251)))
            {
                while (!rd.EndOfStream)
                {
                    string line = rd.ReadLine();
                    string[] parts = line.Split(new char[] { ';' });
                    workers.Add(new Worker(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7], parts[8], parts[9], parts[10]));
                }
            } 
        }
    

        public void updateTable()
        {
            table.Columns.Clear();
            table.Rows.Clear();
            table.Clear();
            table.Columns.Add(workers[0].Name);
            table.Columns.Add(workers[0].SecondName);
            table.Columns.Add(workers[0].Patronymic);
            table.Columns.Add(workers[0].Address);
            table.Columns.Add(workers[0].PhoneNumber);
            table.Columns.Add(workers[0].DataOfBirth);
            table.Columns.Add(workers[0].Post);
            table.Columns.Add(workers[0].DataOfEnrollment);
            table.Columns.Add(workers[0].Experience);
            table.Columns.Add(workers[0].Education);
            table.Columns.Add(workers[0].Salary);

            for (int i = 1; i < workers.Count;i++)
            {
                table.Rows.Add(workers[i].Name,workers[i].SecondName, workers[i].Patronymic, workers[i].Address,workers[i].PhoneNumber, workers[i].DataOfBirth, workers[i].Post, workers[i].DataOfEnrollment, workers[i].Experience, workers[i].Education, workers[i].Salary);
            }

            dataGridView1.DataSource = table;
        }

        public Employee()
        {
            InitializeComponent();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEm = new AddEmployee();
            addEm.Show();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            updateWorker();
            updateTable();
        }
    }
}
