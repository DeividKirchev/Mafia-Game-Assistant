using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mafia
{
    public partial class Form31 : Form
    {
        public Form31()
        {
            InitializeComponent();
            Names.Text = File.ReadAllText(Form1.strWorkPath + @"\NAMES.txt").ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string s = Names.Text.ToString();
            File.WriteAllText(Form1.strWorkPath + @"\NAMES.txt", string.Empty);
            using (StreamWriter sw = File.AppendText(Form1.strWorkPath + @"\NAMES.txt"))
            {
                sw.WriteLine(s);
                this.Close();
            }
        }
    }
}
