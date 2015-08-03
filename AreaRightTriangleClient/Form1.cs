using System;
using System.Globalization;
using System.Windows.Forms;
using TriangleLogic;

namespace AreaRightTriangleClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = (double)sideA.Value;
            var b = (double)sideB.Value;
            var c = (double)sideC.Value;

            string resultString;
            try
            {
                 var result = AreaTriangleTools.SquareRightTriangle(a, b, c);
                resultString = result.ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                resultString = ex.Message;
            }

            label5.Text = resultString;
        }
    }
}
