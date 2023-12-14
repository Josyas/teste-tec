using Teste.Models;
using Teste.Service;

namespace ShoppingCar.Views
{
    public partial class Update : Form
    {
        private readonly VehicleService vehicleService = new();

        public Update()
        {
            InitializeComponent();
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
           await UpdateCar();
        }

        public async Task UpdateCar()
        {
            try
            {
                var required = Validation();

                if (!required)
                {
                    Vehicle vehicle = new()
                    {
                        Id = int.Parse(IdLabel.Text),
                        LicensePlate = LicensePlateTextBox.Text,
                        Chassis = ChassisTextBox.Text,
                        Brand = BrandTextBox.Text,
                        Model = ModelTextBox.Text,
                        ManufacturingYear = ManufacturingYearTextBox.Text,
                        ModelYear = ModelYearTextBox.Text,
                        FipeValue = double.Parse(FipeValueTextBox.Text),
                        SellingPrice = double.Parse(SellingPriceTextBox.Text),
                        Notes = NotesTextBox.Text,
                    };

                    await vehicleService.UpdateVehicle(vehicle);

                    MessageBox.Show("atualizado com sucesso.");
                    ClearForms();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Todos os campos são obrigatórios. Por favor, preencha todos os campos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool Validation()
        {
            if (string.IsNullOrWhiteSpace(LicensePlateTextBox.Text) ||
                string.IsNullOrWhiteSpace(ChassisTextBox.Text) ||
                string.IsNullOrWhiteSpace(BrandTextBox.Text) ||
                string.IsNullOrWhiteSpace(ModelTextBox.Text) ||
                string.IsNullOrWhiteSpace(ManufacturingYearTextBox.Text) ||
                string.IsNullOrWhiteSpace(ModelYearTextBox.Text) ||
                string.IsNullOrWhiteSpace(FipeValueTextBox.Text) ||
                string.IsNullOrWhiteSpace(SellingPriceTextBox.Text) ||
                string.IsNullOrEmpty(FipeValueTextBox.Text) ||
                string.IsNullOrEmpty(SellingPriceTextBox.Text))
            {
                return true;
            }

            return false;
        }

        private void ClearForms()
        {
            LicensePlateTextBox.Text = "";
            ChassisTextBox.Text = "";
            BrandTextBox.Text = "";
            ModelTextBox.Text = "";
            ManufacturingYearTextBox.Text = "";
            ModelYearTextBox.Text = "";
            FipeValueTextBox.Text = "";
            SellingPriceTextBox.Text = "";
            NotesTextBox.Text = "";
        }
    }
}
