namespace _0808_3B
{
    public partial class ImprimirSaldo : Form
    {
        public string nombreUsuario;
        public double saldo;
        public string dui;
        public ImprimirSaldo(string nombreUsuario, double saldo, string dui)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            this.saldo = saldo;

            //  impirmir saldo disponible 
            string saldoText = saldo.ToString("C2");
            txtSaldo.Text = saldoText;
            this.dui = dui;
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // regresar a index 
            this.Hide();
            Index index = new Index(nombreUsuario, saldo, dui);
            index.ShowDialog();
            Application.Exit();
        }

        private void button_transferencias_Click(object sender, EventArgs e)
        {
            // ir a pagina de transferencias
            this.Hide();
            var historial = new Historial(nombreUsuario, saldo, dui);
            historial.ShowDialog();
            Application.Exit();
        }
    }
}
