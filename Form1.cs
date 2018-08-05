using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clientbook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)  // Add New person to index
        {
            GeneratePersonInfo generate = new GeneratePersonInfo();
            Person person = new Person();
            ServiceRepo repo = new ServiceRepo();
            person = generate.InfoToPerson(FirstNameTextBox.Text, LastNameTextBox.Text, AddressTextBox.Text, EmailTextBox.Text, PhoneNumberTextBox.Text, ClientIDTextBox.Text);
            repo.AddPerson(person);
            
        }
    }
}
