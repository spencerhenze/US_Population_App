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

/*
 Spencer Henze
 ITM 225
 10/26/16
 Homework #6
 */ 
namespace US_Population_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Begin Methods:

        private double Average(int[] iArray)
        {
            int total = 0; // Accumulator, initialized to 0
            double average; // to hold the average

            // step throught he array, adding each element to the accumulator.

            for (int index = 0; index < iArray.Length; index++)
            {
                total += iArray[index];
            }

            // now calculate the average

            average = (double)total / iArray.Length;
            return average;
        } // end Average() method

        private int Greatest(int[] iArray)
        {
            int greatest = iArray[0]; //declare a variable to hold the highest value, and initialize it with the first value in the array.
            int greatestYear = 1950; // declare the variable that will hold the year that corresponds to the highest increase.

            for (int index = 1; index < iArray.Length; index++) // step through the rest of the array, beginning at element 1. When a value greater than highest is found, assign that value to highest.
            {
                if (iArray[index] > greatest) //if the value of the index is greater than
                {
                    greatest = iArray[index];
                    greatestYear = 1950 + index;
                }
            }

            return greatestYear;
        } // end Highest() method

        private int Least(int[] iArray)
        {
            int least = iArray[1]; //declare a variable to hold the lowest value, and initialize it with the SECOND value in the array (because the first value is 0 which is meaningless to us and nothing will be less than zero).
            int leastYear = 0; // declare a variable that will hold the year that corresponds to the value of the 'least' variable

            for (int index = 1; index < iArray.Length; index++) // step through the rest of the array, beginning at element 1. When a value greater than highest is found, assign that value to highest.
            {
                if (iArray[index] < least && index !=0)
                {
                    least = iArray[index];
                    leastYear = 1950 + index;
                }

            }

            return leastYear;
        }// end Lowest() method

        private void getDataButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            averageDisplayLabel.Text = "";
            greatestDisplayLabel.Text = "";
            leastDisplayLabel.Text = "";

            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    //declare the arrays (inside of click button because it will change every time the data is fetched)
                    //Array for populations:
                    const int SIZE = 40;
                    int[] yearPopulations = new int[SIZE];  //declare an array with 40 rows and two columns to store the population values

                    // Array 2 for changes:
                    const int CSIZE = 40;
                    int[] changesArray = new int[CSIZE]; // declare the second array that will hold the change values.

                    int index = 0; // loop counter for population
                    int index2 = 0;
                    int greatestIncrease;
                    int leastIncrease;
                    double averageIncrease;
                    StreamReader inputFile;



                    inputFile = File.OpenText(openFile.FileName); // assign the open file to the variable 'inputFile'

            //begin the loop for adding the population values to the yearPopulations array
                    while (index < yearPopulations.Length && !inputFile.EndOfStream)
                    {
                        yearPopulations[index] = int.Parse(inputFile.ReadLine()) * 1000;
                        index++;
                    }

                    inputFile.Close(); // close the file

           //add difference values to the difference array
                    ;
                    while (index2 < changesArray.Length)
                    {
                        if (index2 > 0)
                        {
                            changesArray[index2] = yearPopulations[index2] - yearPopulations[index2 - 1];
                            index2++;
                        }
                        else
                        {
                            changesArray[index2] = 0;
                            index2++;
                        }

                    }

               //Display the array info in the ListBox:

                    listBox.Items.Add("Year  " + "Increase\n"); // this is the header for the columns in the listbox.
                    //now setp through and add items from the array to the listBox:
                    for (int index3 = 0; index3 < changesArray.Length; index3++)
                    {
                        listBox.Items.Add(index3 + 1951 + "  " + changesArray[index3]); // this adds the year (index3 + 1951), two spaces, and the changes array values.
                    } // end for loop


              //Now use methods to do calculations on data 

                    greatestIncrease = Greatest(changesArray);
                    leastIncrease = Least(changesArray);
                    averageIncrease = Average(changesArray);

             //display the results in the labels.
                    greatestDisplayLabel.Text = greatestIncrease.ToString();
                    leastDisplayLabel.Text = leastIncrease.ToString();
                    averageDisplayLabel.Text = averageIncrease.ToString("N1");

                } // end if block
            } //end try block
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // end getDataButton_Click()



        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        } // end exitButton click event

        private void clearButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            averageDisplayLabel.Text = "";
            greatestDisplayLabel.Text = "";
            leastDisplayLabel.Text = "";
        } // end clearButton click event
    }
}
