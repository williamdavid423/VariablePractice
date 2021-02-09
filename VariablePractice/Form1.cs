using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablePractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String personName = "Wayne Gretzky";
            int jerseyNumber = 99;

            outputLabel.Text = $"{personName} is number {jerseyNumber}";

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void AreaButton_Click(object sender, EventArgs e)
        {
            double radius = 15;
            double pi = 3.14;
            double area = pi * radius * radius;

            outputLabel.Text = $"The area of a circle with the radius of {radius}cm is {area}cm^2";

        }

        private void CarpetButton_Click(object sender, EventArgs e)
        {
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area = length * width;
            double totalCost = area * costPerMeter;

            outputLabel.Text = $"The area of a room with dimensions {length}cm by {width}cm is {area}cm^2";
            outputLabel.Text += $"\n\nThe cost to carpet this area at {costPerMeter} per square meter is ${totalCost}";

        }
    }
}
