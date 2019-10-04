using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Numerics;
using System.Collections;

namespace TekCift
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void EkranHazırla()
        {
            mtxtBaslangic.Focus();
            string anahtarDegeri = ConfigurationSettings.AppSettings.Get("işlem_tipi");
            if(anahtarDegeri == "asal")
            {
                tabIslemler.SelectTab(tabAsalSayilar); 
            }
            ntfIslemler.ShowBalloonTip(3000);
        }
        private Boolean sayiKontrol(int baslangıcDeger,int bitisDeger)
        {
            if (bitisDeger > baslangıcDeger & baslangıcDeger>0 & bitisDeger>0 )
            { 
                return true;
            }
            return false;
        }
        
        

        private void yazma(int baslangıcDegeri, int bitisDegeri)
        {
            
            using (StreamWriter sw = new StreamWriter("log.txt",true))
            {
                if (tabIslemler.SelectedIndex == 0 )
                {
                    sw.WriteLine("\n" + DateTime.Now.ToString() + " Tek Sayilar");
                    for (int i = baslangıcDegeri; i <= bitisDegeri; i++)

                    {
                        if ((i % 2) == 1)
                        {
                            sw.Write(" " + i.ToString());
                        }
                    }
                }
                else if (tabIslemler.SelectedIndex == 1)
                {
                    sw.WriteLine("\n"+DateTime.Now.ToString() + " Cift Sayilar");
                    for (int i = baslangıcDegeri; i <= bitisDegeri; i++)
                    {
                        if ((i % 2) == 0)
                        {
                            sw.Write(" " + i.ToString());
                        }
                    }
                }
                else if (tabIslemler.SelectedIndex == 2)
                {
                    sw.WriteLine("\n" + DateTime.Now.ToString() + " Asal Sayilar");
                    for (int i = baslangıcDegeri; i <= bitisDegeri; i++)
                    {
                        int sayac = 0;
                        int sayi = i;
                        for (int k = 2; k < sayi; k++)
                        {
                            if (sayi % k == 0)
                            {
                                sayac++;
                                break;
                            }
                        }
                        if (sayac == 0)
                        {
                            sw.Write(" " + i.ToString());
                        }
                    }
                }
                else if (tabIslemler.SelectedIndex == 3)
                {
                    sw.WriteLine("\n" + DateTime.Now.ToString() + " Armstrong Sayilar");
                    for (int i = baslangıcDegeri; i <= bitisDegeri; i++)
                    {
                        int gecici, basamakDeger = 0, basamakSayisi = 0;

                        double sonuc = 0;

                        gecici = i;
                        while (gecici != 0)
                        {
                            basamakSayisi++;
                            gecici = gecici / 10;
                        }

                        gecici = i;

                        while (gecici != 0)
                        {
                            basamakDeger = gecici % 10;
                            sonuc = sonuc + Math.Pow((double)basamakDeger, (double)basamakSayisi);
                            gecici = gecici / 10;
                        }

                        if (i == sonuc)
                        {
                            sw.Write(" " + i.ToString());
                        }
                    }
                }

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int tekToplam = 0, ciftToplam = 0, asalToplam = 0,armstrongToplam=0;
            BigInteger tekCarpim = 1, ciftCarpim = 1, asalCarpim = 1;
            BigInteger armstrongCarpim=1;
            
            int baslangıc =Convert.ToInt32( mtxtBaslangic.Text);
            int bitis = Convert.ToInt32(mtxtBitis.Text);
            
            if(sayiKontrol(baslangıc, bitis))
            {
                if (tabIslemler.SelectedIndex == 0)
                {
                    lwTekSayilar.Clear();
                    for (int i = baslangıc; i <= bitis; i++)
                    {
                        if ((i % 2) == 1)
                        {
                            tekToplam += i;
                            tekCarpim *= i;
                            lwTekSayilar.Items.Add(" " + i);
                        }
                    }
                    txtTekSayilarToplam.Text = tekToplam.ToString();
                    txtTekSayilarCarpim.Text = tekCarpim.ToString();
                }
                else if (tabIslemler.SelectedIndex == 1)
                {
                    lwCiftSayilar.Clear();
                    for (int i = baslangıc; i <= bitis; i++)
                    {
                        if ((i % 2) == 0)
                        {
                            ciftToplam += i;
                            ciftCarpim *= i;
                            lwCiftSayilar.Items.Add(" " + i);
                        }
                    }
                    txtCiftSayilarToplam.Text = ciftToplam.ToString();
                    txtCiftSayilarCarpim.Text = ciftCarpim.ToString();
                }
                else if (tabIslemler.SelectedIndex == 2)
                {
                    lwAsalSayilar.Clear();
                    for (int i = baslangıc; i <= bitis; i++)
                    {

                        int sayac = 0;
                        int sayi = i;
                        for (int k = 2; k < sayi; k++)
                        {
                            if (sayi % k == 0)
                            {
                                sayac++;
                                break;
                            }
                        }
                        if (sayac == 0)
                        {
                            lwAsalSayilar.Items.Add(" " + i);
                            asalToplam += i;
                            asalCarpim *= i;
                        }
                        txtAsalSayilarCarpim.Text = asalCarpim.ToString();
                        txtAsalSayilarToplam.Text = asalToplam.ToString();

                    }
                }
                else if (tabIslemler.SelectedIndex == 3)
                {

                    lwArmstrongSayilar.Clear();
                    for (int i = baslangıc; i <= bitis; i++)
                    {
                        int gecici, basamakDeger = 0, basamakSayisi = 0;

                        double sonuc = 0;

                        gecici = i;
                        while (gecici != 0)
                        {
                            basamakSayisi++;
                            gecici = gecici / 10;
                        }

                        gecici = i;

                        while (gecici != 0)
                        {
                            basamakDeger = gecici % 10;
                            sonuc = sonuc + Math.Pow((double)basamakDeger, (double)basamakSayisi);
                            gecici = gecici / 10;
                        }

                        if (i == sonuc)
                        {
                            lwArmstrongSayilar.Items.Add(" " + i);
                            armstrongCarpim *= i;
                            armstrongToplam += i;

                        }


                    }
                    txtArmstrongSayilarCarpim.Text = armstrongCarpim.ToString();
                    txtArmstrongSayilarToplam.Text = armstrongToplam.ToString();


                }
                yazma(baslangıc, bitis);

            }
            else
            {
                MessageBox.Show("Yanlış değer girdiniz lütfen 1 ile 10000 arasındaki değerleri girin");
            }
            
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            EkranHazırla();
            
                
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            int indexDeğeri = tabIslemler.SelectedIndex;
            if (indexDeğeri > 0)
            {
                tabIslemler.SelectedIndex = indexDeğeri - 1;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            int indexDeğeri = tabIslemler.SelectedIndex;
            if (indexDeğeri<4 )
            {
                tabIslemler.SelectedIndex = indexDeğeri +1;
            }
        }
    }
}
