
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Designer support
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // TODO: Add calculation logic
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear input and output fields
            txtQuiz1.Text = string.Empty;
            txtQuiz2.Text = string.Empty;
            txtQuizAvg.Text = string.Empty;

            txtCode1.Text = string.Empty;
            txtCode2.Text = string.Empty;
            txtCodeAvg.Text = string.Empty;

            txtExam.Text = string.Empty;

            txtFinalPercent.Text = string.Empty;
            txtFinalGrade.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpQuiz_Enter(object sender, EventArgs e)
        {

        }

        private void grpExam_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpFinal_Enter(object sender, EventArgs e)
        {

        }
    }
}