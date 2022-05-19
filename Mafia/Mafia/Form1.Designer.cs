namespace Mafia
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PR = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Calculator = new System.Windows.Forms.Button();
            this.buttonAddNames = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Names = new System.Windows.Forms.CheckedListBox();
            this.Roles = new System.Windows.Forms.CheckedListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(542, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "**Roles below the line are NOT ready for use in the calculator!!!";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(519, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Player - Role";
            // 
            // PR
            // 
            this.PR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PR.FormattingEnabled = true;
            this.PR.ItemHeight = 20;
            this.PR.Location = new System.Drawing.Point(505, 55);
            this.PR.Name = "PR";
            this.PR.Size = new System.Drawing.Size(200, 284);
            this.PR.TabIndex = 12;
            this.PR.SelectedIndexChanged += new System.EventHandler(this.PR_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button2.Location = new System.Drawing.Point(711, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "Random Role Generator";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Calculator
            // 
            this.Calculator.BackColor = System.Drawing.Color.White;
            this.Calculator.Enabled = false;
            this.Calculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Calculator.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Calculator.Location = new System.Drawing.Point(711, 131);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(200, 58);
            this.Calculator.TabIndex = 11;
            this.Calculator.Text = "Calculator";
            this.Calculator.UseVisualStyleBackColor = false;
            this.Calculator.Click += new System.EventHandler(this.Next_Click);
            // 
            // buttonAddNames
            // 
            this.buttonAddNames.BackColor = System.Drawing.Color.White;
            this.buttonAddNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAddNames.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonAddNames.Location = new System.Drawing.Point(711, 207);
            this.buttonAddNames.Name = "buttonAddNames";
            this.buttonAddNames.Size = new System.Drawing.Size(200, 58);
            this.buttonAddNames.TabIndex = 14;
            this.buttonAddNames.Text = "Add Name";
            this.buttonAddNames.UseVisualStyleBackColor = false;
            this.buttonAddNames.Click += new System.EventHandler(this.ButtonAddNames_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button3.Location = new System.Drawing.Point(272, 527);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 47);
            this.button3.TabIndex = 10;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(39, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(319, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Players";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(89, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Roles";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Names
            // 
            this.Names.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Names.CheckOnClick = true;
            this.Names.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Names.FormattingEnabled = true;
            this.Names.Location = new System.Drawing.Point(272, 55);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(200, 466);
            this.Names.TabIndex = 2;
            this.Names.SelectedIndexChanged += new System.EventHandler(this.Names_SelectedIndexChanged);
            // 
            // Roles
            // 
            this.Roles.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Roles.CheckOnClick = true;
            this.Roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Roles.FormattingEnabled = true;
            this.Roles.HorizontalScrollbar = true;
            this.Roles.Items.AddRange(new object[] {
            "Godfather",
            "Mafioso",
            "Escort",
            "Doctor",
            "Sheriff",
            "Cupid",
            "Mayor",
            "Lookout",
            "Vigilante",
            "Veteran",
            "Jester",
            "Executor",
            "-------------------------------",
            "Spy",
            "Framer",
            "Werewolf",
            "Serial Killer",
            "Arsonist",
            "Vampire",
            "Witch",
            "Random Neutral Killing",
            "Random Neutral Evil"});
            this.Roles.Location = new System.Drawing.Point(39, 55);
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(200, 466);
            this.Roles.TabIndex = 3;
            this.Roles.SelectedIndexChanged += new System.EventHandler(this.Roles_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button4.Location = new System.Drawing.Point(711, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 58);
            this.button4.TabIndex = 15;
            this.button4.Text = "Edit Names";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.ForeColor = System.Drawing.Color.White;
            this.version.Location = new System.Drawing.Point(955, 589);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(31, 13);
            this.version.TabIndex = 16;
            this.version.Text = "0.9.9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 611);
            this.Controls.Add(this.version);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonAddNames);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PR);
            this.Controls.Add(this.Calculator);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Roles);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.button2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1014, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mafia Game Assistant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox PR;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Calculator;
        private System.Windows.Forms.Button buttonAddNames;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox Names;
        private System.Windows.Forms.CheckedListBox Roles;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label version;
    }
}

