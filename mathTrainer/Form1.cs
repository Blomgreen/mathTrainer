using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mathTrainer
{
    public partial class Form1 : Form
    {
        public  int result = 0;
        public  int CorrectAnswers = 0;
        public int WrongAnswers = 0;
        public int MyResultInt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 24.0F);
            Random rnd = new Random();
            int number1 = rnd.Next(1, 100);
            int number2 = rnd.Next(1, 100);
            richTextBox1.AppendText(number1 + " + " + number2);
            result = number1 + number2;
            richTextBox2.SelectionFont = new Font(richTextBox2.SelectionFont.FontFamily, 24.0F);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string myResult = richTextBox2.Text;
            try
            {
                 MyResultInt = Int32.Parse(myResult);

            }
            catch (Exception)
            {

            }

            if (MyResultInt == result && result > 1)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 24.0F);

                richTextBox1.Text = "Correct";
                CorrectAnswers++;
                string CorrectString = CorrectAnswers.ToString();
                rTBCorrect.Text = CorrectString;
            }
            else if (MyResultInt != result)
            {
                richTextBox1.Text = "WRONG";
                WrongAnswers++;
                string WrongString = WrongAnswers.ToString();
                rTBWrong.Text = WrongString;
            }
            else
            {
                Console.WriteLine("Broken");
                richTextBox1.Text = "You broke it";
            }
        }

        private void rTBWrong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
