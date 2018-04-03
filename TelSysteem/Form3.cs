using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelSysteem
{
    public partial class Form3 : Form
    {
        List<Label> labels1 = new List<Label>();
        List<Label> labels2 = new List<Label>();
        bool Team1draaien = true;
        bool Team2draaiem = false;
        public Form3(List<int> team1, List<int> team2)
        {
            InitializeComponent();
            Rugnummers(team1, listBox_Team1);
            Rugnummers(team2, listBox_Team2);
            Graphics();
            Addlabels1(labels1);
            Addlabels2(labels2);
        }
        public void Addlabels1(List<Label> label)
        {
            label.Add(label1);
            label.Add(label2);
            label.Add(label3);
            label.Add(label4);
            label.Add(label5);
            label.Add(label6);

        }
        public void Addlabels2(List<Label> label)
        {
            label.Add(label7);
            label.Add(label8);
            label.Add(label9);
            label.Add(label10);
            label.Add(label11);
            label.Add(label12);
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        public void Rugnummers(List<int> team, ListBox listbox)
        {
            foreach (int item in team)
            {
                listbox.Items.Add(item);
            }
        }
        public void Graphics()
        {
            Pen mypen = new Pen(Color.Black);
            Graphics g;
            g = this.CreateGraphics();
            Point[] points =
                     {
                 new Point(10, 10),
                 new Point(20, 20),
             };

            g.DrawLines(mypen, points);
        }

        int x1 = 0;
        int x2 = 0;
        private void listBox_Team2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Team2.SelectedIndex >= 0)
            {
                spelerveld(listBox_Team2, labels2, x2);
                x2++;
            }
        }

        private void listBox_Team1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Team1.SelectedIndex >= 0)
            {
                spelerveld(listBox_Team1, labels1, x1);
                x1++;
            }
            
        }
        private void labels1_click(object sender, EventArgs e, Label label)
        {
           
        }
        int x = 0;
        public void spelerveld(ListBox listbox, List<Label> label, int labelindx)
        {

            label[labelindx].Text = Convert.ToString(listbox.SelectedItem);
            listbox.Items.Remove(listbox.SelectedItem);

            
        }
        public void Teamdraaien(List<Label> rugnummers)
        {
            Point temp = new Point();
            Point temp1 = new Point();
            temp1 = rugnummers[0].Location;
            for (int i = 0; i < 6; i++)
            {
                if (i == 5)
                {
                    rugnummers[i].Location = temp1;
                }
                else {
                    i++;
                    temp = rugnummers[i].Location;
                    i--;
                    rugnummers[i].Location = temp;
                }
            }    
        }
        private void button_plus1_Click(object sender, EventArgs e)
        {
            int score;
            score = Convert.ToInt32(label_score1.Text);
            label_score1.Text = Convert.ToString(score + 1);
            if(Team1draaien == true)
            {
                Team1draaien = false;
                Team2draaiem = true;
                Teamdraaien(labels1);
            }

        }

        private void button_plus2_Click(object sender, EventArgs e)
        {
            int score;
            score = Convert.ToInt32(label_score2.Text);
            label_score2.Text = Convert.ToString(score + 1);
            if (Team1draaien == false)
            {
                Team1draaien = true;
                Team2draaiem = false;
                Teamdraaien(labels2);
            }
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Black);
            SolidBrush myBrush = new SolidBrush(Color.Red);
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(myPen, 170, 120, 500, 200);
            formGraphics.DrawLine(myPen, 420, 120, 420, 320);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
