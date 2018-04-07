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
    public partial class Form5 : Form
    {
        public int yuxaridan_asagi = 4;
        public int soldan_saga = 11;
        public int top = 120;
        public int left = 180;
        public int oturacaq_sayi = 1;
        public static List<Button> secilmis_oturacaq = new List<Button>();
        public static List<Button> secilmis_2 = new List<Button>();
        public static List<Button> secilmis_seans = new List<Button>();
        public Form5()
        {
            InitializeComponent();
            btnseans12.Click += new EventHandler(btnseans);
            btnseans20.Click += new EventHandler(btnseans);
            btnrezerv.Click += new EventHandler(rezerv);
            btnexit1.Click += new EventHandler(exit);
            btnexit3.Click += new EventHandler(exit);
            for (int i = 1; i <= yuxaridan_asagi; i++)
            {
                if (i == 1)
                {
                    for (int a = 1; a <= soldan_saga; a++)
                    {
                        if (secilmis_2.Count > 0)
                        {
                            foreach (var item in secilmis_2)
                            {
                                Controls.Add(item);
                            }
                        }
                        goster();
                    }
                    left = 160;
                    top += 40;
                }
                else if (i == 2)
                {
                    soldan_saga = 12;
                    for (int a = 1; a <= soldan_saga; a++)
                    {
                        if (secilmis_2.Count > 0)
                        {
                            foreach (var item in secilmis_2)
                            {
                                Controls.Add(item);
                            }
                        }
                        goster();
                    }
                    left = 120;
                    top += 40;
                }
                else if (i == 3)
                {
                    soldan_saga = 14;
                    for (int a = 1; a <= soldan_saga; a++)
                    {
                        if (secilmis_2.Count > 0)
                        {
                            foreach (var item in secilmis_2)
                            {
                                Controls.Add(item);
                            }
                        }
                        goster();
                    }
                    left = 60;
                    top += 40;
                }
                else
                {
                    soldan_saga = 17;
                    for (int a = 1; a <= soldan_saga; a++)
                    {
                        if (secilmis_2.Count > 0)
                        {
                            foreach (var item in secilmis_2)
                            {
                                Controls.Add(item);
                            }
                        }
                        goster();
                    }
                }
            }
            this.Height = yuxaridan_asagi * 40 + 270;
            this.Width = soldan_saga * 40 + 137;
        }
        public void goster()
        {
            var btn = new Button();
            btn.Width = 40;
            btn.Height = 40;
            btn.Left = left;
            left += 40;
            btn.Top = top;
            btn.Name = "mk";
            btn.BackColor = Color.DarkGray;
            btn.Text = oturacaq_sayi.ToString();
            Controls.Add(btn);
            oturacaq_sayi++;
            btn.Click += new EventHandler(secmek);
            secilmis_2.Add(btn);
        }

        public void btnseans(object sender, EventArgs e)
        {

            var btn = sender as Button;
            if (btn.Name == "btnseans12")
            {
                btn.Text = "12:00";
                btnseans20.Enabled = false;
                btnseans12.Enabled = false;
            }
            if (btn.Name == "btnseans20")
            {
                btn.Text = "20:00";
                btnseans12.Enabled = false;
                btnseans20.Enabled = false;
            }
            btn.BackColor = Color.Red;
            secilmis_seans.Add(btn);
        }
        public void exit(object sender, EventArgs e)
        {
            var exit = new ana_sayfa();
            exit.Show();
        }
        public void secmek(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.BackColor = Color.Red;
            btn.ForeColor = Color.White;
            if (btn.Name == "mk")
            {
                btn.Enabled = false;
            }
            secilmis_oturacaq.Add(btn);
        }
        public void rezerv(object sender, EventArgs e)
        {
            var rzrv = new rezerv5();
            rzrv.Show();
        }
    }
}
