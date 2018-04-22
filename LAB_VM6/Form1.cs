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

            var result = NonlinearEquations.ClarificationTangent(2.6, 0.001, QuestFunction, out var count);

            var result2 = NonlinearEquations.ClarificationChords(0, 2.2, 0.001, QuestFunction);


        }
    }
}
