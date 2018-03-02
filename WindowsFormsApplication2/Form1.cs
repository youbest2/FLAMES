using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication2
{
    public partial class FLAMES : Form
    {
        // declerations
        String string1, string2;
        String string11, string22;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();



        public FLAMES()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> firststring = new Dictionary<string, int>();
            Dictionary<string, int> secondstring = new Dictionary<string, int>();
            foreach (char c in string1)
            {
                if (!firststring.ContainsKey(c.ToString()) && c != ' ')
                    firststring.Add(c.ToString(), 1);
                else
                {
                  int count = firststring[c.ToString()];
                  firststring.Remove(c.ToString());
                  if ( c != ' ')
                  firststring.Add(c.ToString(), count+1);
                }
            }

            foreach (char c in string2)
            {
                if (!secondstring.ContainsKey(c.ToString()) && c != ' ')
                    secondstring.Add(c.ToString(), 1);
                else
                {
                    int count = secondstring[c.ToString()];
                    secondstring.Remove(c.ToString());
                    if (c != ' ')
                    secondstring.Add(c.ToString(), count + 1);
                }
            }
            int maxcount = 0;
            int totalcount = 0;
            for (int i = 0; i < firststring.Count(); i++)
            {
                string firstname = firststring.Keys.ElementAt(i);
                if(secondstring.ContainsKey(firstname))
                    totalcount = totalcount + (Math.Abs(secondstring[firstname]-firststring[firstname]));
                else
                    totalcount = totalcount + firststring[firstname];
          
            }

            for (int i = 0; i < secondstring.Count(); i++)
            {
                string firstname = secondstring.Keys.ElementAt(i);
                if (!firststring.ContainsKey(firstname))
                    totalcount = totalcount + secondstring[firstname];

            }

            textBox3.Text = totalcount.ToString();
            int Sum = totalcount;
            switch (Sum)
            {
                case 1:
                    ///	1	S
                    textBox4.Text = "S";
                    break;

                case 2:
                    ///	2	E
                    textBox4.Text = "E";
                    break;

                case 3:
                    ///	3	F
                    textBox4.Text = "F";
                    break;

                case 4:
                    ///	4	E
                    textBox4.Text = "E";
                    break;
                case 5:
                    ///	5	F
                    textBox4.Text = "F";
                    break;

                case 6:
                    ///	6	M
                    textBox4.Text = "M";
                    break;

                case 7:
                    ///	7	E
                    textBox4.Text = "E";
                    break;

                case 8:
                    ///	8	A
                    textBox4.Text = "A";
                    break;

                case 9:
                    ///	9	E
                    textBox4.Text = "E";
                    break;

                case 10:
                    ///	10	L
                    textBox4.Text = "L";
                    break;

                case 11:
                    ///	11	M
                    textBox4.Text = "M";
                    break;

                case 12:
                    ///	12	A
                    textBox4.Text = "A";
                    break;

                case 13:
                    ///	13	A
                    textBox4.Text = "A";
                    break;

                case 14:
                    ///	14	F
                    textBox4.Text = "F";
                    break;

                case 15:
                    ///	15	M
                    textBox4.Text = "M";
                    break;

                case 16:
                    ///	16	F
                    textBox4.Text = "F";
                    break;

                case 17:
                    ///	17	A
                    textBox4.Text = "A";
                    break;

                case 18:
                    ///	18	F
                    textBox4.Text = "F";
                    break;

                case 19:
                    ///	19	F
                    textBox4.Text = "F";
                    break;

                case 20:
                    ///	20	E
                    textBox4.Text = "E";
                    break;

                case 21:
                    ///	21	F
                    textBox4.Text = "F";
                    break;



                default:
                    textBox4.Text = "NoMatch";
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string11 = textBox1.Text;
            string1 = string11.ToUpper().Replace(" ", string.Empty);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string22 = textBox2.Text;
            string2 = string22.ToUpper().Replace(" ", string.Empty);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RESULTS"+ Environment.NewLine + "F = Friend" + Environment.NewLine + "L = Love" + Environment.NewLine + "A = Affection" + Environment.NewLine + "M = Marriage" + Environment.NewLine + "E = Enemy" + Environment.NewLine + "S = sister");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
