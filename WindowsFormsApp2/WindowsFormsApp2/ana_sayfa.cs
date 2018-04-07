using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ana_sayfa : Form
    {
        public int price = 5;
        public int top = 400;
        public int left = 0;
        public PictureBox pctr = new PictureBox();
        public ana_sayfa()
        {
            InitializeComponent();
            var panel1 = new FlowLayoutPanel();
            panel1.Width = 75;
            panel1.Height = 55;
            panel1.BackColor = Color.White;
            panel1.Left = 0;
            panel1.Top = 20;
            Controls.Add(panel1);
            pctr.Image = global::WindowsFormsApp2.Properties.Resources.landmark_theatres_2;
            pctr.Location = new System.Drawing.Point(78, 20);
            pctr.Size = new System.Drawing.Size(133, 55);
            pctr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pctr.TabIndex = 0;
            pctr.TabStop = false;
            Controls.Add(pctr);
            var panel2 = new FlowLayoutPanel();
            panel2.Width = 563;
            panel2.Height = 55;
            panel2.BackColor = Color.White;
            panel2.Left = 214;
            panel2.Top = 20;
            Controls.Add(panel2);

            for (int i = 1; i <= price; i++)
            {
                var pcr = new PictureBox();
                if (i == 1)
                {
                    pcr.Image = global::WindowsFormsApp2.Properties.Resources.v1;
                }
                else if (i == 2)
                {
                    pcr.Image = global::WindowsFormsApp2.Properties.Resources.dwd;
                }
                else if (i == 3)
                {
                    pcr.Image = global::WindowsFormsApp2.Properties.Resources.dj;
                }
                else if (i == 4)
                {
                    pcr.Image = global::WindowsFormsApp2.Properties.Resources.fwwe;
                }
                else
                {
                    pcr.Image = global::WindowsFormsApp2.Properties.Resources.ewddd;
                }
                pcr.Location = new System.Drawing.Point(50,140);
                pcr.Size = new System.Drawing.Size(115,175);
                pcr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pcr.Left = left + 30;
                pcr.TabIndex = 0;
                pcr.TabStop = false;
                Controls.Add(pcr);
                var label = new Label();
                label.Text = " Inception\nIMDB : 8.8\n 2:28 saat";
                label.Width = 75;
                label.Height = 50;
                label.ForeColor = Color.White;
                label.Left = left+55;
                left += 25;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Top = top-60;
                Controls.Add(label);
                var btn = new Button();
                btn.Width = 125;
                btn.Height = 30;
                btn.Left = left;
                btn.Text = "Price: 4AZN";
                btn.Top = top;
                btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.TabIndex = 0;
                btn.ForeColor = Color.White;
                left += 125;
                Controls.Add(btn);
                btn.Click += new EventHandler(form);
            }
            this.Width = price * 125 + 167;
        }
        public void form(object sender,EventArgs e)
        {
           
            var btn = new Form1();
            btn.Show();
           
        }
    }
   
}
