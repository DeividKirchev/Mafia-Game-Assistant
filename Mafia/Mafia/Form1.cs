using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace Mafia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                GetNames();
            }
            catch
            {
                CreateFile(@"\NAMES.txt");
            }
            //CheckForUpdates()
            pversion = version.Text;

        }
        public static string pversion;

        void CheckForUpdates()
        {
            WebClient webClient = new WebClient();

            try
            {
                if (!webClient.DownloadString("https://pastebin.com/G6RX0R03").Contains(version.Text))
                {
                    if (MessageBox.Show("Looks like there is an update! Do you want to download it?", "Mafia Game Assistant", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        using (var client = new WebClient())
                        {
                            Process.Start("Updater.exe");
                            this.Close();
                        }
                }
            }
            catch
            {

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public static string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        public static readonly string strWorkPath = Path.GetDirectoryName(strExeFilePath);

        void PrepareForm2()
        {
            int i = 0;
            foreach (string s in Names.CheckedItems)
            {
                names_public[i] = s;
                i++;
            }
            size = i;
            //--------------------------------------
            i = 0;
            for (i = 0; i < size; i++)
            {
                string s;
                s = PR.Items[i].ToString();
                roles_public[i] = s.Remove(0, names_public[i].Length + 3);

            }
        }
       
        //-------------RNG
        private void button2_Click(object sender, EventArgs e)
        {
            PR.Items.Clear();
            Random random = new Random();
            bool[] used = new bool[25];
            string RNK;
            string[] random_rnk = new string[5];
            random_rnk[1] = "Werewolf";
            random_rnk[2] = "Serial Killer";
            random_rnk[3] = "Arsonist";
            random_rnk[4] = "Vampire";
            RNK = random_rnk[random.Next(1, 5)];
            string RNE;
            string[] random_rne = new string[5];
            random_rne[1] = "Witch";
            random_rne[2] = "Jester";
            random_rne[3] = "Executor";
            RNE = random_rne[random.Next(1, 4)];
            int i = new int();
            for (i = 0; i <= 20; i++) used[i] = false;
            int n_roles = Roles.CheckedItems.Count;
            int n_players = Names.CheckedItems.Count;
            if (n_roles != n_players)
            {
                PR.Items.Add("ERROR:Players are not");
                PR.Items.Add("equal to roles");
                Calculator.Enabled = false;
            }
            else if (n_roles < 2)
            {
                PR.Items.Add("ERROR:Please add");
                PR.Items.Add("more players");
                Calculator.Enabled = false;
            }
            else
            {
                Calculator.Enabled = true;
                int j = 0;
                foreach (string s in Names.CheckedItems)
                {
                    int rnd_role = random.Next(0, Roles.CheckedItems.Count);
                    PR.Items.Add(s);
                    for (i = 0; i <= 1; i++)
                    {
                        rnd_role = random.Next(0, Roles.CheckedItems.Count);
                        if (used[rnd_role] == true)
                        {
                            i--;
                            continue;
                        }
                    }
                    used[rnd_role] = true;
                    if (Roles.CheckedItems[rnd_role].ToString() == "Random Neutral Killing")
                    {
                        PR.Items[j] = PR.Items[j].ToString() + " - " + RNK;
                        j++;
                        continue;
                    }
                    if (Roles.CheckedItems[rnd_role].ToString() == "Random Neutral Evil")
                    {
                        PR.Items[j] = PR.Items[j].ToString() + " - " + RNE;
                        j++;
                        continue;
                    }

                    PR.Items[j] = PR.Items[j].ToString() + " - " + Roles.CheckedItems[rnd_role].ToString();
                    j++;
                }
                PrepareForm2();
            }
            
        }
        //------------------------------------------------
        
        private void Roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Roles.ClearSelected();
        }

        private void Names_SelectedIndexChanged(object sender, EventArgs e)
        {
            Names.ClearSelected();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Roles.Items.Count; i++)
            {
                Roles.SetItemChecked(i, false);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Names.Items.Count; i++)
            {
                Names.SetItemChecked(i, false);
            }

        }

        public static string[] names_public = new string [50];
        public static string[] roles_public = new string[50];
        public static int size;
        private void Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.ShowDialog();
            this.Close();
        }
        private void CreateFile(string s)
        {
            if (!File.Exists(strWorkPath + s))
                File.Create(strWorkPath + s);
            InitializeComponent();
            return;
        }
        private void GetNames ()
        {
            Names.Items.Clear();
            Names.Items.AddRange(File.ReadAllLines(strWorkPath + @"\NAMES.txt"));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAddNames_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
            Names.Items.Clear();
            Names.Items.AddRange(File.ReadAllLines(strWorkPath + @"\NAMES.txt"));
            removespaces();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form31 f = new Form31();
            f.ShowDialog();
            Names.Items.Clear();
            Names.Items.AddRange(File.ReadAllLines(strWorkPath + @"\NAMES.txt"));
            removespaces();
        }
        void removespaces()
        {
            for (int i = 0; i < Names.Items.Count;)
                if (Names.Items[i].ToString() == "")
                    Names.Items.RemoveAt(i);
                else i++;
            //RSpace();

            File.WriteAllText(Form1.strWorkPath + @"\NAMES.txt", string.Empty);
            for (int i = 0; i < Names.Items.Count; i++) 
            {
                using (StreamWriter sw = File.AppendText(Form1.strWorkPath + @"\NAMES.txt"))
                {
                    sw.WriteLine(Names.Items[i].ToString());
                }
            }
        }

        private void PR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       /* void RSpace ()
        {
            for (int i = 0; i < Names.Items.Count; i++)
            {
                string s = Names.Items[i].ToString();
                while (s[0] == ' ' && s.Count() >= 1)
                {
                    s.Remove(0, 1);
                    PR.Items.Add("Error");
                }
                Names.Items[i] = s;
            }
            for (int i = 0; i < Names.Items.Count; i++)
            {
                string s = Names.Items[i].ToString();
                while (s[s.Count()-1] == ' ' && s.Count() >= 1)
                    s.Remove(s.Count()-1, 1);

                Names.Items[i] = s;
            }
        }*/
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    
}
