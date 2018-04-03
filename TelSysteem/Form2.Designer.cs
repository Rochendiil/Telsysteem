namespace TelSysteem
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
            System.Windows.Forms.ColumnHeader Rugnummer;
            System.Windows.Forms.ColumnHeader columnHeader1;
            this.listView_team1 = new System.Windows.Forms.ListView();
            this.NevoboNummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_team2 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Next = new System.Windows.Forms.Button();
            Rugnummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView_team1
            // 
            this.listView_team1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Rugnummer,
            this.Naam,
            this.NevoboNummer});
            this.listView_team1.Location = new System.Drawing.Point(12, 50);
            this.listView_team1.Name = "listView_team1";
            this.listView_team1.Size = new System.Drawing.Size(372, 237);
            this.listView_team1.TabIndex = 0;
            this.listView_team1.UseCompatibleStateImageBehavior = false;
            this.listView_team1.View = System.Windows.Forms.View.Details;
            // 
            // NevoboNummer
            // 
            this.NevoboNummer.Text = "NevoboNummer";
            this.NevoboNummer.Width = 87;
            // 
            // Naam
            // 
            this.Naam.Text = "Naam";
            this.Naam.Width = 128;
            // 
            // Rugnummer
            // 
            Rugnummer.Text = "Rugnummer";
            Rugnummer.Width = 70;
            // 
            // listView_team2
            // 
            this.listView_team2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_team2.Location = new System.Drawing.Point(420, 50);
            this.listView_team2.Name = "listView_team2";
            this.listView_team2.Size = new System.Drawing.Size(347, 237);
            this.listView_team2.TabIndex = 1;
            this.listView_team2.UseCompatibleStateImageBehavior = false;
            this.listView_team2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Rugnummer";
            columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naam";
            this.columnHeader2.Width = 128;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "NevoboNummer";
            this.columnHeader3.Width = 128;
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(38, 382);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(75, 23);
            this.button_Next.TabIndex = 2;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 476);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.listView_team2);
            this.Controls.Add(this.listView_team1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_team1;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader NevoboNummer;
        private System.Windows.Forms.ListView listView_team2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button_Next;
    }
}