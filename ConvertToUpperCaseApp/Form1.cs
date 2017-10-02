using System;
using System.IO;
using System.Windows.Forms;

namespace ConvertToUpperCaseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            var content = File.ReadAllText(openFileDialog1.FileName);
            File.WriteAllText(saveFileDialog1.FileName, content.ToUpper());
        }
    }
}
