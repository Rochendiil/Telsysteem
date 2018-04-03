namespace TelSysteem
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
            this.Dropdown_Team1 = new System.Windows.Forms.ComboBox();
            this.Label_Team1 = new System.Windows.Forms.Label();
            this.Dropdown_Vereniging1 = new System.Windows.Forms.ComboBox();
            this.Label_Vereniging1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dropdown_Vereniging2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dropdown_Team2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dropdown_Team1
            // 
            this.Dropdown_Team1.FormattingEnabled = true;
            this.Dropdown_Team1.Location = new System.Drawing.Point(56, 137);
            this.Dropdown_Team1.Name = "Dropdown_Team1";
            this.Dropdown_Team1.Size = new System.Drawing.Size(121, 21);
            this.Dropdown_Team1.TabIndex = 0;
            this.Dropdown_Team1.SelectionChangeCommitted += new System.EventHandler(this.Dropdown_Team1_SelectionChangeCommitted);
            // 
            // Label_Team1
            // 
            this.Label_Team1.AutoSize = true;
            this.Label_Team1.Location = new System.Drawing.Point(53, 121);
            this.Label_Team1.Name = "Label_Team1";
            this.Label_Team1.Size = new System.Drawing.Size(34, 13);
            this.Label_Team1.TabIndex = 1;
            this.Label_Team1.Text = "Team";
            // 
            // Dropdown_Vereniging1
            // 
            this.Dropdown_Vereniging1.FormattingEnabled = true;
            this.Dropdown_Vereniging1.Location = new System.Drawing.Point(56, 53);
            this.Dropdown_Vereniging1.Name = "Dropdown_Vereniging1";
            this.Dropdown_Vereniging1.Size = new System.Drawing.Size(121, 21);
            this.Dropdown_Vereniging1.TabIndex = 2;
            this.Dropdown_Vereniging1.SelectionChangeCommitted += new System.EventHandler(this.Dropdown_Vereniging1_SelectionChangeCommitted);
            // 
            // Label_Vereniging1
            // 
            this.Label_Vereniging1.AutoSize = true;
            this.Label_Vereniging1.Location = new System.Drawing.Point(53, 23);
            this.Label_Vereniging1.Name = "Label_Vereniging1";
            this.Label_Vereniging1.Size = new System.Drawing.Size(57, 13);
            this.Label_Vereniging1.TabIndex = 3;
            this.Label_Vereniging1.Text = "Vereniging";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(550, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vereniging";
            // 
            // Dropdown_Vereniging2
            // 
            this.Dropdown_Vereniging2.FormattingEnabled = true;
            this.Dropdown_Vereniging2.Location = new System.Drawing.Point(553, 53);
            this.Dropdown_Vereniging2.Name = "Dropdown_Vereniging2";
            this.Dropdown_Vereniging2.Size = new System.Drawing.Size(121, 21);
            this.Dropdown_Vereniging2.TabIndex = 7;
            this.Dropdown_Vereniging2.SelectionChangeCommitted += new System.EventHandler(this.Dropdown_Vereniging2_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Team";
            // 
            // Dropdown_Team2
            // 
            this.Dropdown_Team2.FormattingEnabled = true;
            this.Dropdown_Team2.Location = new System.Drawing.Point(553, 137);
            this.Dropdown_Team2.Name = "Dropdown_Team2";
            this.Dropdown_Team2.Size = new System.Drawing.Size(121, 21);
            this.Dropdown_Team2.TabIndex = 5;
            this.Dropdown_Team2.SelectedIndexChanged += new System.EventHandler(this.Dropdow_Team2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dropdown_Vereniging2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dropdown_Team2);
            this.Controls.Add(this.Label_Vereniging1);
            this.Controls.Add(this.Dropdown_Vereniging1);
            this.Controls.Add(this.Label_Team1);
            this.Controls.Add(this.Dropdown_Team1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Dropdown_Team1;
        private System.Windows.Forms.Label Label_Team1;
        private System.Windows.Forms.ComboBox Dropdown_Vereniging1;
        private System.Windows.Forms.Label Label_Vereniging1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Dropdown_Vereniging2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Dropdown_Team2;
        private System.Windows.Forms.Button button1;
    }
}

