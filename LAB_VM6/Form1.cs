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

        private void EnterTextBox_Click(object sender, EventArgs e)
        {
            var TangentResult = NonlinearEquations.ClarificationTangent(Convert.ToDouble(TangentTextBox.Text), Convert.ToDouble(AccuracyTextBox.Text), QuestFunction, out var TangentItCount);
            var ChordsResult = NonlinearEquations.ClarificationChords(Convert.ToDouble(BeginTextBox.Text), Convert.ToDouble(EndTextBox.Text), Convert.ToDouble(AccuracyTextBox.Text), QuestFunction, out var ChordsItCount);

            TangentResTextBox.Text = TangentResult.ToString();
            TangentItCountTextBox.Text = TangentItCount.ToString();
            ChordResTextBox.Text = ChordsResult.ToString();
            ChordItCountTextBox.Text = ChordsItCount.ToString();
        }
    }
}