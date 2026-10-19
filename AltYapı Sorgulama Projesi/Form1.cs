using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltyapiSorgulama
{
    public partial class Form1 : Form
    {
        List<Il> iller = new List<Il>();
        List<Ilce> ilceler = new List<Ilce>();
        List<Mahalle> mahalleler = new List<Mahalle>();
        List<Sokak> sokaklar = new List<Sokak>();
        List<ApartmanNo> apartmanlar = new List<ApartmanNo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VerileriYukle();

            cmbIl.DisplayMember = "Ad";
            cmbIl.ValueMember = "Id";
            cmbIl.DataSource = iller;
            cmbIl.SelectedIndex = -1;
        }
        private void VerileriYukle()
        {
            // --- İLLER ---
            iller.Add(new Il { Id = 1, Ad = "Adana" });
            iller.Add(new Il { Id = 33, Ad = "Mersin" });
            iller.Add(new Il { Id = 34, Ad = "İstanbul" });

            // --- İLÇELER ---
            // Adana (1)
            ilceler.Add(new Ilce { Id = 1, IlId = 1, Ad = "Seyhan" });
            ilceler.Add(new Ilce { Id = 2, IlId = 1, Ad = "Çukurova" });
            ilceler.Add(new Ilce { Id = 3, IlId = 1, Ad = "Yüreğir" });

            // Mersin (33)
            ilceler.Add(new Ilce { Id = 4, IlId = 33, Ad = "Tarsus" });
            ilceler.Add(new Ilce { Id = 5, IlId = 33, Ad = "Yenişehir" });
            ilceler.Add(new Ilce { Id = 6, IlId = 33, Ad = "Mezitli" });

            // İstanbul (34)
            ilceler.Add(new Ilce { Id = 7, IlId = 34, Ad = "Kadıköy" });
            ilceler.Add(new Ilce { Id = 8, IlId = 34, Ad = "Beşiktaş" });
            ilceler.Add(new Ilce { Id = 9, IlId = 34, Ad = "Üsküdar" });

            // --- MAHALLELER ---
            mahalleler.Add(new Mahalle { Id = 1, IlceId = 1, Ad = "Gürselpaşa" });
            mahalleler.Add(new Mahalle { Id = 2, IlceId = 1, Ad = "Cemalpaşa" });
            mahalleler.Add(new Mahalle { Id = 3, IlceId = 1, Ad = "Ziyapaşa" });

            mahalleler.Add(new Mahalle { Id = 4, IlceId = 2, Ad = "Beyazevler" });
            mahalleler.Add(new Mahalle { Id = 5, IlceId = 2, Ad = "Güzelyalı" });
            mahalleler.Add(new Mahalle { Id = 6, IlceId = 2, Ad = "Toros" });

            mahalleler.Add(new Mahalle { Id = 7, IlceId = 3, Ad = "Yavuzlar" });
            mahalleler.Add(new Mahalle { Id = 8, IlceId = 3, Ad = "Serinevler" });

            mahalleler.Add(new Mahalle { Id = 9, IlceId = 4, Ad = "Kırklarsırtı" });
            mahalleler.Add(new Mahalle { Id = 10, IlceId = 4, Ad = "Yeşilyurt" });
            mahalleler.Add(new Mahalle { Id = 11, IlceId = 4, Ad = "Anıt" });

            mahalleler.Add(new Mahalle { Id = 12, IlceId = 5, Ad = "Pozcu (Güvenevler)" });
            mahalleler.Add(new Mahalle { Id = 13, IlceId = 5, Ad = "Akkent" });

            mahalleler.Add(new Mahalle { Id = 14, IlceId = 6, Ad = "Viranşehir" });
            mahalleler.Add(new Mahalle { Id = 15, IlceId = 6, Ad = "Menderes" });

            mahalleler.Add(new Mahalle { Id = 16, IlceId = 7, Ad = "Moda (Caferağa)" });
            mahalleler.Add(new Mahalle { Id = 17, IlceId = 7, Ad = "Caddebostan" });

            mahalleler.Add(new Mahalle { Id = 18, IlceId = 8, Ad = "Sinanpaşa" });
            mahalleler.Add(new Mahalle { Id = 19, IlceId = 8, Ad = "Bebek" });

            mahalleler.Add(new Mahalle { Id = 20, IlceId = 9, Ad = "Kuzguncuk" });
            mahalleler.Add(new Mahalle { Id = 21, IlceId = 9, Ad = "Acıbadem" });

            // --- SOKAKLAR VE CADDELER ---
            sokaklar.Add(new Sokak { Id = 1, MahalleId = 1, Ad = "75001. Sokak" });
            sokaklar.Add(new Sokak { Id = 2, MahalleId = 1, Ad = "Ali Sepici Bulvarı" });

            sokaklar.Add(new Sokak { Id = 3, MahalleId = 2, Ad = "Gazipaşa Bulvarı" });
            sokaklar.Add(new Sokak { Id = 4, MahalleId = 2, Ad = "Toros Caddesi" });

            sokaklar.Add(new Sokak { Id = 5, MahalleId = 4, Ad = "Adnan Kahveci Bulvarı" });

            sokaklar.Add(new Sokak { Id = 6, MahalleId = 9, Ad = "2601. Sokak" });
            sokaklar.Add(new Sokak { Id = 7, MahalleId = 9, Ad = "Celal Bayar Caddesi" });

            sokaklar.Add(new Sokak { Id = 8, MahalleId = 12, Ad = "Kushimoto Sokağı" });
            sokaklar.Add(new Sokak { Id = 9, MahalleId = 12, Ad = "Gazi Mustafa Kemal Bulvarı" });

            sokaklar.Add(new Sokak { Id = 10, MahalleId = 16, Ad = "Moda Caddesi" });
            sokaklar.Add(new Sokak { Id = 11, MahalleId = 16, Ad = "Şair Nefi Sokak" });

            // --- APARTMANLAR (HER SOKAĞA EKLENDİ) ---
            // 75001. Sokak (SokakId = 1)
            apartmanlar.Add(new ApartmanNo { Id = 1, SokakId = 1, No = "Güneş Apt. No: 10", AltYapi = new List<string> { "Türk Telekom Fiber 1000 Mbps", "Kablonet 100 Mbps" } });
            apartmanlar.Add(new ApartmanNo { Id = 2, SokakId = 1, No = "Barış Apt. No: 12", AltYapi = new List<string> { "VDSL 75 Mbps", "ADSL 16 Mbps" } });

            // Ali Sepici Bulvarı (SokakId = 2)
            apartmanlar.Add(new ApartmanNo { Id = 3, SokakId = 2, No = "Mavi Köşe No: 5", AltYapi = new List<string> { "Türk Telekom Fiber 500 Mbps", "Turkcell Superonline 1000 Mbps" } });
            apartmanlar.Add(new ApartmanNo { Id = 4, SokakId = 2, No = "Karanfil Apt. No: 14", AltYapi = new List<string> { "VDSL 50 Mbps" } });

            // Gazipaşa Bulvarı (SokakId = 3)
            apartmanlar.Add(new ApartmanNo { Id = 5, SokakId = 3, No = "Çukurova Plaza No: 24", AltYapi = new List<string> { "Turkcell Superonline Fiber 1000 Mbps", "Vodafone Fiber 500 Mbps" } });
            apartmanlar.Add(new ApartmanNo { Id = 6, SokakId = 3, No = "Ekin Apt. No: 8", AltYapi = new List<string> { "Türk Telekom VDSL 100 Mbps" } });

            // Toros Caddesi (SokakId = 4)
            apartmanlar.Add(new ApartmanNo { Id = 7, SokakId = 4, No = "Toros İş Merkezi No: 18", AltYapi = new List<string> { "Türk Telekom Fiber 1000 Mbps", "Kablonet 100 Mbps" } });
            apartmanlar.Add(new ApartmanNo { Id = 8, SokakId = 4, No = "Huzur Apt. No: 22", AltYapi = new List<string> { "VDSL 35 Mbps" } });

            // Adnan Kahveci Bulvarı (SokakId = 5)
            apartmanlar.Add(new ApartmanNo { Id = 9, SokakId = 5, No = "Göl Manzara Evleri No: 3", AltYapi = new List<string> { "Türk Telekom GPON Fiber 1000 Mbps", "TurkNet GigaFiber 1000 Mbps" } });
            apartmanlar.Add(new ApartmanNo { Id = 10, SokakId = 5, No = "Baraj Apt. No: 7", AltYapi = new List<string> { "VDSL 75 Mbps" } });

            // 2601. Sokak - Tarsus (SokakId = 6)
            apartmanlar.Add(new ApartmanNo { Id = 11, SokakId = 6, No = "Akdeniz Blok No: 4", AltYapi = new List<string> { "Türk Telekom Fiber 1000 Mbps", "VDSL 50 Mbps" } });
            apartmanlar.Add(new ApartmanNo { Id = 12, SokakId = 6, No = "Yıldız Sitesi No: 8/A", AltYapi = new List<string> { "Superonline Fiber 500 Mbps", "Kablonet 100 Mbps" } });

            // Celal Bayar Caddesi - Tarsus (SokakId = 7)
            apartmanlar.Add(new ApartmanNo { Id = 13, SokakId = 7, No = "Kleopatra Apt. No: 15", AltYapi = new List<string> { "Türk Telekom VDSL 50 Mbps", "ADSL 16 Mbps" } });
            apartmanlar.Add(new ApartmanNo { Id = 14, SokakId = 7, No = "Çukurova Konutları No: 20", AltYapi = new List<string> { "Türk Telekom GPON Fiber 1000 Mbps" } });

            // Kushimoto Sokağı - Pozcu (SokakId = 8)
            apartmanlar.Add(new ApartmanNo { Id = 15, SokakId = 8, No = "Palmiye Apt. No: 15", AltYapi = new List<string> { "Türk Telekom GPON Fiber 1000 Mbps", "TurkNet GigaFiber 1000 Mbps" } });
            apartmanlar.Add(new ApartmanNo { Id = 16, SokakId = 8, No = "Marina Apt. No: 21", AltYapi = new List<string> { "Vodafone Fiber 200 Mbps" } });

            // Gazi Mustafa Kemal Bulvarı - Mersin (SokakId = 9)
            apartmanlar.Add(new ApartmanNo { Id = 17, SokakId = 9, No = "Sahil Rezidans No: 110", AltYapi = new List<string> { "Turkcell Superonline 1000 Mbps", "Kablonet 100 Mbps" } });
            apartmanlar.Add(new ApartmanNo { Id = 18, SokakId = 9, No = "Akdeniz Apt. No: 145", AltYapi = new List<string> { "Türk Telekom Fiber 500 Mbps" } });

            // Moda Caddesi - Kadıköy (SokakId = 10)
            apartmanlar.Add(new ApartmanNo { Id = 19, SokakId = 10, No = "Köşk Apt. No: 45", AltYapi = new List<string> { "TurkNet GigaFiber 1000 Mbps", "Superonline Fiber 1000 Mbps" } });
            apartmanlar.Add(new ApartmanNo { Id = 20, SokakId = 10, No = "Tarihi Moda Palas No: 47", AltYapi = new List<string> { "VDSL 35 Mbps", "Türk Telekom Fiber 100 Mbps" } });

            // Şair Nefi Sokak - Kadıköy (SokakId = 11)
            apartmanlar.Add(new ApartmanNo { Id = 21, SokakId = 11, No = "Nefis Apt. No: 12", AltYapi = new List<string> { "Türk Telekom GPON Fiber 1000 Mbps" } });
            apartmanlar.Add(new ApartmanNo { Id = 22, SokakId = 11, No = "Sanat Apt. No: 18", AltYapi = new List<string> { "VDSL 75 Mbps", "ADSL 16 Mbps" } });
        }
        
        

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIl.SelectedItem is Il secilen)
            {
                cmbIlce.DataSource = null;
                cmbIlce.DisplayMember = "Ad";
                cmbIlce.ValueMember = "Id";
                cmbIlce.DataSource = ilceler.Where(x => x.IlId == secilen.Id).ToList();
                cmbIlce.SelectedIndex = -1;
            }
        }

        private void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIlce.SelectedItem is Ilce secilen)
            {
                cmbMahalle.DataSource = null;
                cmbMahalle.DisplayMember = "Ad";
                cmbMahalle.ValueMember = "Id";
                cmbMahalle.DataSource = mahalleler.Where(x => x.IlceId == secilen.Id).ToList();
                cmbMahalle.SelectedIndex = -1; ;
            }
        }

        private void cmbMahalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMahalle.SelectedItem is Mahalle secilen)
            {
                cmbSokak.DataSource = null;
                cmbSokak.DisplayMember = "Ad";
                cmbSokak.ValueMember = "Id";
                cmbSokak.DataSource = sokaklar.Where(x => x.MahalleId == secilen.Id).ToList();
                cmbSokak.SelectedIndex = -1;
            }
        }

        private void cmbSokak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSokak.SelectedItem is Sokak secilen)
            {
                cmbAptNo.DataSource = null;
                cmbAptNo.DisplayMember = "No";
                cmbAptNo.ValueMember = "Id";
                cmbAptNo.DataSource = apartmanlar.Where(x => x.SokakId == secilen.Id).ToList();
                cmbAptNo.SelectedIndex = -1;
            }
        }

        private void cmbAptNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxAltyapi.Items.Clear();

            if (cmbAptNo.SelectedItem is ApartmanNo secilen)
            {
                foreach (var yapi in secilen.AltYapi)
                {
                    listBoxAltyapi.Items.Add(yapi);
                }
            }
        }
    }
}
