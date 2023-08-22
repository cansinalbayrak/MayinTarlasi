using System.Collections;

namespace MayınTarlası
{
    public partial class Form1 : Form
    {
        int mayinSayisi;
        ArrayList mayinlar = new ArrayList();
        int saniye;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Mayın Tarlası Oyununa Hoşgeldiniz.");
        }
        private void btnBaşlat_Click(object sender, EventArgs e)
        {
            SureMayinKontrol();
            timer1.Start();
            saniye = Convert.ToInt32(tbSüreAl.Text);
            MayinButonOlustur();
        }
        public void MayinButonOlustur() //Tüm butonları ve mayınları oluştur metodu.
        {
            panelTarla.Controls.Clear();
            mayinSayisi = Convert.ToInt32(tbMayınAl.Text);
            Random rnd = new Random();
            for (int i = 0; i < mayinSayisi; i++) 
            {
            A:
                int temp = rnd.Next(0, 100);
                if (mayinlar.Contains(temp)) 
                {
                    //i--;
                    goto A;
                }
                else
                {
                    mayinlar.Add(temp);
                }

            }
            for (int i = 0; i < 100; i++) 
            {
                Button btn = new Button();
                btn.Width = 40;
                btn.Height = 40;
                btn.BackColor = Color.Gray; 
                if (mayinlar.Contains(i)) 
                {
                    btn.Tag = true;
                }
                else
                {
                    btn.Tag = false;
                }
                btn.Click += btn_Click; 
                panelTarla.Controls.Add(btn);
            }

        }
        private void btn_Click(object sender, EventArgs e) 
        {
            Button tiklanan = (Button)sender;
            if ((bool)tiklanan.Tag == true) 
            {
                tiklanan.BackColor = Color.Red;
                Thread.Sleep(5000);
                foreach (var item in panelTarla.Controls) 
                {
                    Button btn = (Button)item;
                    if ((bool)btn.Tag == true)
                    {
                        btn.BackColor = Color.Red;
                    }
                    else
                    {
                        btn.BackColor = Color.Green;
                    }
                }
                timer1.Stop(); 
                DialogResult secenek = MessageBox.Show("Kaybettiniz, oyunu aynı özelliklerle yeniden başlatmak ister misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secenek == DialogResult.Yes)
                {
                    this.Refresh();
                }
                else if (secenek == DialogResult.No)
                {
                    Application.Exit();
                }
                panelTarla.Controls.Clear();
            }
            else if((bool)tiklanan.Tag == false) 
            {
                tiklanan.BackColor = Color.Green;
                tiklanan.Text = "X";
                

            }
            List<Button> tiklananButonSayisi = new List<Button>();

            for (int i = 0; i < tiklananButonSayisi.Count; i++)
            {
                tiklananButonSayisi[i] = tiklanan;
            }
            if (tiklananButonSayisi.Count == panelTarla.Controls.Count - mayinSayisi) 
            {
                timer1.Stop();
                DialogResult secenek = MessageBox.Show("Kazandınız!, oyunu aynı özelliklerle yeniden başlatmak ister misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secenek == DialogResult.Yes)
                {
                    this.Refresh();
                }
                else if (secenek == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            saniye = saniye - 1;          

            lblSüreGöster.Text = ((saniye%3600)/60).ToString("00") + ":" + (saniye%60).ToString("00");
            if (saniye == 00)                
            {
                timer1.Stop();
                DialogResult secenek = MessageBox.Show("Süreniz doldu, oyunu aynı özelliklerle yeniden başlatmak ister misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(secenek == DialogResult.Yes)
                {
                    this.Refresh();
                }
                else if(secenek == DialogResult.No)
                {
                    Application.Exit();
                }

            }



        }
        public void SureMayinKontrol() 
        {
            if(int.Parse(tbMayınAl.Text) < 1)
            {
                MessageBox.Show("Mayın sayısı minimum 1 adet olmalıdır.");
                Application.Restart();
                
            }
            if(int.Parse(tbSüreAl.Text) < 30)
            {
                MessageBox.Show("Oyun süresi 30 saniyeden az olamaz.");
                Application.Restart();
            }
        }
    }
}