using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerInformationApp
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

        private void btnClick_Click(object sender, EventArgs e)
        {
            var a = txtBoxName.Text;
            var b = textBox2.Text;
            var c = dateTimePicker1.Value.ToString("yyyy-mm-dd");
            var getinfo = $"{a} ; {b} ; {c}";
            MessageBox.Show(getinfo);

        }
    }
}
