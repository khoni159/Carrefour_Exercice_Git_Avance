namespace Carrefour_Exercice_Git_Avance
{
    public partial class Form1 : Form
    {
        public string Couleur = "Rouge";
        public int AnneeConstruction = 2024;
        public int Vitesse = 0;
        public int litreEssence = 40;
        public Form1()
        {
            InitializeComponent();
        }

        public void Accelerer()
        {
            if (litreEssence > 0)
            {
                Vitesse += 1;
                litreEssence -= 1;
            }
        }

        public void Freiner()
        {
            if (Vitesse < 0)
            {
                Vitesse -= 2;
            } 
        }

        public void Reculer()
        {
            if (Vitesse <= 0 && litreEssence > 0)
            {
                Vitesse -= 1;
                litreEssence -= 1;
            }
        }

        public void RemplirEssence(int litre)
        {
            litreEssence += litre;
            litreEssence = Math.Min(40, litreEssence);
        }

        private void button_afficherVitesse_Click(object sender, EventArgs e)
        {
            MessageBox.Show( Vitesse.ToString() + "Km/h ");
        }

        private void button_freiner_Click(object sender, EventArgs e)
        {
            Freiner();
        }

        private void button_accelerer_Click(object sender, EventArgs e)
        {
            Accelerer();
        }

        private void button_reculer_Click(object sender, EventArgs e)
        {
            Reculer();
        }
    }
}
