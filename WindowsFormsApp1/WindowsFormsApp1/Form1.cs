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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }


        const int SIZE = 5000;

        string[] listA = new string[SIZE];

        int index = 0;



        private void DisplayNamesButton_Click(object sender, EventArgs e)
        {





            try
            {

                // using the streamreader class to read the data from the csv file
                StreamReader str = new StreamReader("Names.csv");




                // adding the file with the names to the Names list box
                while (!str.EndOfStream)
                {
                    listA[index] = str.ReadLine();
                    NamesListBox.Items.Add(listA[index]);
                    index++;



                    // List<string> names = new List<string>();



                    // this is displaying the total count of items in the list box in the seperate count box
                    TotalCountLabel.Text = NamesListBox.Items.Count.ToString();

                }






            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Array.Sort(listA);

            //foreach (string strin in listA)
            //{
            //    NamesListBox.Text = strin;
            //}
        }
    }
}

