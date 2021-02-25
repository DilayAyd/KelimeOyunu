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

namespace Bir_kelime_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random Rastgele = new Random();

        public List<string> validWords { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rastgele_Click(object sender, EventArgs e)
        {
            string Harf1, Harf2, Harf3, Harf4, Harf5, Harf6, Harf7, Harf8;
            int harfler;
            string[] dizi = { "A", "B", "C","Ç","D","E","F","G","Ğ","H","I","İ","J","K","L","M","N","O","Ö","P","R","S","Ş","T","U","Ü","V","Y","Z" };

            harfler = Rastgele.Next(0, dizi.Length);
            Harf1 = (dizi[harfler]);
            harf1txb.Text = Harf1.ToString();

            harfler = Rastgele.Next(0, dizi.Length);
            Harf2 = (dizi[harfler]);
            harf2txb.Text = Harf2.ToString();

            harfler = Rastgele.Next(0, dizi.Length);
            Harf3 = (dizi[harfler]);
            harf3txb.Text = Harf3.ToString();

            harfler = Rastgele.Next(0, dizi.Length);
            Harf4 = (dizi[harfler]);
            harf4txb.Text = Harf4.ToString();

            harfler = Rastgele.Next(0, dizi.Length);
            Harf5 = (dizi[harfler]);
            harf5txb.Text = Harf5.ToString();

            harfler = Rastgele.Next(0, dizi.Length);
            Harf6 = (dizi[harfler]);
            harf6txb.Text = Harf6.ToString();

            harfler = Rastgele.Next(0, dizi.Length);
            Harf7 = (dizi[harfler]);
            harf7txb.Text = Harf7.ToString();

            harfler = Rastgele.Next(0, dizi.Length);
            Harf8 = (dizi[harfler]);
            harf8txb.Text = Harf8.ToString();
            jokertxb.Text = "?";

            
            string[] olusturulan =



             validWords = new List<string>(File.ReadAllText("kelimeler.txt").Split(' '));

            foreach (var result in validWords.Where(word =>
                         IsWordInString(word, Harf1, Harf2, Harf3, Harf4, Harf5, Harf6,Harf7,Harf8,)))
            {
                kelimegoster.Text = result;
            }
        }

        static bool IsWordInString(string word, string source)
        {
            var letterList = source.ToList();

            return word.All(letterList.Remove);
        }

        private void Elile_Click(object sender, EventArgs e)
        {
            harf1txb.Text = "";
            harf2txb.Text = "";
            harf3txb.Text = "";
            harf4txb.Text = "";
            harf5txb.Text = "";
            harf6txb.Text = "";
            harf7txb.Text = "";
            harf8txb.Text = "";
            jokertxb.Text = "?";

        }

        private void kelime_Click(object sender, EventArgs e)
        {

        }

        private void puan_Click(object sender, EventArgs e)
        {

        }

        private void kelimegoster_Click(object sender, EventArgs e)
        {
            
            int uzunluk = kelime.Height;

            //Klavyeden girilecek tüm olası durumlar için swtich case yapısı kullanıyorum. KArışılığında ne yapılacağını yazıyorum.
            switch (uzunluk)
            {
                case 3:
                    sonuckelimetxb.Text="3";
                    break;

                case 4:
                    sonuckelimetxb.Text = "4";
                    break;

                case 5:
                    sonuckelimetxb.Text = "5";
                    break;

                case 6:
                    sonuckelimetxb.Text = "7";
                    break;

                case 7:
                    sonuckelimetxb.Text = "9";
                    break;

                case 8:
                    sonuckelimetxb.Text = "11";
                    break;

                case 9:
                    sonuckelimetxb.Text = "15";
                    break;

                default:
                    MessageBox.Show("kelime puanlama aralığında değil");
                    break;



            }
        }
    }
   
    
}
