namespace Mafia
{
    partial class Form31
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form31));
            this.Names = new System.Windows.Forms.RichTextBox();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Names
            // 
            this.Names.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Names.Location = new System.Drawing.Point(12, 12);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(181, 182);
            this.Names.TabIndex = 0;
            this.Names.Text = "";
            this.Names.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Add.Location = new System.Drawing.Point(218, 152);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(96, 42);
            this.Add.TabIndex = 2;
            this.Add.Text = "Edit";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Form31
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(348, 225);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Names);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form31";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Names";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Names;
        private System.Windows.Forms.Button Add;
    }
}