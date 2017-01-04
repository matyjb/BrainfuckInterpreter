using System;
using System.Linq;
using System.Windows.Forms;

namespace BrainfuckWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bCompile_Click(object sender, EventArgs e)
        {
            outputBox.Text = BrainfuckToString.Execute(codeBox.Text, inputBox.Text);
        }

        private void bHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(">   increment pointer\n<   decrement pointer\n+   increment value at pointer\n-   decrement value at pointer\n[   begin loop(continues while value at pointer is non - zero)\n]   end loop\n,   read one character from input into value at pointer\n.   print value at pointer to output as a character\n        Any other characters are ignored.");
        }
    }
    public class BrainfuckToString
    {


        private static bool CheckCode(string code)
        {

            //+check loops
            //+check inf loops
            return true;
        }


        private static byte[] InitializeCells(int from, int to, out int startcell)
        {

            int size = Math.Abs(from) + Math.Abs(to) + 1;
            startcell = Math.Abs(from);
            return new byte[size];

        }

        public static string Execute(string code, string input)
        {

            int pointerCell = 0;
            int pointerString = 0;
            byte[] cells = new byte[1] { 0 };
            string output = "";
            CheckCode(code); //Repair/message/something
            //int from = code.Count(f => f == '<'), to = code.Count(f => f == '>');
            //cells = InitializeCells(from, to, out pointerCell);

            //MAINLOOP
            while (pointerString < code.Length)
            {
                //if (pointerCell >= cells.Length)
                //{
                //    Array.Resize(ref cells, cells.Length + 1);
                //}
                //else if (pointerCell < 0)
                //{
                //    Array.Resize(ref cells, cells.Length + 1);
                //    for (int i = cells.Length - 1; i > 0; i--)
                //        cells[i] = cells[i - 1];
                //    cells[0] = 0;
                //    pointerCell++;
                //}

                switch (code[pointerString])
                {
                    case '+':
                        cells[pointerCell]++;
                        break;
                    case '-':
                        cells[pointerCell]--;
                        break;
                    case '<':
                        pointerCell--;
                        if(pointerCell < 0)
                        {
                            Array.Resize(ref cells, cells.Length + 1);
                            for (int i = cells.Length - 1; i > 0; i--)
                                cells[i] = cells[i - 1];
                            cells[0] = 0;
                            pointerCell = 0;
                        }
                        break;
                    case '>':
                        pointerCell++;
                        Array.Resize(ref cells, cells.Length + 1);
                        cells[cells.Length - 1] = 0;
                        break;
                    case ',':
                        if (input == "")
                        {
                            cells[pointerCell] = 0;
                        }
                        else
                        {
                            cells[pointerCell] = Convert.ToByte(input[0]);
                            input = input.Remove(0, 1);
                        }
                        break;
                    case '.':
                        output += Convert.ToChar(cells[pointerCell]);
                        break;
                    case ']':
                        if (cells[pointerCell] != 0)
                        {
                            int a = 1;
                            do
                            {
                                pointerString--;
                                if (code[pointerString] == ']')
                                    a++;
                                if (code[pointerString] == '[')
                                    a--;
                            } while (a != 0);
                        }
                        break;
                }
                pointerString++;
            }





            return output;
        }
    }

}
