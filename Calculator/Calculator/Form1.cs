using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calcform : Form
    {
        int i, j, k;
        string input = "";
        double result = 0;
        string operation = "";
        int f = 1;
        int dr = 0;
        bool flag = false;
        public calcform()
        {

            InitializeComponent();
        }



        private void 電卓の終了EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 電卓についてHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help helpform = new help();
            helpform.ShowDialog();
        }

        private void 小数点以下の設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void calcform_Load(object sender, EventArgs e)
        {
            setTheme(Color.White,Color.Black);
        }

        //四則演算ここから

        private void plus_Click(object sender, EventArgs e)
        {
            siso.Text = "+";
            ope("+");
        }

        private void minus_Click(object sender, EventArgs e)
        {
            siso.Text = "-";
            ope("-");
        }

        private void wari_Click(object sender, EventArgs e)
        {
            siso.Text = "/";
            ope("/");
        }

        private void kake_Click(object sender, EventArgs e)
        {
            siso.Text = "*";
            ope("*");
        }

        //四則演算ここまで

        //数字入力ここから
        private void one_Click(object sender, EventArgs e)
        {
            Number("1");
        }

        private void two_Click(object sender, EventArgs e)
        {
            Number("2");
        }

        private void three_Click(object sender, EventArgs e)
        {
            Number("3");
        }

        private void four_Click(object sender, EventArgs e)
        {
            Number("4");
        }

        private void five_Click(object sender, EventArgs e)
        {
            Number("5");
        }

        private void six_Click(object sender, EventArgs e)
        {
            Number("6");
        }

        private void seven_Click(object sender, EventArgs e)
        {
            Number("7");
        }

        private void eight_Click(object sender, EventArgs e)
        {
            Number("8");
        }

        private void nine_Click(object sender, EventArgs e)
        {
            Number("9");
        }

        private void zero_Click(object sender, EventArgs e)
        {
            Number("0");
        }

        //数字入力ここまで

        private void c_Click(object sender, EventArgs e)
        {
            siso.Text = "C";
            input = "";
            display.Text = input;
        }

        private void ac_Click(object sender, EventArgs e)
        {
            siso.Text = "AC";
            input = "";
            display.Text = input;
            result = 0;
            operation = "";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            siso.Text = "=";
            if (double.TryParse(input,out double num))
            {
                switch (operation)
                {
                    case "+":
                        result += num; 
                        break;
                    case "-":
                        result -= num;
                        break;
                    case "*":
                        result *= num;
                        break;
                    case "/":
                        if (num == 0)
                        {
                            display.Text = "infinity";
                            return;
                        }
                        else
                        {
                            result /= num;
                        }
                        break;
                    case "%":
                        result %= num;
                        break;
                    case "^":
                        result = Math.Pow(result,num);
                        break;

                }
                switch (f)
                {
                    case 1:
                        input = result.ToString("F1");
                        break;

                    case 2:
                        input = result.ToString("F2");
                        break;

                    case 3:
                        input = result.ToString("F3");
                        break;

                    case 4:
                        input = result.ToString("F4");
                        break;
                    default:
                        break;
                }
                
                if(input.Length > 17)
                {
                    display.Text = "Error";
                    return;
                }
                else
                {
                    display.Text = input;
                }
                    
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (!input.Contains("."))
            {
                input += ".";
                display.Text = input;
            }
        }


        private void setTheme(Color backColor,Color foreColor) //a:background,b:foreground
        {
            this.BackColor = backColor;
            display.BackColor = backColor;
            display.ForeColor = foreColor;
            display.Font = new Font("Consolas", 36) ;
            syousu.ForeColor = foreColor;
            menuStrip1.ForeColor = foreColor;
            menuStrip1.BackColor = backColor;
            menuStrip1.Font = new Font("Segoe UI", 10);
            siso.ForeColor = foreColor;
            foreach (Control ctrl in this.Controls){ //ボタンカラー
                if(ctrl is Button btn)
                {
                    btn.Font = new Font("Consolas", 18);
                    btn.BackColor = backColor;
                    btn.ForeColor = foreColor;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }
            }
        }

        private void ダークDToolStripMenuItem_Click(object sender, EventArgs e)
        {
           setTheme(Color.Black, Color.White);
        }

        private void ホワイトWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setTheme(Color.White, Color.Black);
        }

        private void ブルーBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setTheme(Color.LightBlue, Color.Navy);
        }

        private void 桁ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = 1;
            syousu.Text = "小数点以下：" + f + "桁";
        }

        private void 桁ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            f = 2;
            syousu.Text = "小数点以下：" + f + "桁";
        }

        private void 桁ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            f = 3;
            syousu.Text = "小数点以下：" + f + "桁";
        }

        private void 桁ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            f = 4;
            syousu.Text = "小数点以下：" + f + "桁";
        }

        private void par_Click(object sender, EventArgs e)
        {
            siso.Text = "%";
            ope("%");
        }

        private void squared_Click(object sender, EventArgs e)
        {
            siso.Text = "^";
            ope("^");
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            if (double.TryParse(input, out double num))
            {
                result = Math.Sqrt(num);
                switch (f)
                {
                    case 1:
                        input = result.ToString("F1");
                        break;
                    case 2:
                        input = result.ToString("F2");
                        break;
                    case 3:
                        input = result.ToString("F3");
                        break;
                    case 4:
                        input = result.ToString("F4");
                        break;
                    default:
                        input = result.ToString();
                        break;
                }
                display.Text = input;
                flag = true;
            }
        }

        private void sin_Click(object sender, EventArgs e)
        {
            if(double.TryParse(input, out double num))
            {
                if (dr == 0)
                {
                    num = num * Math.PI / 180;
                }
                result = Math.Sin(num);
                
                switch (f)
                {
                    case 1:
                        input = result.ToString("F1");
                        break;
                    case 2:
                        input = result.ToString("F2");
                        break;
                    case 3:
                        input = result.ToString("F3");
                        break;
                    case 4:
                        input = result.ToString("F4");
                        break;
                    default:
                        input = result.ToString();
                        break;
                }
                display.Text = input;
                flag = true;
            }
        }

        private void cos_Click(object sender, EventArgs e)
        {
            if (double.TryParse(input, out double num))
            {
                if (dr == 0)
                {
                    num = num * Math.PI / 180;
                }
                result = Math.Cos(num);
                
                switch (f)
                {
                    case 1:
                        input = result.ToString("F1");
                        break;
                    case 2:
                        input = result.ToString("F2");
                        break;
                    case 3:
                        input = result.ToString("F3");
                        break;
                    case 4:
                        input = result.ToString("F4");
                        break;
                    default:
                        input = result.ToString();
                        break;
                }
                display.Text = input;
                flag = true;
            }
        }

        private void tan_Click(object sender, EventArgs e)
        {
            if (double.TryParse(input, out double num))
            {
                if (dr == 0)
                {
                    num = num * Math.PI / 180;
                }

                if (dr == 0 && (num % 180 == 90))
                {
                    display.Text = "Error";
                    return;

                }

                result = Math.Tan(num);
                

                switch (f)
                {
                    case 1:
                        input = result.ToString("F1");
                        break;
                    case 2:
                        input = result.ToString("F2");
                        break;
                    case 3:
                        input = result.ToString("F3");
                        break;
                    case 4:
                        input = result.ToString("F4");
                        break;
                    default:
                        input = result.ToString();
                        break;
                }
                display.Text = input;
                flag = true;
            }
        }

        private void log10_Click(object sender, EventArgs e)
        {
            if (double.TryParse(input, out double num))
            {
                if(input != "0")
                {
                    result = Math.Log10(num);
                }
                else
                {
                    display.Text = "Error";
                    return;
                }
                    switch (f)
                    {
                        case 1:
                            input = result.ToString("F1");
                            break;
                        case 2:
                            input = result.ToString("F2");
                            break;
                        case 3:
                            input = result.ToString("F3");
                            break;
                        case 4:
                            input = result.ToString("F4");
                            break;
                        default:
                            input = result.ToString();
                            break;
                    }
                display.Text = input;
                flag = true;
            }
        }

        private void 度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dr = 0;
        }

        private void ラジアンradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dr = 1;
        }

        private void back_Click(object sender, EventArgs e)
        {
            if(input.Length > 0)
            {
                input = input.Substring(0, input.Length - 1);
                display.Text = input;
            }
        }

        private void gya_Click(object sender, EventArgs e)
        {
            if (double.TryParse(input, out double num))
            {
                result = 1 / num;
                switch (f)
                {
                    case 1:
                        input = result.ToString("F1");
                        break;
                    case 2:
                        input = result.ToString("F2");
                        break;
                    case 3:
                        input = result.ToString("F3");
                        break;
                    case 4:
                        input = result.ToString("F4");
                        break;
                    default:
                        input = result.ToString();
                        break;
                }
                display.Text = input;
            }
        }

      



        //関数

        private void Number(string num)
        {
            if (flag)
            {
                input = "";
                flag = false;
            }
            input += num;
            display.Text = input;
        }

        private void ope(string op)
        {
            if (double.TryParse(input, out double num))
            {
                result = num;
                operation = op;
                flag = true;
            }
        }
    }


}
