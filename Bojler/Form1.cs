namespace Bojler
{
    public partial class Form1 : Form
    {
        public bool Vytok = true;
        public bool Ohrev = true;
        public bool Automat = true;
        public float SpotrebakW = 0;
        public float SpotrebaL = 0;
        public float Teplota = 10;
        public int Cas = 0;
        public int Objem = 100;
        public float MernaTepelnaKapacita = 4180f;
        public float OhratiZaSekundu;
        public Form1()
        {
            InitializeComponent();
            buttonVentil.Text = Vytok ? "Vytok" : "Nevytok";
            buttonOhrev.Text = Ohrev ? "Ohøejvá" : "Neohøejvá";
            buttonAuto.Text = Automat ? "Auto" : "Manual";
            labelTrackCas.Text = trackBarCas.Value.ToString();
            labelUmPrutok.Text = trackBarUmPrutok.Value.ToString();
            labelUmTeplota.Text = trackBarUmTeplota.Value.ToString();
            labelSpPrutok.Text = trackBarSpPrutok.Value.ToString();
            labelSpTeplota.Text = trackBarSpTeplota.Value.ToString();
            OhratiZaSekundu = 1f / (MernaTepelnaKapacita * Objem / 4000f);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void buttonVentil_Click(object sender, EventArgs e)
        {
            Vytok = !Vytok;
            buttonVentil.Text = Vytok ? "Vytok" : "Nevytok";
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush pen = new SolidBrush(Color.Blue);
            g.FillEllipse(pen, 0, 0, 130, 50);
            g.FillEllipse(pen, 0, 147, 130, 50);
            g.FillRectangle(pen, 0, 25, 130, 150);
        }

        private void buttonOhrev_Click(object sender, EventArgs e)
        {
            Ohrev = !Ohrev;
            buttonOhrev.Text = Ohrev ? "Ohøejvá" : "Neohøejvá";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelCas.Text = Cas.ToString() + " s";
            labelSpotrebaW.Text = SpotrebakW.ToString() + " kW";
            labelSpotrebaL.Text = SpotrebaL.ToString() + " L";
            labelTeplota.Text = Teplota.ToString() + " °C";
            if (Automat)
            {
                if (Teplota < 50)
                {
                    Ohrev = true;
                }
                else if (Teplota > 70)
                {
                    Ohrev = false;
                }
                buttonOhrev.Text = Ohrev ? "Ohøejvá" : "Neohøejvá";
            }
            
            float TeplotaUm = Teplota > trackBarUmTeplota.Value ? trackBarUmTeplota.Value : Teplota;
            float TeplotaSp = Teplota > trackBarSpTeplota.Value ? trackBarSpTeplota.Value : Teplota;
            float OdberUm = KolikUbydeVody(TeplotaUm, trackBarUmPrutok.Value);
            float OdberSp = KolikUbydeVody(TeplotaSp, trackBarSpPrutok.Value);
            float OdberCelkem = OdberUm + OdberSp;
            float Zbytek = Objem - OdberCelkem;
            Teplota = (OdberCelkem * 10 + Zbytek * Teplota) / (OdberCelkem + Zbytek);
            
            if (Ohrev)
            {
                Teplota += OhratiZaSekundu;
                SpotrebakW += 4000f * 0.001f;
            }
            if (Teplota <= 10)
            {
                Teplota = 10;
            }
            Cas++;
        }

        private float KolikUbydeVody(float teplotaKterouVyzadujem, float odber)
        {
            if (Teplota == teplotaKterouVyzadujem)
            {
                return odber;
            }
            else
            {
                float x = (Teplota - teplotaKterouVyzadujem) / (teplotaKterouVyzadujem - 10);
                float m2 = odber / (x + 1);
                return m2;
            }
        }

        private void buttonAuto_Click(object sender, EventArgs e)
        {
            Automat = !Automat;
            buttonAuto.Text = Automat ? "Auto" : "Manual";
            buttonOhrev.Enabled = !Automat;
        }

        private void trackBarCas_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = 1000 / trackBarCas.Value;
            labelTrackCas.Text = trackBarCas.Value.ToString();
        }

        private void trackBarUmPrutok_Scroll(object sender, EventArgs e)
        {
            labelUmPrutok.Text = trackBarUmPrutok.Value.ToString();
        }

        private void trackBarUmTeplota_Scroll(object sender, EventArgs e)
        {
            labelUmTeplota.Text = trackBarUmTeplota.Value.ToString();
        }

        private void trackBarSpPrutok_Scroll(object sender, EventArgs e)
        {
            labelSpPrutok.Text = trackBarSpPrutok.Value.ToString();
        }

        private void trackBarSpTeplota_Scroll(object sender, EventArgs e)
        {
            labelSpTeplota.Text = trackBarSpTeplota.Value.ToString();
        }
    }
}