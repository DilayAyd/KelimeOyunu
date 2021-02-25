namespace Bir_kelime_oyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rastgele = new System.Windows.Forms.Button();
            this.Elile = new System.Windows.Forms.Button();
            this.harf1 = new System.Windows.Forms.Label();
            this.harf2 = new System.Windows.Forms.Label();
            this.harf3 = new System.Windows.Forms.Label();
            this.harf4 = new System.Windows.Forms.Label();
            this.harf5 = new System.Windows.Forms.Label();
            this.harf6 = new System.Windows.Forms.Label();
            this.harf7 = new System.Windows.Forms.Label();
            this.harf8 = new System.Windows.Forms.Label();
            this.joker = new System.Windows.Forms.Label();
            this.harf1txb = new System.Windows.Forms.TextBox();
            this.harf2txb = new System.Windows.Forms.TextBox();
            this.harf3txb = new System.Windows.Forms.TextBox();
            this.harf4txb = new System.Windows.Forms.TextBox();
            this.harf5txb = new System.Windows.Forms.TextBox();
            this.harf6txb = new System.Windows.Forms.TextBox();
            this.harf7txb = new System.Windows.Forms.TextBox();
            this.harf8txb = new System.Windows.Forms.TextBox();
            this.jokertxb = new System.Windows.Forms.TextBox();
            this.kelime = new System.Windows.Forms.Label();
            this.sonuckelimetxb = new System.Windows.Forms.TextBox();
            this.puan = new System.Windows.Forms.Label();
            this.puantxb = new System.Windows.Forms.TextBox();
            this.kelimegoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Harfleri nasıl girmek istersiniz?";
            // 
            // rastgele
            // 
            this.rastgele.BackColor = System.Drawing.Color.LavenderBlush;
            this.rastgele.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rastgele.ForeColor = System.Drawing.Color.SteelBlue;
            this.rastgele.Location = new System.Drawing.Point(470, 23);
            this.rastgele.Name = "rastgele";
            this.rastgele.Size = new System.Drawing.Size(200, 49);
            this.rastgele.TabIndex = 1;
            this.rastgele.Text = "RASTGELE";
            this.rastgele.UseVisualStyleBackColor = false;
            this.rastgele.Click += new System.EventHandler(this.rastgele_Click);
            // 
            // Elile
            // 
            this.Elile.BackColor = System.Drawing.Color.LavenderBlush;
            this.Elile.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Elile.ForeColor = System.Drawing.Color.SteelBlue;
            this.Elile.Location = new System.Drawing.Point(470, 111);
            this.Elile.Name = "Elile";
            this.Elile.Size = new System.Drawing.Size(200, 50);
            this.Elile.TabIndex = 2;
            this.Elile.Text = "EL İLE";
            this.Elile.UseVisualStyleBackColor = false;
            this.Elile.Click += new System.EventHandler(this.Elile_Click);
            // 
            // harf1
            // 
            this.harf1.AutoSize = true;
            this.harf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf1.Location = new System.Drawing.Point(43, 199);
            this.harf1.Name = "harf1";
            this.harf1.Size = new System.Drawing.Size(78, 20);
            this.harf1.TabIndex = 3;
            this.harf1.Text = "1. HARF";
            // 
            // harf2
            // 
            this.harf2.AutoSize = true;
            this.harf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf2.Location = new System.Drawing.Point(43, 251);
            this.harf2.Name = "harf2";
            this.harf2.Size = new System.Drawing.Size(78, 20);
            this.harf2.TabIndex = 4;
            this.harf2.Text = "2. HARF";
            // 
            // harf3
            // 
            this.harf3.AutoSize = true;
            this.harf3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf3.Location = new System.Drawing.Point(43, 301);
            this.harf3.Name = "harf3";
            this.harf3.Size = new System.Drawing.Size(78, 20);
            this.harf3.TabIndex = 5;
            this.harf3.Text = "3. HARF";
            // 
            // harf4
            // 
            this.harf4.AutoSize = true;
            this.harf4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf4.Location = new System.Drawing.Point(43, 350);
            this.harf4.Name = "harf4";
            this.harf4.Size = new System.Drawing.Size(78, 20);
            this.harf4.TabIndex = 6;
            this.harf4.Text = "4. HARF";
            // 
            // harf5
            // 
            this.harf5.AutoSize = true;
            this.harf5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf5.Location = new System.Drawing.Point(43, 398);
            this.harf5.Name = "harf5";
            this.harf5.Size = new System.Drawing.Size(78, 20);
            this.harf5.TabIndex = 7;
            this.harf5.Text = "5. HARF";
            // 
            // harf6
            // 
            this.harf6.AutoSize = true;
            this.harf6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf6.Location = new System.Drawing.Point(43, 445);
            this.harf6.Name = "harf6";
            this.harf6.Size = new System.Drawing.Size(78, 20);
            this.harf6.TabIndex = 8;
            this.harf6.Text = "6. HARF";
            // 
            // harf7
            // 
            this.harf7.AutoSize = true;
            this.harf7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf7.Location = new System.Drawing.Point(43, 492);
            this.harf7.Name = "harf7";
            this.harf7.Size = new System.Drawing.Size(78, 20);
            this.harf7.TabIndex = 9;
            this.harf7.Text = "7. HARF";
            // 
            // harf8
            // 
            this.harf8.AutoSize = true;
            this.harf8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf8.Location = new System.Drawing.Point(43, 535);
            this.harf8.Name = "harf8";
            this.harf8.Size = new System.Drawing.Size(78, 20);
            this.harf8.TabIndex = 10;
            this.harf8.Text = "8. HARF";
            // 
            // joker
            // 
            this.joker.AutoSize = true;
            this.joker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.joker.Location = new System.Drawing.Point(42, 602);
            this.joker.Name = "joker";
            this.joker.Size = new System.Drawing.Size(155, 25);
            this.joker.TabIndex = 11;
            this.joker.Text = "JOKER HARF";
            // 
            // harf1txb
            // 
            this.harf1txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf1txb.ForeColor = System.Drawing.Color.SteelBlue;
            this.harf1txb.Location = new System.Drawing.Point(165, 192);
            this.harf1txb.Name = "harf1txb";
            this.harf1txb.Size = new System.Drawing.Size(60, 31);
            this.harf1txb.TabIndex = 12;
            this.harf1txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // harf2txb
            // 
            this.harf2txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf2txb.ForeColor = System.Drawing.Color.SteelBlue;
            this.harf2txb.Location = new System.Drawing.Point(165, 244);
            this.harf2txb.Name = "harf2txb";
            this.harf2txb.Size = new System.Drawing.Size(60, 31);
            this.harf2txb.TabIndex = 13;
            this.harf2txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // harf3txb
            // 
            this.harf3txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf3txb.ForeColor = System.Drawing.Color.SteelBlue;
            this.harf3txb.Location = new System.Drawing.Point(165, 294);
            this.harf3txb.Name = "harf3txb";
            this.harf3txb.Size = new System.Drawing.Size(60, 31);
            this.harf3txb.TabIndex = 14;
            this.harf3txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // harf4txb
            // 
            this.harf4txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf4txb.ForeColor = System.Drawing.Color.SteelBlue;
            this.harf4txb.Location = new System.Drawing.Point(165, 343);
            this.harf4txb.Name = "harf4txb";
            this.harf4txb.Size = new System.Drawing.Size(60, 31);
            this.harf4txb.TabIndex = 15;
            this.harf4txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // harf5txb
            // 
            this.harf5txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf5txb.ForeColor = System.Drawing.Color.SteelBlue;
            this.harf5txb.Location = new System.Drawing.Point(165, 391);
            this.harf5txb.Name = "harf5txb";
            this.harf5txb.Size = new System.Drawing.Size(60, 31);
            this.harf5txb.TabIndex = 16;
            this.harf5txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // harf6txb
            // 
            this.harf6txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf6txb.ForeColor = System.Drawing.Color.SteelBlue;
            this.harf6txb.Location = new System.Drawing.Point(165, 528);
            this.harf6txb.Name = "harf6txb";
            this.harf6txb.Size = new System.Drawing.Size(60, 31);
            this.harf6txb.TabIndex = 17;
            this.harf6txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // harf7txb
            // 
            this.harf7txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf7txb.ForeColor = System.Drawing.Color.SteelBlue;
            this.harf7txb.Location = new System.Drawing.Point(165, 438);
            this.harf7txb.Name = "harf7txb";
            this.harf7txb.Size = new System.Drawing.Size(60, 31);
            this.harf7txb.TabIndex = 18;
            this.harf7txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // harf8txb
            // 
            this.harf8txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf8txb.ForeColor = System.Drawing.Color.SteelBlue;
            this.harf8txb.Location = new System.Drawing.Point(165, 485);
            this.harf8txb.Name = "harf8txb";
            this.harf8txb.Size = new System.Drawing.Size(60, 31);
            this.harf8txb.TabIndex = 19;
            this.harf8txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // jokertxb
            // 
            this.jokertxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.jokertxb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.jokertxb.Location = new System.Drawing.Point(235, 599);
            this.jokertxb.Name = "jokertxb";
            this.jokertxb.Size = new System.Drawing.Size(74, 31);
            this.jokertxb.TabIndex = 20;
            this.jokertxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kelime
            // 
            this.kelime.AutoSize = true;
            this.kelime.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelime.Location = new System.Drawing.Point(397, 350);
            this.kelime.Name = "kelime";
            this.kelime.Size = new System.Drawing.Size(273, 64);
            this.kelime.TabIndex = 21;
            this.kelime.Text = " Oluşturulan\r\nEn Uzun Kelime:";
            this.kelime.Click += new System.EventHandler(this.kelime_Click);
            // 
            // sonuckelimetxb
            // 
            this.sonuckelimetxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuckelimetxb.Location = new System.Drawing.Point(410, 425);
            this.sonuckelimetxb.Name = "sonuckelimetxb";
            this.sonuckelimetxb.Size = new System.Drawing.Size(260, 40);
            this.sonuckelimetxb.TabIndex = 22;
            // 
            // puan
            // 
            this.puan.AutoSize = true;
            this.puan.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puan.Location = new System.Drawing.Point(388, 528);
            this.puan.Name = "puan";
            this.puan.Size = new System.Drawing.Size(316, 34);
            this.puan.TabIndex = 23;
            this.puan.Text = "Kazanılan Puan:";
            this.puan.Click += new System.EventHandler(this.puan_Click);
            // 
            // puantxb
            // 
            this.puantxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puantxb.Location = new System.Drawing.Point(501, 587);
            this.puantxb.Name = "puantxb";
            this.puantxb.Size = new System.Drawing.Size(79, 47);
            this.puantxb.TabIndex = 24;
            // 
            // kelimegoster
            // 
            this.kelimegoster.BackColor = System.Drawing.Color.LavenderBlush;
            this.kelimegoster.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelimegoster.ForeColor = System.Drawing.Color.SteelBlue;
            this.kelimegoster.Location = new System.Drawing.Point(394, 251);
            this.kelimegoster.Name = "kelimegoster";
            this.kelimegoster.Size = new System.Drawing.Size(257, 76);
            this.kelimegoster.TabIndex = 25;
            this.kelimegoster.Text = "KELİMEYİ GÖSTER";
            this.kelimegoster.UseVisualStyleBackColor = false;
            this.kelimegoster.Click += new System.EventHandler(this.kelimegoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 668);
            this.Controls.Add(this.kelimegoster);
            this.Controls.Add(this.puantxb);
            this.Controls.Add(this.puan);
            this.Controls.Add(this.sonuckelimetxb);
            this.Controls.Add(this.kelime);
            this.Controls.Add(this.jokertxb);
            this.Controls.Add(this.harf8txb);
            this.Controls.Add(this.harf7txb);
            this.Controls.Add(this.harf6txb);
            this.Controls.Add(this.harf5txb);
            this.Controls.Add(this.harf4txb);
            this.Controls.Add(this.harf3txb);
            this.Controls.Add(this.harf2txb);
            this.Controls.Add(this.harf1txb);
            this.Controls.Add(this.joker);
            this.Controls.Add(this.harf8);
            this.Controls.Add(this.harf7);
            this.Controls.Add(this.harf6);
            this.Controls.Add(this.harf5);
            this.Controls.Add(this.harf4);
            this.Controls.Add(this.harf3);
            this.Controls.Add(this.harf2);
            this.Controls.Add(this.harf1);
            this.Controls.Add(this.Elile);
            this.Controls.Add(this.rastgele);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rastgele;
        private System.Windows.Forms.Button Elile;
        private System.Windows.Forms.Label harf1;
        private System.Windows.Forms.Label harf2;
        private System.Windows.Forms.Label harf3;
        private System.Windows.Forms.Label harf4;
        private System.Windows.Forms.Label harf5;
        private System.Windows.Forms.Label harf6;
        private System.Windows.Forms.Label harf7;
        private System.Windows.Forms.Label harf8;
        private System.Windows.Forms.Label joker;
        private System.Windows.Forms.TextBox harf1txb;
        private System.Windows.Forms.TextBox harf2txb;
        private System.Windows.Forms.TextBox harf3txb;
        private System.Windows.Forms.TextBox harf4txb;
        private System.Windows.Forms.TextBox harf5txb;
        private System.Windows.Forms.TextBox harf6txb;
        private System.Windows.Forms.TextBox harf7txb;
        private System.Windows.Forms.TextBox harf8txb;
        private System.Windows.Forms.TextBox jokertxb;
        private System.Windows.Forms.Label kelime;
        private System.Windows.Forms.TextBox sonuckelimetxb;
        private System.Windows.Forms.Label puan;
        private System.Windows.Forms.TextBox puantxb;
        private System.Windows.Forms.Button kelimegoster;
    }
}

