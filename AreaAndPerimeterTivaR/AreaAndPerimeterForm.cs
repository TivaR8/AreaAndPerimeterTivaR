using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 05-03-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Area and Perimeter
 * This program calculates the area and perimeter with the...
 * ... length and width
*/

namespace AreaAndPerimeterTivaR
{
    public partial class frmAreaAndPerimeter : Form
    {
        public frmAreaAndPerimeter()
        {
            InitializeComponent();

            // This hides the answer stuff on initialization
            this.lblAreaText.Hide();
            this.lblPerimeterText.Hide();
            this.lblAreaAnswer.Hide();
            this.lblPerimeterAnswer.Hide();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            // Closes the program
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Declare local variables
            double length, width, area, perimeter;

            // Get text from text box
            length = double.Parse(txtLengthBox.Text);
            width = double.Parse(txtWidthBox.Text);

            // Calculation time
            area = length * width;
            perimeter = length + width + length + width;

            // Display all of the answers
            this.lblAreaAnswer.Text = Convert.ToString(area) + " Squared Meters";
            this.lblPerimeterAnswer.Text = Convert.ToString(perimeter) + " Meters";

            // This shows all of the text relating to showing the answer
            this.lblAreaText.Show();
            this.lblPerimeterText.Show();
            this.lblAreaAnswer.Show();
            this.lblPerimeterAnswer.Show();
        }
    }
}
