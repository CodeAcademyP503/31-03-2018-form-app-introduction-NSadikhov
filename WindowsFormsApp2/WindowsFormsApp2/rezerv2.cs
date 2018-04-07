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
    public partial class rezerv2 : Form
    {
        public rezerv2()
        {
            InitializeComponent();
            new_rezerv.Click += new EventHandler(tekrar);
            foreach (var item in Form2.secilmis_oturacaq)
            {
                yerler.Text += item.Text + " | ";
                yerler.Enabled = false;
            }
            azn.Text += Form2.secilmis_oturacaq.Count * 4;
            azn.Enabled = false;
            Form2.secilmis_oturacaq.Clear();
            foreach (var item in Form2.secilmis_seans)
            {
                seans.Text += item.Text;
                seans.Enabled = false;
            }
            Form2.secilmis_seans.Clear();
        }
        public void tekrar(object sender, EventArgs e)
        {
            var btn = new ana_sayfa();
            btn.Show();
        }
    }
}
