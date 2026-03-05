namespace arrayunidirecional_vetor
{
    public partial class frmVetor : Form
    {
        public frmVetor()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            //matriz de uma dimensão, também chamada de vetor
            string[] pecasComputador = { "Mouse", "Teclado", "Monitor", "Gabinete", "Câmera" };

            //MessageBox.Show(pecasComputador[2]);

            foreach (string peca in pecasComputador)
            {
                MessageBox.Show(peca);
            }
        }
    }
}
