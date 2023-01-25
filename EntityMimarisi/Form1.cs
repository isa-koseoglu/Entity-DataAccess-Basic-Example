using EntityMimarisi.DataAccess.Abstract;
using EntityMimarisi.DataAccess.ConCreate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityMimarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private IEmployeeRepository _employeeRepository;
        private void Form1_Load(object sender, EventArgs e)
        {
            _employeeRepository=new EmployeeRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            for (int i = 0; i < _employeeRepository.GetAll().Count(); i++)
            {
                button1.Text += _employeeRepository.GetAll()[i].Name.ToString()+" "+ _employeeRepository.GetAll()[i].Name.ToString() + "\n";
            }
        }
    }
}
