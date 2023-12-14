namespace ShoppingCar.Views
{
    public partial class PageInicial : Form
    {
        private readonly RegistrationVehicle vehicleRegistration;
        private readonly Car carForm;
        private Panel panelPage;

        public PageInicial()
        {
            InitializeComponent();
            carForm = new();
            vehicleRegistration = new();
            InitializePanel();
        }

        private void InitializePanel()
        {
            panelPage = new Panel
            {
                Dock = DockStyle.Fill, 
                AutoScroll = true 
            };

            Controls.Add(panelPage);

            carForm.TopLevel = false;
            carForm.FormBorderStyle = FormBorderStyle.None;
            carForm.Dock = DockStyle.Fill;
            panelPage.Controls.Add(carForm);

            vehicleRegistration.TopLevel = false;
            vehicleRegistration.FormBorderStyle = FormBorderStyle.None;
            vehicleRegistration.Dock = DockStyle.Fill;
            panelPage.Controls.Add(vehicleRegistration);

            carForm.Show();
        }

        private void PaginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carForm.Hide();
            vehicleRegistration.Hide();
        }

        private void VeiculosCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vehicleRegistration.BringToFront();
            vehicleRegistration.Show();
        }

        private void ListaDeVeiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carForm.Show();
            carForm.BringToFront();
        }
    }
}
