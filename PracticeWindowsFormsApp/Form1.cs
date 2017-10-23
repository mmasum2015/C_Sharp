using PracticeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWindowsFormsApp
{
    
    public partial class Form1 : Form
    {
        private PracticeClasss praclass = new PracticeClasss();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var birthDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            
            
            var name =textBoxName.Text;
            var phone = textBoxPhone.Text;
            praclass.EnterDetails(birthDate, name, phone );
            labelView.Text = praclass.Greeting;
           // MessageBox.Show(praclass.Greeting);

            File.WriteAllText(@"C:\Users\Studerande\Desktop\CSharpClass\Csharp\PracticeWindowsFormsApp\TextPracticeFile.txt", praclass.Greeting);

            string[] lines = File.ReadAllLines(@"C:\Users\Studerande\Desktop\CSharpClass\Csharp\PracticeWindowsFormsApp\TextPracticeFile.txt");

            foreach (var line in lines)
            {
                MessageBox.Show("\t" + line);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // File.WriteAllText(@"C:\Users\Studerande\Desktop\CSharpClass\Csharp\PracticeWindowsFormsApp\TextPracticeFile.txt", praclass.Greeting);
            //string[] lines = File.ReadAllLines(@"C:\Users\Studerande\Desktop\CSharpClass\Csharp\PracticeWindowsFormsApp\TextPracticeFile.txt");

            //foreach (var line in lines)
            //{
            //    MessageBox.Show("\t" + line);
            //}

            var realdateofbirth = int.Parse(dateTimePicker1.Value.ToString("yyyyMMdd"));
            int nowdate = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int age = (nowdate - realdateofbirth) / 10000;
            var name = textBoxName.Text;
           
            MessageBox.Show($"{ name} har {age} år gammal");
        }

    }
}
