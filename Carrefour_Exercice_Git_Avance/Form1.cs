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
    }
}
