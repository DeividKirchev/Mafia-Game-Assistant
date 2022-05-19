namespace Mafia
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Back = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Names = new System.Windows.Forms.CheckedListBox();
            this.Roles = new System.Windows.Forms.ListBox();
            this.Results = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.White;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Back.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Back.Location = new System.Drawing.Point(542, 431);
            this.Back.MaximumSize = new System.Drawing.Size(1014, 625);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(200, 58);
            this.Back.TabIndex = 12;
            this.Back.Text = "Roles / Players";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Next_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.White;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Next.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Next.Location = new System.Drawing.Point(542, 367);
            this.Next.MaximumSize = new System.Drawing.Size(1014, 625);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(200, 58);
            this.Next.TabIndex = 13;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.button1_Click);
            // 
            // Names
            // 
            this.Names.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Names.CheckOnClick = true;
            this.Names.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Names.FormattingEnabled = true;
            this.Names.HorizontalScrollbar = true;
            this.Names.Location = new System.Drawing.Point(27, 57);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(170, 544);
            this.Names.TabIndex = 16;
            this.Names.SelectedIndexChanged += new System.EventHandler(this.Names_SelectedIndexChanged);
            // 
            // Roles
            // 
            this.Roles.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Roles.ItemHeight = 29;
            this.Roles.Location = new System.Drawing.Point(203, 57);
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(170, 555);
            this.Roles.TabIndex = 16;
            this.Roles.SelectedIndexChanged += new System.EventHandler(this.Roles_SelectedIndexChanged);
            // 
            // Results
            // 
            this.Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Results.FormattingEnabled = true;
            this.Results.ItemHeight = 20;
            this.Results.Location = new System.Drawing.Point(392, 57);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(495, 304);
            this.Results.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(568, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "RESULTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "Target";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(251, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "Role";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.ForeColor = System.Drawing.Color.White;
            this.version.Location = new System.Drawing.Point(894, 564);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(41, 13);
            this.version.TabIndex = 22;
            this.version.Text = "version";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 586);
            this.Controls.Add(this.version);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.Roles);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1014, 625);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mafia Game Assistant";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.CheckedListBox Names;
        private System.Windows.Forms.ListBox Roles;
        private System.Windows.Forms.ListBox Results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label version;
    }
}