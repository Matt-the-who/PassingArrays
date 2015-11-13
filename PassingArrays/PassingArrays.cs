/*
Created by Matthew Ho
Created on 11-13-15
Created for ICS3U
Assignment #5-02
This program passes an array into a function.
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

namespace PassingArrays
{
    public partial class frmPassingArrays : Form
    {
        Random rnd = new Random();

        public int ArrayCheck(int [] theArray)
        {//Finds the largest # in array
            int smallestNumber = 10;

            foreach (int aSingleInteger in theArray)
            {
                if (smallestNumber > aSingleInteger)
                {
                    smallestNumber = aSingleInteger;
                }

            } 


            return smallestNumber;
        }

        public frmPassingArrays()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //variable
            int[] arrayOfNumbers = new int[5];
            int numbersGenerated = 0;

            //Clearing array and listbox
            this.lstAListbox.Items.Clear();
            Array.Clear(arrayOfNumbers, 0, 5);

            //for loop to assign each spot in the a with a random #
            for (int counter = 0; counter < 5; counter++)
            {
                numbersGenerated = rnd.Next(1, 10+1);
                arrayOfNumbers[counter] = numbersGenerated;
                this.lstAListbox.Items.Add(numbersGenerated);
            }

            //Output
            this.lblAnswer.Text = "The smallest number is " + ArrayCheck(arrayOfNumbers);
        }
    }
}
