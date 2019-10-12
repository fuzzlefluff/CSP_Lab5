using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Matthew Prindle, Lab 5 myArray Lab
namespace myArrayMatthewPrindle
{
    public partial class Form1 : Form
    {
        double[] myArray = new double[10];
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddVBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (count > 9) { MessageBox.Show("The Array is full! Restart the program for a fresh array!"); return; }
                myArray[count] = Convert.ToDouble(inputTxB.Text);
                count++;
                CountLbl.Text = Convert.ToString(count);
            }
            catch (Exception E) { MessageBox.Show("Please enter a real value!"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < myArray.Length; i++) { Console.WriteLine(myArray[i]); }
        }
    }
}
