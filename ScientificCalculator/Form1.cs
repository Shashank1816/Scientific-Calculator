using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculator
{

    public partial class Form1 : Form
    {
        double enterFirstValue, enterSecondValue;
        string op;
        public Form1()
        {
            InitializeComponent();
        }


        private void EnterNumbers(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            if (txt_Result.Text == "0")
                txt_Result.Text = "";
            {

                if (number.Text == ",")
                {
                    if (!txt_Result.Text.Contains(","))
                    {
                        txt_Result.Text = txt_Result.Text + number.Text;
                    }
                }
                else
                {
                    txt_Result.Text = txt_Result.Text + number.Text;
                }
            }
        }

        private void numberOper(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            enterFirstValue = Convert.ToDouble(txt_Result.Text);
            op = number.Text;
            lbl_Process.Text = txt_Result.Text + op;
            txt_Result.Text = "";

        }

        private void btn_Equal_Click(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(txt_Result.Text);
            lbl_Process.Text = "";
            switch (op)
            {
                case "+":
                    txt_Result.Text = (enterFirstValue + enterSecondValue).ToString();
                    break;

                case "-":
                    txt_Result.Text = (enterFirstValue - enterSecondValue).ToString();
                    break;

                case "x":
                    txt_Result.Text = (enterFirstValue * enterSecondValue).ToString();
                    break;

                case "/":
                    txt_Result.Text = (enterFirstValue / enterSecondValue).ToString();
                    break;
                case "Mod":
                    txt_Result.Text = (enterFirstValue % enterSecondValue).ToString();
                    break;
                case "Exp":
                    double i = Convert.ToDouble(txt_Result.Text);
                    double j;
                    j = enterSecondValue;
                    txt_Result.Text = Math.Exp(i * Math.Log(j * 4)).ToString();
                    break;

                default:
                    break;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Result.Text = "0";
            lbl_Process.Text = "";
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            txt_Result.Text = "0";
            lbl_Process.Text = "";

            string f, s;
            f = enterFirstValue.ToString();
            s = enterSecondValue.ToString();
            f = "";
            s = "";
        }

        private void btn_PlusandMinus_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txt_Result.Text);
            txt_Result.Text = (-1 * q).ToString();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (txt_Result.Text.Length > 0)
            {
                txt_Result.Text = txt_Result.Text.Remove(txt_Result.Text.Length - 1, 1);
            }

            if (txt_Result.Text == "0")
            {
                txt_Result.Text += "0";
            }
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 416;
            txt_Result.Width = 355;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 720; //816
            txt_Result.Width = 655;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;
            exitCal = MessageBox.Show("Confirm if you want to exit", "Scientific Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btn_Pi_Click(object sender, EventArgs e)
        {
            txt_Result.Text = "3,141592653589976323";
        }

        private void btn_Log_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(txt_Result.Text);
            logg = Math.Log10(logg);
            txt_Result.Text = logg.ToString();
        }

        private void btn_Sqrt_Click(object sender, EventArgs e)
        {
            double sqrt = Convert.ToDouble(txt_Result.Text);
            sqrt = Math.Sqrt(sqrt);
            txt_Result.Text = sqrt.ToString();
        }

        private void btn_XSquared_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txt_Result.Text) * Convert.ToDouble(txt_Result.Text);
            txt_Result.Text = x.ToString();
        }

        private void btn_XThree_Click(object sender, EventArgs e)
        {
            double x, y, z, d;
            y = Convert.ToDouble(txt_Result.Text);
            z = Convert.ToDouble(txt_Result.Text);
            d = Convert.ToDouble(txt_Result.Text);
            x = (y * z * d);
            txt_Result.Text = x.ToString();
        }

        private void btn_Sinh_Click(object sender, EventArgs e)
        {
            double sinh = Convert.ToDouble(txt_Result.Text);
            sinh = Math.Sinh(sinh);
            txt_Result.Text = sinh.ToString();
        }

        private void btn_Sin_Click(object sender, EventArgs e)
        {
            double sin = Convert.ToDouble(txt_Result.Text);
            sin = Math.Sin(sin);
            txt_Result.Text = sin.ToString();
        }

        private void btn_Dec_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(txt_Result.Text);
            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;
            txt_Result.Text = i2.ToString();
        }

        private void btn_Cosh_Click(object sender, EventArgs e)
        {
            double cosh = Convert.ToDouble(txt_Result.Text);
            cosh = Math.Cosh(cosh);
            txt_Result.Text = cosh.ToString();
        }

        private void btn_Cos_Click(object sender, EventArgs e)
        {
            double cos = Convert.ToDouble(txt_Result.Text);
            cos = Math.Cos(cos);
            txt_Result.Text = cos.ToString();
        }

        private void btn_Bin_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_Result.Text);
            txt_Result.Text = Convert.ToString(a, 2);
        }

        private void btn_Tanh_Click(object sender, EventArgs e)
        {
            double tanh = Convert.ToDouble(txt_Result.Text);
            tanh = Math.Tanh(tanh);
            txt_Result.Text = tanh.ToString();
        }

        private void btn_Tan_Click(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(txt_Result.Text);
            tan = Math.Tan(tan);
            txt_Result.Text = tan.ToString();
        }

        private void btn_OneDivideX_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txt_Result.Text));
            txt_Result.Text = a.ToString();
        }

        private void btn_lnX_Click(object sender, EventArgs e)
        {
            double lnX = Convert.ToDouble(txt_Result.Text);
            lnX = Math.Log(lnX);
            txt_Result.Text = lnX.ToString();
        }

        private void btn_Percentile_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txt_Result.Text) / Convert.ToDouble(100);
            txt_Result.Text = a.ToString();
        }

        private void btn_Hex_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_Result.Text);
            txt_Result.Text = Convert.ToString(a, 16);
        }

        private void btn_Oct_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_Result.Text);
            txt_Result.Text = Convert.ToString(a, 8);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 416;
            txt_Result.Width = 355;
        }
    }
}
