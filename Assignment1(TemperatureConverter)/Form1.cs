/*
Assigment-1: Temperature Converter
Author: Brighto Paul
Purpose:To become comfortable with building C# applications in Visual Studio, 
building a Temperature Converter program.
Date of Submission:1st February,2016
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_TemperatureConverter_
{
    //class
    public partial class temperatureConverterForm : Form
    {
        //form intial method
        public temperatureConverterForm()
        {
            InitializeComponent();
        }
        //default values are given to every fields,when the user press reset button
        private void resetButton_Click(object sender, EventArgs e)
        {
            tempTextBox.Text = "0";
            tempCelsiusTextBox.Text=tempFahrenheitTextBox.Text= String.Empty;
            celsiusRadioButton.Checked = fahrenheitRadioButton.Checked = false;

        }
        //Convertion Process ,happens when the user press the convert button
        private void convertButton_Click(object sender, EventArgs e)
        {
            //put the whole action in the try field ,catch field will run if any error occur
            try
            {
                //declare local variables
                double temp,output;
                temp = double.Parse(tempTextBox.Text);
                //checks whether the radio button is selectedd
                if (celsiusRadioButton.Checked)
                {
                    //convertion to celsius
                    output = (temp - 32) / 1.8;//converted to celsius
                    tempCelsiusTextBox.Text = Math.Round(output, 2).ToString();//truncated and passed to celsius box
                    tempFahrenheitTextBox.Text = Math.Round(temp, 2).ToString();
                } else if (fahrenheitRadioButton.Checked)
                {
                    //convertion to Fahrenheit
                    output = (temp*1.8)+32;//converted to Fahrenheit
                    tempFahrenheitTextBox.Text= Math.Round(output, 2).ToString();//truncated and passed to Fahrenheit box
                    tempCelsiusTextBox.Text = Math.Round(temp, 2).ToString();

                } else
                {
                    //message to be shown if the user didnt click the radio button
                    MessageBox.Show("Please choose the Temperature type to convert");
                }
            }
            //catch fields,that runs if any error happen on the convertion
           catch (FormatException feException)//format error
            {
                //error message
                MessageBox.Show("Please input a numeric value");
            }
            catch(Exception ex)
            {
                //error message
                MessageBox.Show(ex.Message,"Cannot convert ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //set defult values when the application load,called the reset_button fuction
        private void temperatureConverterForm_Load(object sender, EventArgs e)
        {
            resetButton_Click(sender,e);

        }
        //set the close function, when the user press exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
