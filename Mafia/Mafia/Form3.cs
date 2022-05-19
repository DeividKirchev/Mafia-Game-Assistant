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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string s = Names.Text.ToString();
            Names.Clear();
            using (StreamWriter sw = File.AppendText(Form1.strWorkPath + @"\NAMES.txt"))
            {
                sw.WriteLine(s);
                this.Close();
            }
        }
    }
}
