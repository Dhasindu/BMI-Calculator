using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bmiCalcbtn_Click(object sender, EventArgs e)
        { 
            //Varibles
            float bmi = 0.0f;
            float height;
            float weight;
          
                //Check whether user entered value in a correct type if So,stored to varible height
                if(float.TryParse(heighttxt.Text,out height))
                {
                    if (!(height > 0))
                    {
                        MessageBox.Show("Invalid Height value...!.Please Enter Again");
                        heighttxt.Text = " ";
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Height Type...!.Please Enter Again");
                    heighttxt.Text = " ";
                    
                }

            //Check whether user entered value in a correct type if So,stored to varible weight
            if (float.TryParse(Weighttxt.Text, out weight))
                {
                    if (!(weight > 0))
                    {
                    MessageBox.Show("Invalid Weight value...!.Please Enter Again");
                    Weighttxt.Text = " ";
                      }
                }
                else
                {
                    MessageBox.Show("Invalid Weight Type...!.Please Enter Again");
                    Weighttxt.Text = " ";
                   
                }

               // convert height(cm) to meter
               height = height / 100.0f;
            //Check whether user enterd values is not "0"
            if(height !=0.0 && weight != 0.0)
            {
                bmi = weight / (height * height);
                if (bmi > 0 && bmi < 18.5)
                {
                    displayBmi.Text = "UnderWeight";
                }
                else if (bmi >= 18.5 && bmi <= 24.9)
                {
                    displayBmi.Text = "Normal Weight";
                }
                else if (bmi >= 25 && bmi < 29.9)
                {
                    displayBmi.Text = "OverWeight";
                }
                else if (bmi >= 30)
                {
                    displayBmi.Text = "Obese";
                }
                else
                {
                    displayBmi.Text = " ";
                }
            }
            else
            {
                displayBmi.Text = " ";

            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Display a message for user and get user's opoinin [if yes condition as follows belows]
            if (MessageBox.Show("Do you need to clear?","Clear",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                heighttxt.Text = " ";
                Weighttxt.Text = " ";
                displayBmi.Text = "";
            }
            
        }
    }
}
