using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mafia
{

    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            version.Text = Form1.pversion;
        }

        bool checkselected(int k)
        {
            //Results.Items.Add(Names.CheckedItems.Count.ToString());
            if (Names.CheckedItems.Count > k) return false;
            else return true;
        }
        private void Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();

            f.ShowDialog();
            this.Close();
        }
        int size = Form1.size;
        int current = 0;
        private void Form2_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < size; i++)
            {
                Names.Items.Add(Form1.names_public[i]);
                Roles.Items.Add(Form1.roles_public[i]);
            }


            for (int i = 0; i < size; i++)
            {
                if (Roles.Items[i].ToString() == "Godfather") Roles.Items[i] = "Mafia Silence";
                if (Roles.Items[i].ToString() == "Mafioso") Roles.Items[i] = "Mafia Kill";

            }
            Roles.Items[0] = Roles.Items[0] + " - current";
        }
        private void Names_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k = Names.SelectedIndex;
            string s;
            s = Roles.Items[current].ToString();
            s = s.Remove(s.Length - 10);
            if (s == "Cupid")
            {
                if (checkselected(2) == false)
                {
                    Names = clearListBox(Names);
                    Names.SetItemChecked(k, true);
                   // Results.Items.Add("ERROR");
                }
            }
            if (s != "Cupid" && checkselected(1) == false)
            {
                Names = clearListBox(Names);
                Names.SetItemChecked(k, true);
                //Results.Items.Add("ERROR");
            }
        }


        //------------------
        int escort = -1; //1
        int cupid1 = -1; //1
        int cupid2 = -1; //1
        int mafiakill = -1; //1
        int mafiasilence = -1; //1
        int doctor = -1; //1
        int sheriff = -1; //1
        int vigilante = -1; //1
        int lookout = -1; //1
        int serialkiller = -1; 
        int veteran = -1; //1
        int jester = -1; //1
        bool executor = false; //1 
        bool executorcheck = false; //1
        //--------------------
        /*
        int witch = -1;
        int arsonist = -1;
        int werewolf = -1;
        int vampire = -1;
        */
        //------------------------


        int findroleid(string s)
        {
            int i;
            for (i=0;i<size;i++)
            {
                if (Roles.Items[i].ToString() == s)return i;
            }
            return -1;
        }
        
        int night = 1;
        void calculate()
        {
            Results.Items.Add("Night - " + night.ToString());
            //----------------- Jester
            if (jester != -1)
            {
                Results.Items.Add(Names.Items[jester].ToString() + " is DEAD by JESTER");
            }
            //----------------- Executor
            if (executor==false && executorcheck==true)
            {
                int rnd;
                Random random = new Random();
                while (true)
                {
                    rnd = random.Next(0, Names.Items.Count);
                    if (rnd != findroleid("Executor") /*&& rnd!= findroleid("Jester")*/) break;
                }
                Results.Items.Add("Executor Target - " + Names.Items[rnd]);
                executor = true;
            }
            //---------------- Escort
            if (escort != -1)
            {

                string s = Roles.Items[escort].ToString();
                if (s == "Cupid")
                {
                    cupid1 = -1;
                    cupid2 = -1;
                }
                if (s == "Mafia Kill") mafiakill = -1;
                if (s == "Mafia Silence") mafiasilence = -1;
                if (s == "Doctor") doctor = -1;
                if (s == "Sheriff") sheriff = -1;
                if (s == "Vigilante") vigilante = -1;
                if (s == "Lookout") lookout = -1;
                //if (s == "Serial Killer") serialkiller = -1;
                //---------------- ESCORT - CUPID 1
                if (cupid1 == escort)
                {
                    s = Roles.Items[cupid2].ToString();
                    Results.Items.Add(s);
                    if (s == "Cupid")
                    {
                        cupid1 = -1;
                        cupid2 = -1;
                        //----------FIX MAYBE????
                    }
                    if (s == "Mafia Kill") mafiakill = -1;
                    if (s == "Mafia Silence") mafiasilence = -1;
                    if (s == "Doctor") doctor = -1;
                    if (s == "Sheriff") sheriff = -1;
                    if (s == "Vigilante") vigilante = -1;
                    if (s == "Lookout") lookout = -1;
                    if (s == "Serial Killer") serialkiller = -1;
                }
                //---------------- ESCORT CUPID 2
                if (cupid2 == escort)
                {
                    s = Roles.Items[cupid1].ToString();
                    Results.Items.Add(s);
                    if (s == "Cupid")
                    {
                        cupid1 = -1;
                        cupid2 = -1;
                        //----------FIX MAYBE????
                    }
                    if (s == "Mafia Kill") mafiakill = -1;
                    if (s == "Mafia Silence") mafiasilence = -1;
                    if (s == "Doctor") doctor = -1;
                    if (s == "Sheriff") sheriff = -1;
                    if (s == "Vigilante") vigilante = -1;
                    if (s == "Lookout") lookout = -1;
                    if (s == "Serial Killer") serialkiller = -1;
                }
            }
            //---------------- Doctor
            if (doctor != -1)
            {
                if (doctor == mafiakill) mafiakill = -1;
                if (doctor == vigilante) vigilante = -1;
                if (doctor == serialkiller) serialkiller = -1;

                if (doctor == cupid1)
                {
                    if (cupid2 == mafiakill) mafiakill = -1;
                    if (cupid2 == vigilante) vigilante = -1;
                    if (cupid2 == serialkiller) serialkiller = -1;
                }
                if (doctor == cupid2)
                {
                    if (cupid1 == mafiakill) mafiakill = -1;
                    if (cupid1 == vigilante) vigilante = -1;
                    if (cupid1 == serialkiller) serialkiller = -1;
                }
            }
            //---------------- Sheriff
            if (sheriff != -1)
            {
                if (Roles.Items[sheriff].ToString() == "Mafia Kill") Results.Items.Add("Sheriff found MAFIA");
                else Results.Items.Add("Sheriff found nothing");
            }
            //---------------- Mafia Kill
            if (mafiakill != -1)
            {
                Results.Items.Add(Names.Items[mafiakill].ToString() + " is DEAD");
                if (mafiakill == cupid1) Results.Items.Add(Names.Items[cupid2].ToString() + " is DEAD");
                if (mafiakill == cupid2) Results.Items.Add(Names.Items[cupid1].ToString() + " is DEAD");
            }
            //---------------- Mafia Silence
            if (mafiasilence != -1)
            {
                Results.Items.Add(Names.Items[mafiasilence].ToString() + " is SILENCED");
                if (mafiasilence == cupid1) Results.Items.Add(Names.Items[cupid2].ToString() + " is SILENCED");
                if (mafiasilence == cupid2) Results.Items.Add(Names.Items[cupid1].ToString() + " is SILENCED");
            }
            //----------------- Vigilante
            if (vigilante != -1)
            {
                Results.Items.Add(Names.Items[vigilante].ToString() + " is DEAD by vigilante");
                if (vigilante == cupid1) Results.Items.Add(Names.Items[cupid2].ToString() + " is DEAD by vigilante");
                if (vigilante == cupid2) Results.Items.Add(Names.Items[cupid1].ToString() + " is DEAD by vigilante");
            }
            //----------------- Lookout
            if (lookout != -1)
            {
                string l = "Lookout -";
                if (escort == lookout)
                {
                    for (int i = 0; i < Roles.Items.Count; i++)
                        if (Roles.Items[i].ToString() == "Escort") l = l + Names.Items[i];
                }
                if (mafiakill == lookout)
                {
                    for (int i = 0; i < Roles.Items.Count; i++)
                        if (Roles.Items[i].ToString() == "Mafia Kill") l = l + ", " + Names.Items[i];
                }
                if (doctor == lookout)
                {
                    for (int i = 0; i < Roles.Items.Count; i++)
                        if (Roles.Items[i].ToString() == "Doctor") l = l + ", " + Names.Items[i];
                }
                if (vigilante == lookout)
                {
                    for (int i = 0; i < Roles.Items.Count; i++)
                        if (Roles.Items[i].ToString() == "Vigilante") l = l + ", " + Names.Items[i];
                }
                if (mafiasilence == lookout)
                {
                    for (int i = 0; i < Roles.Items.Count; i++)
                        if (Roles.Items[i].ToString() == "Mafia Silence") l = l + ", " + Names.Items[i];
                }
                if (sheriff == lookout)
                {
                    for (int i = 0; i < Roles.Items.Count; i++)
                        if (Roles.Items[i].ToString() == "Sheriff") l = l + ", " + Names.Items[i];
                }
                Results.Items.Add(l);
            }
            //----------------- Veteran
            if (veteran != -1)
            {
                if (escort == veteran)
                    for (int i = 0; i < Roles.Items.Count; i++)
                        if (Roles.Items[i].ToString() == "Escort") Results.Items.Add(Names.Items[i].ToString() + " is DEAD");
                if (mafiakill == veteran)
                    for (int i = 0; i < Roles.Items.Count; i++)
                        if (Roles.Items[i].ToString() == "Mafia Kill") Results.Items.Add(Names.Items[i].ToString() + " is DEAD");
                if (mafiasilence == veteran)
                    for (int i = 0; i < Roles.Items.Count; i++)
                        if (Roles.Items[i].ToString() == "Mafia Silence") Results.Items.Add(Names.Items[i].ToString() + " is DEAD");
                if (doctor == veteran)
                    for (int i = 0; i < Roles.Items.Count; i++)
                        if (Roles.Items[i].ToString() == "Doctor") Results.Items.Add(Names.Items[i].ToString() + " is DEAD");
                if (lookout == veteran)
                    for (int i = 0; i < Roles.Items.Count; i++)
                        if (Roles.Items[i].ToString() == "Lookout") Results.Items.Add(Names.Items[i].ToString() + " is DEAD");
                if (doctor == vigilante)
                    for (int i = 0; i < Roles.Items.Count; i++)
                        if (Roles.Items[i].ToString() == "Vigilante") Results.Items.Add(Names.Items[i].ToString() + " is DEAD");
                if (doctor == sheriff)
                    for (int i = 0; i < Roles.Items.Count; i++)
                        if (Roles.Items[i].ToString() == "Sheriff") Results.Items.Add(Names.Items[i].ToString() + " is DEAD");

            }
            

            //------------------TO DO----------------
            night++;
        }


        void getTarget(string s)
        {
            if (Names.CheckedItems.Count > 0)
            {
                //-----------------------------------------
                if (s == "Escort") escort = Names.CheckedIndices[0];
                if (s == "Cupid")
                {
                    cupid1 = Names.CheckedIndices[0];
                    cupid2 = Names.CheckedIndices[1];
                    //Test.Items.Add(cupid1);
                    //Test.Items.Add(cupid2);
                }
                if (s == "Mafia Kill") mafiakill = Names.CheckedIndices[0];
                if (s == "Mafia Silence") mafiasilence = Names.CheckedIndices[0];
                if (s == "Doctor") doctor = Names.CheckedIndices[0];
                if (s == "Sheriff") sheriff = Names.CheckedIndices[0];
                if (s == "Vigilante") vigilante = Names.CheckedIndices[0];
                if (s == "Lookout") lookout = Names.CheckedIndices[0];
                if (s == "Serial Killer") serialkiller = Names.CheckedIndices[0];
                if (s == "Jester") jester = Names.CheckedIndices[0];
                if (s == "Veteran")
                {
                    for (int i = 0; i < Roles.Items.Count; i++)
                        if (Roles.Items[i].ToString() == "Veteran" && Names.CheckedIndices[0] == i)
                            veteran = i;
                }
                
                //Test.Items.Add(s);
            }
            if (s == "Executor") executorcheck = true;
        }
        private CheckedListBox clearListBox(CheckedListBox X)
        {
            for (int i = 0; i < X.Items.Count; i++)
            {
                X.SetItemChecked(i, false);
            }
            return X;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s;
                s = Roles.Items[current].ToString();
                s = s.Remove(s.Length - 10);
                int x = Names.CheckedIndices.Count;
                if (s == "Cupid" && x != 2)return;
                current++;
                Roles.Items[current - 1] = s;
                //-------------
                getTarget(s);
                //-------------
                if (current == size)
                {
                    calculate();
                    Names = clearListBox(Names);
                    escort = -1;
                    cupid1 = -1;
                    cupid2 = -1;
                    mafiakill = -1;
                    mafiasilence = -1;
                    doctor = -1;
                    sheriff = -1;
                    vigilante = -1;
                    lookout = -1;
                    serialkiller = -1;
                    current = 0;
                    veteran = -1;
                    Roles.Items[0] = Roles.Items[0] + " - current";
                    return;
                }

                /*
                 if (current == size)  //END OF LIST
                {
                    Test.Items.Add(escort.ToString() + " - Escort");
                    Test.Items.Add(mafiakill.ToString() + " - mafiakill");
                    Test.Items.Add(mafiasilence.ToString() + " - mafiasilence");
                    Test.Items.Add(doctor.ToString() + " - doctor");
                    Test.Items.Add(vigilante.ToString() + " - vigilante");
                    Test.Items.Add(sheriff.ToString() + " - sheriff");
                    Names = clearListBox(Names);
                    return;
                }
                */

                //------------------------------------------
                Roles.Items[current] = Roles.Items[current] + " - current";
                Names = clearListBox(Names);
            }
            catch { }
        }

        private void Roles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
