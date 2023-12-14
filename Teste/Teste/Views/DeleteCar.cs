using Teste.Models;
using Teste.Service;

namespace ShoppingCar.Views
{
    public partial class DeleteCar : Form
    {
        private readonly VehicleService vehicleService = new();

        public DeleteCar()
        {
            InitializeComponent();
        }

        private void DeleteCar_Load(object sender, EventArgs e)
        {
            ReadOnlyLabel();
        }

        private async void DeletarButton_Click(object sender, EventArgs e)
        {
            await UpdateCar();
        }

        public async Task UpdateCar()
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja realmente excluir o item?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
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

                    await vehicleService.DeleteVehicle(vehicle);
                    ClearForms();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ReadOnlyLabel()
        {
            LicensePlateTextBox.ReadOnly = true;
            ChassisTextBox.ReadOnly = true;
            BrandTextBox.ReadOnly = true;
            ModelTextBox.ReadOnly = true;
            ManufacturingYearTextBox.ReadOnly = true;
            ModelYearTextBox.ReadOnly = true;
            FipeValueTextBox.ReadOnly = true;
            SellingPriceTextBox.ReadOnly = true;
            NotesTextBox.ReadOnly = true;
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
