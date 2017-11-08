using DAL;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnketV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AnketContext db = new AnketContext();
        private void button2_Click(object sender, EventArgs e)
        {
            Soru s = new Soru();
            s.SoruCumlesi = textBox2.Text;
          
            db.Sorular.Add(s);
            db.SaveChanges();
            SorulariYenile();
        }
        
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            SorulariYenile();
        }
        public void SorulariYenile()
        {   
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.Sorular.ToList();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Clear();
            foreach (Soru soru in db.Sorular)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Text = soru.SoruCumlesi;
                flowLayoutPanel1.Controls.Add(lbl);
                flowLayoutPanel1.SetFlowBreak(lbl, true);

                //RadioButton r1 = new RadioButton();
                //r1.Text = "Evet";
                //flowLayoutPanel1.Controls.Add(r1);

                //RadioButton r2 = new RadioButton();
                //r2.Text = "Hayir";
                //flowLayoutPanel1.Controls.Add(r2);

                ComboBox c1 = new ComboBox();
                c1.Items.Add("Evet");
                c1.Items.Add("Hayir");
                flowLayoutPanel1.Controls.Add(c1);
                flowLayoutPanel1.SetFlowBreak(c1, true);
            }
        }
    }
}
