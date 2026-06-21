using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Input;
using System.Numerics;
using System.Web.UI.DataVisualization.Charting;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-Us");
        }
        decimal? Temp;
        decimal a, b = 1;
        bool Equal, del_arithmetic, three_brothers, visual, is_Decimal;
        char[] signs = new char[] { 'π', '!', '√', '%', '℮', 'S', 'C', 'T', 'l', '^', 'g' };
        char[] arithmetics = new char[] { '+', '−', '×', '÷' };



        #region Functions
        private void Conditions(int n = 1)
        {
            try
            {
                if (del_arithmetic)
                {
                    textBox2.Clear();
                    del_arithmetic = false;
                }
                if (textBox2.Text != "") decimal.Parse(textBox2.Text);
            }
            catch (Exception)
            {
                textBox2.Text = NumberFormatChanger(textBox2.Text);
            }
            if (textBox2.Text != "" && textBox2.Text.Last() == '.') is_Decimal = true;
            if (Equal)
            {
                textBox1.Clear();
                Equal = false;
                if (n == 0 || n == 2)
                { 
                    textBox2.Clear();
                    Clear.Text = "CE";
                }
            }

            #region Power
            if (!three_brothers && textBox1.Text.LastIndexOfAny(new char[] { '^', '√', 'g' }) != -1 && (textBox1.Text.LastIndexOfAny(arithmetics) > textBox1.Text.LastIndexOfAny(new char[] { '^', '√', 'g' })))
            {
                textBox1.Text = textBox1.Text.Insert(textBox1.Text.LastIndexOfAny(arithmetics), textBox2.Text);
                a = textBox1.Text.Substring(0, textBox1.Text.LastIndexOfAny(arithmetics)).LastIndexOfAny(arithmetics) + 1;
                if (Power.Text == "x^y")
                {
                    textBox2.Text = Math.Pow(double.Parse(textBox1.Text.Substring((int)a, textBox1.Text.LastIndexOf('^') - (int)a)), double.Parse(textBox2.Text)).ToString();
                }
                else if (Power.Text == "y^√x")
                {
                    textBox2.Text = Math.Pow(double.Parse(textBox2.Text), 1.0 / double.Parse(textBox1.Text.Substring((int)a, textBox1.Text.LastIndexOf('√') - 1 - (int)a))).ToString();
                }
                else if (Power.Text == "ylog(x)")
                {
                    textBox2.Text = Math.Log(double.Parse(textBox2.Text), double.Parse(textBox1.Text.Substring((int)a, textBox1.Text.LastIndexOf('g') - 2 - (int)a))).ToString();
                    textBox1.Text = textBox1.Text.Insert(textBox1.Text.LastIndexOfAny(arithmetics), ")");
                }
                a = (textBox2.Text == "") ? 0 : decimal.Parse(textBox2.Text);
                three_brothers = true;
            }
            #endregion
            else
            {
                a = (textBox2.Text == "") ? 0 : decimal.Parse(textBox2.Text);
                textBox2.Text = (textBox1.Text.LastIndexOfAny(arithmetics) >= textBox1.Text.LastIndexOfAny(signs)) ? a.ToString() : "";
            }
            if (is_Decimal)
            {
                textBox2.Text += '.';
                is_Decimal = false;
            }
            Clear.Text = "C";
        }

        private static double Radian(object Degree)
        {
            return Convert.ToDouble(Degree) * 3.1415926535897932384626433833 / 180;      
        }

        private static double Degree(object Radian)
        {
            return Convert.ToDouble(Radian) * 180 / 3.1415926535897932384626433833;
        }

        public static string NumberFormatChanger(string txt)
        {
            char[] PersianFontError = new char[20] { '۱', '۲', '۳', '۴', '۵', '۶', '۷', '۸', '۹', '۰', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            int count = txt.Count(a => a == '.');
            int index_num, j = txt.Length;

            for (int i = 0; i <= j - 1; i++)
            {
                if (count >= 2 && txt[i] == '.')
                {
                    count = 1;
                    txt += '.';
                }
                else if (PersianFontError.Contains(txt[i]))
                {
                    index_num = Array.IndexOf(PersianFontError, txt[i]);
                    index_num = (index_num <= 9) ? (10 + index_num) : index_num;
                    txt += PersianFontError[index_num];
                }
            }
            return txt.Substring(j, txt.Length - j);
        }

        private void operation()
        {
            char c = default;
            Conditions();
            if (visual)
            {
                c = textBox1.Text.Last();
                textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
            }
            if (Temp != null || textBox1.Text.LastIndexOfAny(new char[] { arithmetics[2], arithmetics[3] }) != -1)
            {
                if (textBox1.Text[textBox1.Text.LastIndexOfAny(arithmetics)] == arithmetics[0])
                {
                    Temp += a;
                    textBox2.Text = Temp.ToString();
                }
                else if (textBox1.Text[textBox1.Text.LastIndexOfAny(arithmetics)] == arithmetics[1])
                {
                    Temp -= a;
                    textBox2.Text = Temp.ToString();
                }
                else if (textBox1.Text[textBox1.Text.LastIndexOfAny(arithmetics)] == arithmetics[2])
                {
                    b *= (textBox1.Text.Substring(0,textBox1.Text.LastIndexOf(arithmetics[2])).LastIndexOf(arithmetics[1]) != -1 && b > 0) ? -a : a;
                    textBox2.Text = b.ToString();
                }
                else if (textBox1.Text[textBox1.Text.LastIndexOfAny(arithmetics)] == arithmetics[3])
                {
                    if (b == 1) b = (textBox1.Text.Substring(0, textBox1.Text.LastIndexOf(arithmetics[3])).LastIndexOf(arithmetics[1]) != -1 && b > 0) ? -a : a;
                    else b /= (textBox1.Text.Substring(0, textBox1.Text.LastIndexOf(arithmetics[3])).LastIndexOf(arithmetics[1]) != -1 && b > 0) ? -a : a;
                    textBox2.Text = b.ToString();
                }
            }
            else
            {
                Temp = a;
            }
            if (visual)
            {
                textBox1.Text += c;
                visual = false;
            }

            del_arithmetic = true;
        }
        #endregion

        #region Right click
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Copy();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Paste();
        }
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox2.SelectionLength > 0)
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.SelectionStart, textBox2.SelectionLength);
            }
        }
        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }
        #endregion

        #region Skin

        //#region Defualt
        private void deualtToolStripMenuItem_Click(object sender, EventArgs e) { }
        //{
        //    this.BackColor = SystemColors.Control;

        //    Equals.BackColor = SystemColors.Control;
        //    Addition.BackColor = SystemColors.Control;
        //    Subtraction.BackColor = SystemColors.Control;
        //    Multiplication.BackColor = SystemColors.Control;
        //    Division.BackColor = SystemColors.Control;
        //    Backspace.BackColor = SystemColors.Control;
        //    this.e.BackColor = SystemColors.Control;
        //    π.BackColor = SystemColors.Control;
        //    Factorial.BackColor = SystemColors.Control;
        //    Root.BackColor = SystemColors.Control;
        //    Percentage.BackColor = SystemColors.Control;
        //    Power.BackColor = SystemColors.Control;
        //    Clear.BackColor = SystemColors.Control;


        //    Decimal.BackColor = SystemColors.Control;
        //    num0.BackColor = SystemColors.Control;
        //    num1.BackColor = SystemColors.Control;
        //    num2.BackColor = SystemColors.Control;
        //    num3.BackColor = SystemColors.Control;
        //    num4.BackColor = SystemColors.Control;
        //    num5.BackColor = SystemColors.Control;
        //    num6.BackColor = SystemColors.Control;
        //    num7.BackColor = SystemColors.Control;
        //    num8.BackColor = SystemColors.Control;
        //    num9.BackColor = SystemColors.Control;
        //    Negetive.BackColor = SystemColors.Control;

        //    textBox1.BackColor = SystemColors.Control;
        //    textBox2.BackColor = SystemColors.Control;

        //    Equals.ForeColor = Color.Black;
        //    Addition.ForeColor = Color.Black;
        //    Subtraction.ForeColor = Color.Black;
        //    Multiplication.ForeColor = Color.Black;
        //    Division.ForeColor = Color.Black;
        //    Backspace.ForeColor = Color.Black;
        //    this.e.ForeColor = Color.Black;
        //    π.ForeColor = Color.Black;
        //    Factorial.ForeColor = Color.Black;
        //    Root.ForeColor = Color.Black;
        //    Percentage.ForeColor = Color.Black;
        //    Power.ForeColor = Color.Black;
        //    Clear.ForeColor = Color.Black;

        //    Decimal.ForeColor = Color.Black;
        //    num0.ForeColor = Color.Black;
        //    num1.ForeColor = Color.Black;
        //    num2.ForeColor = Color.Black;
        //    num3.ForeColor = Color.Black;
        //    num4.ForeColor = Color.Black;
        //    num5.ForeColor = Color.Black;
        //    num6.ForeColor = Color.Black;
        //    num7.ForeColor = Color.Black;
        //    num8.ForeColor = Color.Black;
        //    num9.ForeColor = Color.Black;
        //    Negetive.ForeColor = Color.Black;
        //    textBox1.ForeColor = Color.Black;
        //    textBox2.ForeColor = Color.Black;
        //}
        //#endregion

        //#region Dark
        private void dToolStripMenuItem_Click(object sender, EventArgs e) { }
        //{
        //    this.BackColor = Color.DimGray;

        //    Equals.BackColor = Color.SaddleBrown;
        //    Addition.BackColor = Color.FromArgb(64, 64, 64);
        //    Subtraction.BackColor = Color.FromArgb(64, 64, 64);
        //    Multiplication.BackColor = Color.FromArgb(64, 64, 64);
        //    Division.BackColor = Color.FromArgb(64, 64, 64);
        //    Backspace.BackColor = Color.FromArgb(64, 64, 64);
        //    this.e.BackColor = Color.FromArgb(64, 64, 64);
        //    π.BackColor = Color.FromArgb(64, 64, 64);
        //    Factorial.BackColor = Color.FromArgb(64, 64, 64);
        //    Root.BackColor = Color.FromArgb(64, 64, 64);
        //    Percentage.BackColor = Color.FromArgb(64, 64, 64);
        //    Power.BackColor = Color.FromArgb(64, 64, 64);
        //    Clear.BackColor = Color.FromArgb(64, 64, 64);


        //    Decimal.BackColor = Color.Black;
        //    num0.BackColor = Color.Black;
        //    num1.BackColor = Color.Black;
        //    num2.BackColor = Color.Black;
        //    num3.BackColor = Color.Black;
        //    num4.BackColor = Color.Black;
        //    num5.BackColor = Color.Black;
        //    num6.BackColor = Color.Black;
        //    num7.BackColor = Color.Black;
        //    num8.BackColor = Color.Black;
        //    num9.BackColor = Color.Black;
        //    Negetive.BackColor = Color.Black;

        //    textBox1.BackColor = Color.DimGray;
        //    textBox2.BackColor = Color.DimGray;

        //    Equals.ForeColor = Color.White;
        //    Addition.ForeColor = Color.White;
        //    Subtraction.ForeColor = Color.White;
        //    Multiplication.ForeColor = Color.White;
        //    Division.ForeColor = Color.White;
        //    Backspace.ForeColor = Color.White;
        //    this.e.ForeColor = Color.White;
        //    π.ForeColor = Color.White;
        //    Factorial.ForeColor = Color.White;
        //    Root.ForeColor = Color.White;
        //    Percentage.ForeColor = Color.White;
        //    Power.ForeColor = Color.White;
        //    Clear.ForeColor = Color.White;

        //    Decimal.ForeColor = Color.White;
        //    num0.ForeColor = Color.White;
        //    num1.ForeColor = Color.White;
        //    num2.ForeColor = Color.White;
        //    num3.ForeColor = Color.White;
        //    num4.ForeColor = Color.White;
        //    num5.ForeColor = Color.White;
        //    num6.ForeColor = Color.White;
        //    num7.ForeColor = Color.White;
        //    num8.ForeColor = Color.White;
        //    num9.ForeColor = Color.White;
        //    Negetive.ForeColor = Color.White;
        //    textBox1.ForeColor = Color.White;
        //    textBox2.ForeColor = Color.White;

        //}
        //#endregion

        //#region White
        private void whiteToolStripMenuItem_Click(object sender, EventArgs e) { }
        //{
        //    this.BackColor = System.Drawing.Color.White;

        //    Equals.BackColor = Color.FromArgb(0, 102, 204);
        //    Addition.BackColor = Color.White;
        //    Subtraction.BackColor = Color.White;
        //    Multiplication.BackColor = Color.White;
        //    Division.BackColor = Color.White;
        //    Backspace.BackColor = Color.White;
        //    this.e.BackColor = Color.White;
        //    π.BackColor = Color.White;
        //    Factorial.BackColor = Color.White;
        //    Root.BackColor = Color.White;
        //    Percentage.BackColor = Color.White;
        //    Power.BackColor = Color.White;
        //    Clear.BackColor = Color.White;


        //    Decimal.BackColor = Color.FromArgb(229, 228, 226);
        //    num0.BackColor = Color.FromArgb(229, 228, 226);
        //    num1.BackColor = Color.FromArgb(229, 228, 226);
        //    num2.BackColor = Color.FromArgb(229, 228, 226);
        //    num3.BackColor = Color.FromArgb(229, 228, 226);
        //    num4.BackColor = Color.FromArgb(229, 228, 226);
        //    num5.BackColor = Color.FromArgb(229, 228, 226);
        //    num6.BackColor = Color.FromArgb(229, 228, 226);
        //    num7.BackColor = Color.FromArgb(229, 228, 226);
        //    num8.BackColor = Color.FromArgb(229, 228, 226);
        //    num9.BackColor = Color.FromArgb(229, 228, 226);
        //    Negetive.BackColor = Color.FromArgb(229, 228, 226);

        //    textBox1.BackColor = Color.White;
        //    textBox2.BackColor = Color.White;

        //    Equals.ForeColor = Color.White;
        //    Addition.ForeColor = Color.Black;
        //    Subtraction.ForeColor = Color.Black;
        //    Multiplication.ForeColor = Color.Black;
        //    Division.ForeColor = Color.Black;
        //    Backspace.ForeColor = Color.Black;
        //    this.e.ForeColor = Color.Black;
        //    π.ForeColor = Color.Black;
        //    Factorial.ForeColor = Color.Black;
        //    Root.ForeColor = Color.Black;
        //    Percentage.ForeColor = Color.Black;
        //    Power.ForeColor = Color.Black;
        //    Clear.ForeColor = Color.Black;

        //    Decimal.ForeColor = Color.Black;
        //    num0.ForeColor = Color.Black;
        //    num1.ForeColor = Color.Black;
        //    num2.ForeColor = Color.Black;
        //    num3.ForeColor = Color.Black;
        //    num4.ForeColor = Color.Black;
        //    num5.ForeColor = Color.Black;
        //    num6.ForeColor = Color.Black;
        //    num7.ForeColor = Color.Black;
        //    num8.ForeColor = Color.Black;
        //    num9.ForeColor = Color.Black;
        //    Negetive.ForeColor = Color.Black;
        //    textBox1.ForeColor = Color.Black;
        //    textBox2.ForeColor = Color.Black;
        //}
        //#endregion

        #endregion

        #region Numbers
        private void button_0(object sender, EventArgs e)
        {
            Conditions(0);
            textBox2.Text += 0;
            textBox2.Text = decimal.Parse(textBox2.Text).ToString();
        }
        private void button_1(object sender, EventArgs e)
        {
            Conditions(0);
            textBox2.Text += 1;
            textBox2.Text = decimal.Parse(textBox2.Text).ToString();
        }
        private void button_2(object sender, EventArgs e)
        {
            Conditions(0);
            textBox2.Text += 2;
            textBox2.Text = decimal.Parse(textBox2.Text).ToString();
        }
        private void button_3(object sender, EventArgs e)
        {
            Conditions(0);
            textBox2.Text += 3;
            textBox2.Text = decimal.Parse(textBox2.Text).ToString();
        }
        private void button_4(object sender, EventArgs e)
        {
            Conditions(0);
            textBox2.Text += 4;
            textBox2.Text = decimal.Parse(textBox2.Text).ToString();
        }
        private void button_5(object sender, EventArgs e)
        {
            Conditions(0);
            textBox2.Text += 5;
            textBox2.Text = decimal.Parse(textBox2.Text).ToString();
        }
        private void button_6(object sender, EventArgs e)
        {
            Conditions(0);
            textBox2.Text += 6;
            textBox2.Text = decimal.Parse(textBox2.Text).ToString();
        }
        private void button_7(object sender, EventArgs e)
        {
            Conditions(0);
            textBox2.Text += 7;
            textBox2.Text = decimal.Parse(textBox2.Text).ToString();
        }
        private void button_8(object sender, EventArgs e)
        {
            Conditions(0);
            textBox2.Text += 8;
            textBox2.Text = decimal.Parse(textBox2.Text).ToString();
        }
        private void button_9(object sender, EventArgs e)
        {
            Conditions(0);
            textBox2.Text += 9;
            textBox2.Text = decimal.Parse(textBox2.Text).ToString();
        }
        #endregion

        #region KeyPress
        private void KeyPress_Event(object sender, KeyPressEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.NumPad0))
            {
                num0.PerformClick();
            }
            if (Keyboard.IsKeyDown(Key.NumPad1))
            {
                num1.PerformClick();
            }
            if (Keyboard.IsKeyDown(Key.NumPad2))
            {
                num2.PerformClick();
            }
            if (Keyboard.IsKeyDown(Key.NumPad3))
            {
                num3.PerformClick();
            }
            if (Keyboard.IsKeyDown(Key.NumPad4))
            {
                num4.PerformClick();
            }
            if (Keyboard.IsKeyDown(Key.NumPad5))
            {
                num5.PerformClick();
            }
            if (Keyboard.IsKeyDown(Key.NumPad6))
            {
                num6.PerformClick();
            }
            if (Keyboard.IsKeyDown(Key.NumPad7))
            {
                num7.PerformClick();
            }
            if (Keyboard.IsKeyDown(Key.NumPad8))
            {
                num8.PerformClick();
            }
            if (Keyboard.IsKeyDown(Key.NumPad9))
            {
                num9.PerformClick();
            }
            if (Keyboard.IsKeyDown(Key.Decimal))
            {
                Decimal.PerformClick();
            }
            if (Keyboard.IsKeyDown(Key.Back))
            {
                Backspace.PerformClick();
            }
            if (Keyboard.IsKeyDown(Key.Add))
            {
                Addition.PerformClick();
            }
            if (Keyboard.IsKeyDown(Key.Subtract))
            {
                Subtraction.PerformClick();
            }
            if (Keyboard.IsKeyDown(Key.Multiply))
            {
                Multiplication.PerformClick();
            }
            if (Keyboard.IsKeyDown(Key.Divide))
            {
                Division.PerformClick();
            }
            if (Keyboard.IsKeyDown(Key.Enter))
            {
                Equals.PerformClick();
            }
        }
        #endregion

        #region π
        private void button_π(object sender, EventArgs e)
        {
            Conditions(0);
            textBox1.Text += "π";
            textBox2.Text = "3.141592653589793238462643384";
        }
        #endregion

        #region ℮
        private void button_e(object sender, EventArgs e)
        {
            Conditions(0);
            textBox1.Text += "℮";
            textBox2.Text = "2.718281828459045235360287472";
        }
        #endregion

        #region Decimal point
        private void button_decimal(object sender, EventArgs e)
        {
            Conditions(0);
            if (!textBox2.Text.Contains('.'))
            {
                textBox2.Text = $"{decimal.Parse(textBox2.Text)}.";
            }
        }
        #endregion

        #region Addition
        private void button_Addition(object sender, EventArgs e)
        {
            visual = true;
            if (Equal) { textBox1.Clear(); Equal = false; }
            textBox1.Text += ((textBox1.Text.LastIndexOfAny(arithmetics) >= textBox1.Text.LastIndexOfAny(signs)) ? decimal.Parse(textBox2.Text).ToString() : "") + arithmetics[0];
            operation();
            if (b != 1)
            {
                Temp += b;
                textBox2.Text = Temp.ToString();
                b = 1;
            }
        }
        #endregion
        
        #region Subtraction
        private void button_Subtraction(object sender, EventArgs e)
        {
            visual = true;
            if (Equal) { textBox1.Clear(); Equal = false; }
            textBox1.Text += ((textBox1.Text.LastIndexOfAny(arithmetics) >= textBox1.Text.LastIndexOfAny(signs)) ? decimal.Parse(textBox2.Text).ToString() : "") + arithmetics[1];
            operation();
            if (b != 1)
            {
                Temp += b;
                textBox2.Text = Temp.ToString();
                b = 1;
            }
        }
        #endregion

        #region Multiplication
        private void button_Multiplication(object sender, EventArgs e)
        {
            textBox1.Text += ((textBox1.Text.LastIndexOfAny(arithmetics) >= textBox1.Text.LastIndexOfAny(signs)) ? decimal.Parse(textBox2.Text).ToString() : "") + arithmetics[2];
            operation();
        }
        #endregion

        #region Division
        private void button_Division(object sender, EventArgs e)
        {
            textBox1.Text += ((textBox1.Text.LastIndexOfAny(arithmetics) >= textBox1.Text.LastIndexOfAny(signs)) ? decimal.Parse(textBox2.Text).ToString() : "") + arithmetics[3];
            operation();
        }
        #endregion

        #region Equals
        private void button_Equal(object sender, EventArgs e)
        {
            if (del_arithmetic)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
                del_arithmetic = false;
            }
            else if (!Equal && textBox1.Text.LastIndexOfAny(arithmetics) != -1)
            {
                a = (textBox2.Text == "") ? 0 : decimal.Parse(textBox2.Text);

                textBox2.Text = (textBox1.Text.LastIndexOfAny(arithmetics) >= textBox1.Text.LastIndexOfAny(signs)) ? a.ToString() : "";

                textBox1.Text += textBox2.Text;
                if (Temp == null) Temp = 0;
                try
                {
                    if (textBox1.Text[textBox1.Text.LastIndexOfAny(arithmetics)] == arithmetics[0]) Temp += a;
                    else if (textBox1.Text[textBox1.Text.LastIndexOfAny(arithmetics)] == arithmetics[1]) Temp -= a;
                    else if (textBox1.Text[textBox1.Text.LastIndexOfAny(arithmetics)] == arithmetics[2]) b *= a;
                    else if (textBox1.Text[textBox1.Text.LastIndexOfAny(arithmetics)] == arithmetics[3]) b /= a;
                    if (b != 1)
                    {
                        Temp += b;
                        b = 1;
                    }
                    textBox2.Text = Temp.ToString();
                }
                catch (DivideByZeroException)
                {
                    textBox2.Text = "Can't Divide by Zero!";
                }
            }
            Temp = null;
            Equal = true;
        }
        #endregion


        #region Clear
        private void button_Clear(object sender, EventArgs e)
        {
            if (Clear.Text == "C")
            {
                Temp = null;
                b = 1;
                Equal = false;
                del_arithmetic = false;
                three_brothers = false;
                visual = false;
                textBox1.Clear();
                textBox2.Clear();
            }
            else if (Clear.Text == "CE")
            {
                if (Equal)
                {
                    Equal = false;
                    del_arithmetic = false;
                    three_brothers = false;
                    visual = false;
                    textBox1.Clear();
                    textBox2.Clear();
                }

                if (textBox1.Text.LastIndexOfAny(arithmetics) >= textBox1.Text.LastIndexOfAny(signs))
                {
                    textBox2.Clear();
                }
                else
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.LastIndexOfAny(arithmetics) + 1);
                    textBox2.Clear();
                }
                Clear.Text = "C";
            }
        }
        #endregion
        
        #region Backspace
        private void button_Backspace(object sender, EventArgs e)
        {
            Conditions(0);
            if (textBox2.Text != "")
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.TextLength - 1);
            }
        }
        #endregion
        
        #region Negative
        private void button21_Click(object sender, EventArgs e)
        {
            Conditions(0);
            if (textBox1.Text.LastIndexOfAny(signs) != -1 && (textBox1.Text.LastIndexOfAny(arithmetics) < textBox1.Text.LastIndexOfAny(signs))) textBox1.Text=textBox1.Text.Insert(textBox1.Text.LastIndexOfAny(arithmetics) + 1, "-");
            textBox2.Text = (a * -1).ToString();
        }
        #endregion

        #region Factorial
        private void button_Factorial(object sender, EventArgs e)
        {
            Conditions(0);
            if (a >= 0)
            {
                textBox1.Text += ((textBox1.Text.LastIndexOfAny(signs) != -1) ? "" : a.ToString()) + '!';
                textBox2.Text = new Chart().DataManipulator.Statistics.GammaFunction((double)a + 1).ToString();
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.LastIndexOfAny(arithmetics) + 1);
                textBox2.Text = "Negative Gamma Error!";
            }
        }
        #endregion

        #region Percentage
        private void button_Percentage(object sender, EventArgs e)
        {
        }
        #endregion

        #region Power
        private void button_Power(object sender, EventArgs e)
        {
            Conditions(0);
            if (Power.Text == "x^y")
            {
                textBox1.Text += textBox2.Text + '^';
            }
            else if (Power.Text == "y^√x")
            {
                textBox1.Text += textBox2.Text + "^√";
            }
            else if (Power.Text == "ylog(x)")
            {
                textBox1.Text += textBox2.Text + "log(";
            }
            three_brothers = false;
        }
        #endregion

        #region Exponential Function
        private void exp_Click(object sender, EventArgs e)
        {
            Conditions(0);
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.LastIndexOfAny(arithmetics) + 1)+((textBox1.Text.LastIndexOfAny(arithmetics) != -1 && (textBox1.Text.LastIndexOfAny(arithmetics) < textBox1.Text.LastIndexOfAny(signs))) ? textBox1.Text.Remove(textBox1.Text.LastIndexOfAny(arithmetics) + 1) : "") + "exp(" + ((textBox1.Text.LastIndexOfAny(signs) != -1 && (textBox1.Text.LastIndexOfAny(arithmetics) < textBox1.Text.LastIndexOfAny(signs))) ? textBox1.Text.Substring(textBox1.Text.LastIndexOfAny(arithmetics) + 1) : a.ToString()) + ')';
            textBox2.Text = Math.Exp((double)a).ToString();
        }
        #endregion

        #region Natural Logarithm
        private void ln_Click(object sender, EventArgs e)
        {
            Conditions(0);
            if (a >= 0)
            {
                textBox1.Text = textBox1.Text.Substring(0,textBox1.Text.LastIndexOfAny(arithmetics)+1) +((textBox1.Text.LastIndexOfAny(arithmetics) != -1 && (textBox1.Text.LastIndexOfAny(arithmetics) < textBox1.Text.LastIndexOfAny(signs))) ? textBox1.Text.Remove(textBox1.Text.LastIndexOfAny(arithmetics) + 1) : "") + "ln(" + ((textBox1.Text.LastIndexOfAny(signs) != -1 && (textBox1.Text.LastIndexOfAny(arithmetics) < textBox1.Text.LastIndexOfAny(signs))) ? textBox1.Text.Substring(textBox1.Text.LastIndexOfAny(arithmetics) + 1) : a.ToString()) + ')';
                textBox2.Text = Math.Log((double)a).ToString();
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.LastIndexOfAny(arithmetics) + 1);
                textBox2.Text = "Negative Natural Logarithm Error!";
            }
        }
        #endregion

        #region Triangel

        #region Sinus
        private void Sinus(object sender, EventArgs e)
        {
            Conditions(0);
            textBox2.Text = (textBox1.Text.LastIndexOfAny(signs) != -1 && (textBox1.Text.LastIndexOfAny(arithmetics) < textBox1.Text.LastIndexOfAny(signs))) ? textBox1.Text.Substring(textBox1.Text.LastIndexOfAny(arithmetics) + 1) : a.ToString();
            textBox1.Text = (textBox1.Text.LastIndexOfAny(arithmetics) != -1 && (textBox1.Text.LastIndexOfAny(arithmetics) < textBox1.Text.LastIndexOfAny(signs))) ? textBox1.Text.Remove(textBox1.Text.LastIndexOfAny(arithmetics) + 1) : "";
            if (Sin.Text == "Sin")
            {
                textBox1.Text += "Sin(" + textBox2.Text + ')';
                textBox2.Text = Math.Round(Math.Sin(Radian(a)), 15).ToString();
            }
            else if (Sin.Text == "ArcSin")
            {
                textBox1.Text +=  "ArcSin(" + textBox2.Text + ')';
                textBox2.Text = Math.Round(Degree(Math.Asin((double)a)), 15).ToString();
            }
            else if (Sin.Text == "Sinh")
            {
                textBox1.Text += "Sinh(" + textBox2.Text + ')';
                textBox2.Text = Math.Round(Math.Sinh(Radian(a)), 15).ToString();
            }
        }
        #endregion

        #region CoSinus
        private void CoSinus(object sender, EventArgs e)
        {
            Conditions(0);
            textBox2.Text = (textBox1.Text.LastIndexOfAny(signs) != -1 && (textBox1.Text.LastIndexOfAny(arithmetics) < textBox1.Text.LastIndexOfAny(signs))) ? textBox1.Text.Substring(textBox1.Text.LastIndexOfAny(arithmetics) + 1) : a.ToString();
            textBox1.Text = (textBox1.Text.LastIndexOfAny(arithmetics) != -1 && (textBox1.Text.LastIndexOfAny(arithmetics) < textBox1.Text.LastIndexOfAny(signs))) ? textBox1.Text.Remove(textBox1.Text.LastIndexOfAny(arithmetics) + 1) : "";
            if (Cos.Text == "Cos")
            {
                textBox1.Text += "Cos(" + textBox2.Text + ')';
                textBox2.Text = Math.Round(Math.Cos(Radian(a)), 15).ToString();
            }
            else if (Cos.Text == "ArcCos")
            {
                textBox1.Text += "ArcCos(" + textBox2.Text + ')';
                textBox2.Text = Math.Round(Degree(Math.Acos((double)a)), 15).ToString();
            }
            else if (Cos.Text == "Cosh")
            {
                textBox1.Text += "Cosh(" + textBox2.Text + ')';
                textBox2.Text = Math.Round(Math.Cosh(Radian(a)), 15).ToString();
            }
        }
        #endregion

        #region Tangent
        private void Tangent(object sender, EventArgs e)
        {
            Conditions(0);
            textBox2.Text = (textBox1.Text.LastIndexOfAny(signs) != -1 && (textBox1.Text.LastIndexOfAny(arithmetics) < textBox1.Text.LastIndexOfAny(signs))) ? textBox1.Text.Substring(textBox1.Text.LastIndexOfAny(arithmetics) + 1) : a.ToString();
            textBox1.Text = (textBox1.Text.LastIndexOfAny(arithmetics) != -1 && (textBox1.Text.LastIndexOfAny(arithmetics) < textBox1.Text.LastIndexOfAny(signs))) ? textBox1.Text.Remove(textBox1.Text.LastIndexOfAny(arithmetics) + 1) : "";
            if (Tan.Text == "Tan")
            {
                textBox1.Text += "Tan(" + textBox2.Text + ')';
                textBox2.Text = Math.Round(Math.Tan(Radian(a)), 15).ToString();
            }
            else if (Tan.Text == "ArcTan")
            {
                textBox1.Text += "ArcTan(" + textBox2.Text + ')';
                textBox2.Text = Math.Round(Degree(Math.Atan((double)a)), 15).ToString();
            }
            else if (Tan.Text == "Tanh")
            {
                textBox1.Text+= "Tanh(" + textBox2.Text + ')';
                textBox2.Text = Math.Round(Math.Tanh(Radian(a)), 15).ToString();
            }
        }
        #endregion

        #region CoTangent
        private void CoTangent(object sender, EventArgs e)
        {
            Conditions(0);
            textBox2.Text = (textBox1.Text.LastIndexOfAny(signs) != -1 && (textBox1.Text.LastIndexOfAny(arithmetics) < textBox1.Text.LastIndexOfAny(signs))) ? textBox1.Text.Substring(textBox1.Text.LastIndexOfAny(arithmetics) + 1) : a.ToString();
            textBox1.Text = (textBox1.Text.LastIndexOfAny(arithmetics) != -1 && (textBox1.Text.LastIndexOfAny(arithmetics) < textBox1.Text.LastIndexOfAny(signs))) ? textBox1.Text.Remove(textBox1.Text.LastIndexOfAny(arithmetics) + 1) : "";
            if (Cot.Text == "Cot")
            {
                textBox1.Text += "Cot(" + textBox2.Text + ')';
                textBox2.Text = Math.Round(Math.Tan(Radian(a)) / 1, 15).ToString();
            }
            else if (Cot.Text == "ArcCot")
            {
                textBox1.Text += "ArcCot(" + textBox2.Text + ')';
                textBox2.Text = Math.Round(Degree(Math.Atan((double)a)) / 1, 15).ToString();
            }
            else if (Cot.Text == "Coth")
            {
                textBox1.Text+= "Coth(" + textBox2.Text + ')';
                textBox2.Text = Math.Round(Math.Tanh(Radian(a)) / 1, 15).ToString();
            }
        }
        #endregion

        #endregion

        #region State
        int n = 0;

        private void State(object sender, EventArgs e)
        {
            n += (n >= 2) ? -2 : 1;

            #region 0
            if (n == 0)
            {
                State_button.Text = "1st";
                Sin.Text = "Sin";
                Cos.Text = "Cos";
                Tan.Text = "Tan";
                Cot.Text = "Cot";
                Power.Text = "x^y";
                Power.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 178);
                Sin.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
                Cos.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
                Tan.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
                Cot.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 178);

            }
            #endregion

            #region 1
            else if (n == 1)
            {
                State_button.Text = "2nd";
                State_button.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
                Sin.Text = "ArcSin";
                Cos.Text = "ArcCos";
                Tan.Text = "ArcTan";
                Cot.Text = "ArcCot";
                Power.Text = "y^√x";
                Power.Font = new Font("Arial", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 178);
                Sin.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 178);
                Cos.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 178);
                Tan.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 178);
                Cot.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 178);
            }
            #endregion

            #region 2
            else if (n == 2)
            {
                State_button.Text = "3rd";
                State_button.Font = new Font("Arial", 24, FontStyle.Regular, GraphicsUnit.Point, 178);
                Sin.Text = "Sinh";
                Cos.Text = "Cosh";
                Tan.Text = "Tanh";
                Cot.Text = "Coth";
                Power.Text = "ylog(x)";
                Power.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 178);
                Sin.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 178);
                Cos.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 178);
                Tan.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 178);
                Cot.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 178);
            }
            #endregion
        }
        #endregion
    }
}
