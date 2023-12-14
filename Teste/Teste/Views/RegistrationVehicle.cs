using Teste.Service;

namespace ShoppingCar.Views
{
    public partial class RegistrationVehicle : Form
    {
        private readonly VehicleService vehicleService = new();
        DeleteCar deleteCar = new();
        Update updateCar = new();

        public RegistrationVehicle()
        {
            InitializeComponent();
        }

        private async void RegistrationVehicle_Load(object sender, EventArgs e)
        {
            ListCardataGridView.Rows.Clear();
            await ListCar();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            updateCar.ShowDialog();
        }

        private async void RefreshCarbutton_Click(object sender, EventArgs e)
        {
            ListCardataGridView.Rows.Clear();
            await ListCar();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            deleteCar.ShowDialog();
        }

        private void ListCardataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ListCardataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ListCardataGridView.SelectedRows[0];

                string id = selectedRow.Cells["Id"].Value.ToString();
                string licensePlate = selectedRow.Cells["LicensePlate"].Value.ToString();
                string chassis = selectedRow.Cells["Chassis"].Value.ToString();
                string brand = selectedRow.Cells["Brand"].Value.ToString();
                string model = selectedRow.Cells["Model"].Value.ToString();
                string manufacturingYear = selectedRow.Cells["ManufacturingYear"].Value.ToString();
                string modelYear = selectedRow.Cells["ModelYear"].Value.ToString();
                string fipeValue = selectedRow.Cells["FipeValue"].Value.ToString();
                string sellingPrice = selectedRow.Cells["SellingPrice"].Value.ToString();
                string notes = selectedRow.Cells["Notes"].Value.ToString();

                #region Update
                updateCar.IdLabel.Text = id;
                updateCar.LicensePlateTextBox.Text = licensePlate;
                updateCar.ChassisTextBox.Text = chassis;
                updateCar.BrandTextBox.Text = brand;
                updateCar.ModelTextBox.Text = model;
                updateCar.ManufacturingYearTextBox.Text = manufacturingYear;
                updateCar.ModelYearTextBox.Text = modelYear;
                updateCar.FipeValueTextBox.Text = fipeValue;
                updateCar.SellingPriceTextBox.Text = sellingPrice;
                updateCar.NotesTextBox.Text = notes;
                #endregion

                #region Deltar
                deleteCar.IdLabel.Text = id;
                deleteCar.LicensePlateTextBox.Text = licensePlate;
                deleteCar.ChassisTextBox.Text = chassis;
                deleteCar.BrandTextBox.Text = brand;
                deleteCar.ModelTextBox.Text = model;
                deleteCar.ManufacturingYearTextBox.Text = manufacturingYear;
                deleteCar.ModelYearTextBox.Text = modelYear;
                deleteCar.FipeValueTextBox.Text = fipeValue;
                deleteCar.SellingPriceTextBox.Text = sellingPrice;
                deleteCar.NotesTextBox.Text = notes;
                #endregion

            }
        }

        public async Task ListCar()
        {
            var list = await vehicleService.GetAllVehicle();

            foreach (var item in list)
            {
                ListCardataGridView.Rows.Add(item.Id, item.LicensePlate, item.Chassis, item.Brand, item.Model,
                                            item.ManufacturingYear, item.ModelYear, item.FipeValue,
                                            item.SellingPrice, item.Notes);
            }
        }
    }
}
