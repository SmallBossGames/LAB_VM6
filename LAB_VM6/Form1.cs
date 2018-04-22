using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_VM6
{
    public partial class Form1 : Form
    {
        double QuestFunction(double x) => Math.Pow(2, x) - 2 * x * x + 1;

        public Form1()
        {
            InitializeComponent();            
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            var resultTangent = NonlinearEquations.ClarificationTangent(Convert.ToDouble(EnterTextBox.Text), Convert.ToDouble(AccuracyTextBox.Text), QuestFunction, out var count);

            var resultChords = NonlinearEquations.ClarificationChords(Convert.ToDouble(BeginTextBox.Text), Convert.ToDouble(EndTextBox.Text), Convert.ToDouble(AccuracyTextBox.Text), QuestFunction);

            ChordTextBox.Text = resultChords.ToString();
            TangentTextBox.Text = resultTangent.ToString();
        }
    }
}