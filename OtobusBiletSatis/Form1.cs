using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBiletSatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbOtobus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbOtobus.Text)
            {
                case "KamilKoç": KoltukDoldur(8, false);
                    break;
                case "Metro": KoltukDoldur(12, true);
                    break;

                case "Uludağ": KoltukDoldur(10, false);

                    break;
            }
            void KoltukDoldur(int sira,bool ArkaBesliMi)
            {
                yavaslat:
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button)
                    {
                        if (button1.Text=="Kaydet")
                        {
                            continue;
                        }
                        else
                        {
                            this.Controls.Remove(ctrl); 
                            goto yavaslat;
                        }
                    }
                    
                }
                int koltukNo = 1;
                for (int i = 0; i < sira; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (ArkaBesliMi == true)
                        {
                            if (i != sira - 1 && j == 2)
                            {
                                continue;
                            }
                        }
                        else
                        {
                            if (j == 2)
                            {
                                continue;
                            }
                        }
                        if (j==2)
                        {
                            continue;
                        }
                        Button koltuk = new Button();
                        koltuk.Height = koltuk.Width = 40;
                        koltuk.Top = 30 + (i * 45);
                        koltuk.Left = 5 + (j * 45);
                        koltuk.Text=koltukNo.ToString();
                        koltukNo++;
                        koltuk.ContextMenuStrip = contextMenuStrip1;
                        koltuk.MouseDown += koltuk_mouseDown;
                        this.Controls.Add(koltuk);


                    }
                }
            }
        }

        Button tiklanan;
        private void koltuk_mouseDown(object? sender, MouseEventArgs e)
        {
            tiklanan = sender as Button;
        }

        private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmbOtobus.SelectedIndex==-1||cmbOtobus.SelectedIndex==-1|| cmbNereye.SelectedIndex==-1)
            {
                MessageBox.Show("Lütfen Önce Gerekli Alanları Doldurunuz");
                return;
            }
            KayıtFormu kf=new KayıtFormu();
           DialogResult sonuc= kf.ShowDialog();
            if (sonuc == DialogResult.OK) ;
            {
                ListViewItem lvi=new ListViewItem();
                lvi.Text = String.Format("{0} {1}", kf.txtisim.Text, kf.txtSoyisim.Text);
                lvi.SubItems.Add(kf.mskdtelefon.Text);
                if (kf.rdrbay.Checked) 
                {
                    lvi.SubItems.Add("Bay");
                    tiklanan.BackColor = Color.Blue;
                }
                if (kf.rdrbayan.Checked)
                {
                    lvi.SubItems.Add("Bayan");
                    tiklanan.BackColor = Color.Pink;

                }
                lvi.SubItems.Add(cmbNereden.Text);
                lvi.SubItems.Add(cmbNereden.Text);
                lvi.SubItems.Add(tiklanan.Text);
                lvi.SubItems.Add(dtpTarih.Text);
                lvi.SubItems.Add(nudFiyat.Value.ToString());
                listView1.Items.Add(lvi);



            }
        }
    }
}
