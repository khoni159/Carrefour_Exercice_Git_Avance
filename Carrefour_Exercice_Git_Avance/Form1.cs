namespace Carrefour_Exercice_Git_Avance
{
    public partial class Form1 : Form
    {
        public string Couleur;
        public int AnneeConstruction;
        public int Vitesse = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void Accelerer()
        {
            Vitesse += 2;
        }

        public void Freiner()
        {
            Vitesse -= 1;
        }

        private void button_afficherVitesse_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Vitesse.ToString());
        }

        private void button_freiner_Click(object sender, EventArgs e)
        {
            Freiner();
        }

        private void button_accelerer_Click(object sender, EventArgs e)
        {
            Accelerer();
        }
    }
}
