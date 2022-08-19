using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileReader___Katharine_Wunderle
{
    //Author: Katharine Wunderle
    //ID: 623748
    //Date: 05/09/2021
    //Goal: Read and display the contents of a text file.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readFileBtn_Click(object sender, EventArgs e)
        {
            //Validation
            try
            {
                //Declare variables
                //String variable to record each line
                string myString;
                //StreamReader varible to read a file
                StreamReader inputFile;
                //Open the file input by the user
                inputFile = File.OpenText(filePathInpt.Text);
                //Clear list box to read new file
                inputBx.Items.Clear();
                //Keep reading file until the end of it is reached
                while (!inputFile.EndOfStream)
                {
                    //Record each line into the string
                    myString = inputFile.ReadLine();
                    //Copy string into list box
                    inputBx.Items.Add(myString);
                }
                //Close the file
                inputFile.Close();
            }
            //Display message if errorn occurs
            catch (Exception myException)
            {

                MessageBox.Show(myException.Message);

            }
        }
    }
}
