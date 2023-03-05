using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rosell_Flag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CountryNameLabel.Visible = false;
            FlagViewerLabel.Visible = false;
            ProgrammerLabel.Visible = false;
        }

        private void PhilippinesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PhilippinesRadioButton.Checked)
            {
                
                Image image = Image.FromFile("D:/Philippines.jpg");

                
                CountryImage.Image = image;
                CountryNameLabel.Text = "Philippines";
            }
        }

        private void ColumbiaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            Image image = Image.FromFile("D:/Columbia.png");

            
            CountryImage.Image = image;
            CountryNameLabel.Text = "Columbia";
        }

        private void USARadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            Image image = Image.FromFile("D:/USA.jpg");

            
            CountryImage.Image = image;
            CountryNameLabel.Text = "USA";
        }

        private void FranceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            Image image = Image.FromFile("D:/France.jpg");

            
            CountryImage.Image = image;
            CountryNameLabel.Text = "France";
        }

        private void TitleCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (TitleCheckbox.Checked)
                FlagViewerLabel.Visible = true;
            else
                FlagViewerLabel.Visible = false;
        }

        private void CountryNameCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (CountryNameCheckbox.Checked)
                CountryNameLabel.Visible = true;
            else
                CountryNameLabel.Visible = false;
        }

        private void ProgrammerCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ProgrammerCheckbox.Checked)
                ProgrammerLabel.Visible = true;
            else
                ProgrammerLabel.Visible = false;
        }
    }
}
