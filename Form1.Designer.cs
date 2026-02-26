
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private GroupBox grpQuiz, grpCoding, grpExam, grpFinal;
        private TextBox txtQuiz1, txtQuiz2;
        private TextBox txtCode1, txtCode2, txtCodeAvg;
        private TextBox txtExam;
        private TextBox txtFinalPercent, txtFinalGrade;
        private Label lblQuizAvg, lblCodeAvg, lblFinalPercent, lblFinalGrade;
        private Button btnCalculate, btnClear, btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpQuiz = new System.Windows.Forms.GroupBox();
            this.txtQuiz1 = new System.Windows.Forms.TextBox();
            this.txtQuiz2 = new System.Windows.Forms.TextBox();
            this.lblQuizAvg = new System.Windows.Forms.Label();
            this.grpCoding = new System.Windows.Forms.GroupBox();
            this.txtCode1 = new System.Windows.Forms.TextBox();
            this.txtCode2 = new System.Windows.Forms.TextBox();
            this.lblCodeAvg = new System.Windows.Forms.Label();
            this.txtCodeAvg = new System.Windows.Forms.TextBox();
            this.grpExam = new System.Windows.Forms.GroupBox();
            this.txtExam = new System.Windows.Forms.TextBox();
            this.grpFinal = new System.Windows.Forms.GroupBox();
            this.lblFinalPercent = new System.Windows.Forms.Label();
            this.txtFinalPercent = new System.Windows.Forms.TextBox();
            this.lblFinalGrade = new System.Windows.Forms.Label();
            this.txtFinalGrade = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grpQuiz.SuspendLayout();
            this.grpCoding.SuspendLayout();
            this.grpExam.SuspendLayout();
            this.grpFinal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Maroon;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(831, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GRADE CALCULATOR SYSTEM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpQuiz
            // 
            this.grpQuiz.Controls.Add(this.label3);
            this.grpQuiz.Controls.Add(this.textBox4);
            this.grpQuiz.Controls.Add(this.label2);
            this.grpQuiz.Controls.Add(this.label1);
            this.grpQuiz.Controls.Add(this.textBox1);
            this.grpQuiz.Controls.Add(this.txtQuiz1);
            this.grpQuiz.Controls.Add(this.txtQuiz2);
            this.grpQuiz.Controls.Add(this.lblQuizAvg);
            this.grpQuiz.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpQuiz.Location = new System.Drawing.Point(20, 70);
            this.grpQuiz.Name = "grpQuiz";
            this.grpQuiz.Size = new System.Drawing.Size(260, 229);
            this.grpQuiz.TabIndex = 1;
            this.grpQuiz.TabStop = false;
            this.grpQuiz.Text = "Quizzes (30%)";
            this.grpQuiz.Enter += new System.EventHandler(this.grpQuiz_Enter);
            // 
            // txtQuiz1
            // 
            this.txtQuiz1.Location = new System.Drawing.Point(100, 30);
            this.txtQuiz1.Name = "txtQuiz1";
            this.txtQuiz1.Size = new System.Drawing.Size(100, 25);
            this.txtQuiz1.TabIndex = 2;
            // 
            // txtQuiz2
            // 
            this.txtQuiz2.Location = new System.Drawing.Point(100, 60);
            this.txtQuiz2.Name = "txtQuiz2";
            this.txtQuiz2.Size = new System.Drawing.Size(100, 25);
            this.txtQuiz2.TabIndex = 3;
            // 
            // lblQuizAvg
            // 
            this.lblQuizAvg.Location = new System.Drawing.Point(15, 100);
            this.lblQuizAvg.Name = "lblQuizAvg";
            this.lblQuizAvg.Size = new System.Drawing.Size(100, 23);
            this.lblQuizAvg.TabIndex = 4;
            this.lblQuizAvg.Text = "Average:";
            // 
            // grpCoding
            // 
            this.grpCoding.Controls.Add(this.textBox5);
            this.grpCoding.Controls.Add(this.label6);
            this.grpCoding.Controls.Add(this.label5);
            this.grpCoding.Controls.Add(this.label4);
            this.grpCoding.Controls.Add(this.txtCode1);
            this.grpCoding.Controls.Add(this.txtCode2);
            this.grpCoding.Controls.Add(this.lblCodeAvg);
            this.grpCoding.Controls.Add(this.txtCodeAvg);
            this.grpCoding.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpCoding.Location = new System.Drawing.Point(300, 70);
            this.grpCoding.Name = "grpCoding";
            this.grpCoding.Size = new System.Drawing.Size(260, 229);
            this.grpCoding.TabIndex = 2;
            this.grpCoding.TabStop = false;
            this.grpCoding.Text = "Coding Challenges (30%)";
            // 
            // txtCode1
            // 
            this.txtCode1.Location = new System.Drawing.Point(130, 30);
            this.txtCode1.Name = "txtCode1";
            this.txtCode1.Size = new System.Drawing.Size(100, 25);
            this.txtCode1.TabIndex = 2;
            // 
            // txtCode2
            // 
            this.txtCode2.Location = new System.Drawing.Point(130, 60);
            this.txtCode2.Name = "txtCode2";
            this.txtCode2.Size = new System.Drawing.Size(100, 25);
            this.txtCode2.TabIndex = 3;
            // 
            // lblCodeAvg
            // 
            this.lblCodeAvg.Location = new System.Drawing.Point(15, 100);
            this.lblCodeAvg.Name = "lblCodeAvg";
            this.lblCodeAvg.Size = new System.Drawing.Size(100, 23);
            this.lblCodeAvg.TabIndex = 4;
            this.lblCodeAvg.Text = "Average:";
            // 
            // txtCodeAvg
            // 
            this.txtCodeAvg.BackColor = System.Drawing.Color.LightGray;
            this.txtCodeAvg.Location = new System.Drawing.Point(130, 100);
            this.txtCodeAvg.Name = "txtCodeAvg";
            this.txtCodeAvg.ReadOnly = true;
            this.txtCodeAvg.Size = new System.Drawing.Size(100, 25);
            this.txtCodeAvg.TabIndex = 5;
            // 
            // grpExam
            // 
            this.grpExam.Controls.Add(this.label8);
            this.grpExam.Controls.Add(this.label7);
            this.grpExam.Controls.Add(this.textBox2);
            this.grpExam.Controls.Add(this.txtExam);
            this.grpExam.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpExam.Location = new System.Drawing.Point(580, 70);
            this.grpExam.Name = "grpExam";
            this.grpExam.Size = new System.Drawing.Size(230, 229);
            this.grpExam.TabIndex = 3;
            this.grpExam.TabStop = false;
            this.grpExam.Text = "Major Examination (40%)";
            this.grpExam.Enter += new System.EventHandler(this.grpExam_Enter);
            // 
            // txtExam
            // 
            this.txtExam.Location = new System.Drawing.Point(110, 50);
            this.txtExam.Name = "txtExam";
            this.txtExam.Size = new System.Drawing.Size(100, 25);
            this.txtExam.TabIndex = 1;
            // 
            // grpFinal
            // 
            this.grpFinal.Controls.Add(this.label9);
            this.grpFinal.Controls.Add(this.textBox3);
            this.grpFinal.Controls.Add(this.lblFinalPercent);
            this.grpFinal.Controls.Add(this.txtFinalPercent);
            this.grpFinal.Controls.Add(this.lblFinalGrade);
            this.grpFinal.Controls.Add(this.txtFinalGrade);
            this.grpFinal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpFinal.Location = new System.Drawing.Point(20, 305);
            this.grpFinal.Name = "grpFinal";
            this.grpFinal.Size = new System.Drawing.Size(260, 170);
            this.grpFinal.TabIndex = 4;
            this.grpFinal.TabStop = false;
            this.grpFinal.Text = "Final Result";
            this.grpFinal.Enter += new System.EventHandler(this.grpFinal_Enter);
            // 
            // lblFinalPercent
            // 
            this.lblFinalPercent.Location = new System.Drawing.Point(20, 40);
            this.lblFinalPercent.Name = "lblFinalPercent";
            this.lblFinalPercent.Size = new System.Drawing.Size(100, 23);
            this.lblFinalPercent.TabIndex = 0;
            this.lblFinalPercent.Text = "Final Percentage:";
            // 
            // txtFinalPercent
            // 
            this.txtFinalPercent.BackColor = System.Drawing.Color.LightGray;
            this.txtFinalPercent.Location = new System.Drawing.Point(126, 38);
            this.txtFinalPercent.Name = "txtFinalPercent";
            this.txtFinalPercent.ReadOnly = true;
            this.txtFinalPercent.Size = new System.Drawing.Size(100, 25);
            this.txtFinalPercent.TabIndex = 1;
            // 
            // lblFinalGrade
            // 
            this.lblFinalGrade.Location = new System.Drawing.Point(20, 80);
            this.lblFinalGrade.Name = "lblFinalGrade";
            this.lblFinalGrade.Size = new System.Drawing.Size(100, 23);
            this.lblFinalGrade.TabIndex = 2;
            this.lblFinalGrade.Text = "Final Grade:";
            // 
            // txtFinalGrade
            // 
            this.txtFinalGrade.BackColor = System.Drawing.Color.LightGray;
            this.txtFinalGrade.Location = new System.Drawing.Point(126, 77);
            this.txtFinalGrade.Name = "txtFinalGrade";
            this.txtFinalGrade.ReadOnly = true;
            this.txtFinalGrade.Size = new System.Drawing.Size(100, 25);
            this.txtFinalGrade.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Maroon;
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(494, 440);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(110, 35);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(610, 440);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 35);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(706, 440);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 35);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.Location = new System.Drawing.Point(100, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGray;
            this.textBox2.Location = new System.Drawing.Point(110, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quiz 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quiz 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.LightGray;
            this.textBox4.Location = new System.Drawing.Point(100, 131);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 25);
            this.textBox4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Remarks:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Challenge 1";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Challenge 2";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(15, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Remarks:";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.LightGray;
            this.textBox5.Location = new System.Drawing.Point(130, 131);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 25);
            this.textBox5.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Major Exam";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Remarks:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightGray;
            this.textBox3.Location = new System.Drawing.Point(126, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(20, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Remarks:";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpQuiz);
            this.Controls.Add(this.grpCoding);
            this.Controls.Add(this.grpExam);
            this.Controls.Add(this.grpFinal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Grade Calculator System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpQuiz.ResumeLayout(false);
            this.grpQuiz.PerformLayout();
            this.grpCoding.ResumeLayout(false);
            this.grpCoding.PerformLayout();
            this.grpExam.ResumeLayout(false);
            this.grpExam.PerformLayout();
            this.grpFinal.ResumeLayout(false);
            this.grpFinal.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox3;
    }
}