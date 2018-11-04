using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2002807_Maeda_MailOrder3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double hoursWorked, storeSales, totalBonus, timePeriod, employeePercent;
                //timePeriod is in hours
                timePeriod = 160;
                //gets information from textboxes
                hoursWorked = int.Parse(hoursWorkedInput.Text);
                storeSales = int.Parse(totalSalesInput.Text);
                //calculates the percent of the total time of the employee
                employeePercent = (hoursWorked / timePeriod);
                totalBonus = storeSales * employeePercent * 0.02;
                bonusT.Text = totalBonus.ToString("C");


            }
            catch
            {
                MessageBox.Show("Please enter a value", "ERROR");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            nameInput.Clear();
            hoursWorkedInput.Clear();
            bonusT.Clear();
        }
    }
}
