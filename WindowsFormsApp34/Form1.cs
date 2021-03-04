using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getHoursButton_Click(object sender, EventArgs e)
        {
            string name, id, track;

            name = nameTextBox.Text;
            id = idTextBox.Text;

            if (infoSystemRadioButton.Checked)
            {
                track = "Systemy baz danych";
            }
            else
            {
                track = "Tworzenie oprogramoania";
            }

            CompSciStudent csStudent = new CompSciStudent(name, id, track);
            requiredHoursLabel.Text = csStudent.RequiredHours.ToString("n1");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
