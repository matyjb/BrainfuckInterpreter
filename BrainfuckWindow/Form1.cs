using System;
using System.Windows.Forms;

namespace BrainfuckWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bCompile_Click(object sender, EventArgs e)
        {
            outputBox.Text = BrainfuckInterpeter.Execute(codeBox.Text, inputBox.Text, (EOFRepresentation)comboBox1.SelectedIndex);
        }

        private void bHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(">   increment pointer\n" +
                "<   decrement pointer\n" +
                "+   increment value at pointer\n" +
                "-   decrement value at pointer\n" +
                "[   begin loop(continues while value at pointer is non - zero)\n" +
                "]   end loop\n,   read one character from input and put it into cell at pointer\n" +
                ".   print value at pointer to output as a character\n" +
                "        Any other character is ignored.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }

}
