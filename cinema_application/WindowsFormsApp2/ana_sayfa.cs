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
        public static List<string> intro = new List<string>() { "Inception\nIMDB : 8.8\n2:28 saat", "Interstellar\nIMDB : 9.2\n2:54 saat", "Whiplash\nIMDB : 7.9\n2:14 saat", "ProjectX\nIMDB : 8.2\n2:10 saat", "Dos tipos\nIMDB : 7.5\n2:32 saat" };
        public static List<Bitmap> btmp = new List<Bitmap>() { global::WindowsFormsApp2.Properties.Resources.v1, global::WindowsFormsApp2.Properties.Resources.dwd, global::WindowsFormsApp2.Properties.Resources.dj, global::WindowsFormsApp2.Properties.Resources.fwwe, global::WindowsFormsApp2.Properties.Resources.ewddd};
        public int intro_name;
        public int btmp_name;
        public int kino = 5;
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

            for (int i = 1; i <= kino; i++)
            {
                var pcr = new Button();
                pcr.Image = btmp[btmp_name];
                pcr.Location = new System.Drawing.Point(50,120);
                pcr.Size = new System.Drawing.Size(135,200);
                pcr.Left = left + 20;
                pcr.TabIndex = 0;
                pcr.TabStop = false;
                Controls.Add(pcr);
                btmp_name++;
                if (pcr.Image == btmp[0])
                {
                    pcr.Click += new EventHandler(zal_1);
                }
                else if (pcr.Image == btmp[1])
                {
                    pcr.Click += new EventHandler(zal_2);
                }
                else if (pcr.Image == btmp[2])
                {
                    pcr.Click += new EventHandler(zal_3);
                }
                else if (pcr.Image == btmp[3])
                {
                    pcr.Click += new EventHandler(zal_4);
                }
                else if (pcr.Image == btmp[4])
                {
                    pcr.Click += new EventHandler(zal_5);
                }
                var label = new Label();               
                label.Text = intro[intro_name];
                label.Width = 75;
                label.Height = 50;
                label.ForeColor = Color.White;
                label.Left = left + 55;
                left += 25;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Top = top - 60;
                Controls.Add(label);
                intro_name++;
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
                btn.Enabled = false;
            }
            this.Width = kino * 125 + 167;
        }
        public void zal_1(object sender,EventArgs e)
        {
            var btn = new Form1();
            btn.Show();
        }
        public void zal_2(object sender, EventArgs e)
        {
            var btn = new Form2();
            btn.Show();
        }
        public void zal_3(object sender, EventArgs e)
        {
            var btn = new Form3();
            btn.Show();
        }
        public void zal_4(object sender, EventArgs e)
        {
            var btn = new Form4();
            btn.Show();
        }
        public void zal_5(object sender, EventArgs e)
        {
            var btn = new Form5();
            btn.Show();
        }
    }
   
}
