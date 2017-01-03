using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            byte[] cells;
            string output = "";
            CheckCode(code); //Repair/message/something
            cells = InitializeCells(code.Count(f => f == '<'), code.Count(f => f == '>'), out pointerCell);

            //MAINLOOP
            while (pointerString < code.Length)
            {
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
                        break;
                    case '>':
                        pointerCell++;
                        break;
                    case ',':
                        if(input == "")
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
