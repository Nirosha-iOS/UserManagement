using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagement
{
    public partial class HomePage : Form
    {

        private string firstName;
        private string lastName;
        private string email;
        private string phone;
        private string addressOne;
        private string addressTwo;

        public HomePage(string firstName, string lastName, string email, string phone, string addressOne, string addressTwo)
        {
            InitializeComponent();
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
            this.addressOne = addressOne;
            this.addressTwo = addressTwo;

            txtWelcome.Text = $"Welcome {firstName} {lastName}!!!";
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
