using Teste.Models;
using Teste.Service;

namespace ShoppingCar.Views
{
    public partial class Car : Form
    {
        private readonly CarService carService = new();

        InsertCar insertCar = new();

        public Car()
        {
            InitializeComponent();
        }

        private async void Car_Load(object sender, EventArgs e)
        {
            await ListCar();
        }

        private async void SearchMarcacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = SearchMarcacomboBox.SelectedIndex;

            if (selectedIndex >= 0)
            {
                string selectedValue = SearchMarcacomboBox.Items[selectedIndex].ToString();
                var listCarBrands = await carService.GetCarBrands();
                insertCar.BrandTextBox.Text = selectedValue;

                foreach (var item in listCarBrands)
                {
                    if (selectedValue == item.nome)
                        await ListModelYear(item.codigo.ToString());
                }
            }

            await ListCar();
        }

        private void ListCardataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ListCardataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ListCardataGridView.SelectedRows[0];

                string modelo = selectedRow.Cells["Modelo"].Value.ToString();
                string ano = selectedRow.Cells["Ano"].Value.ToString();
                insertCar.ModelTextBox.Text = modelo;
                insertCar.ModelYearTextBox.Text = ano;
            }
        }

        private void CreateCarButton_Click(object sender, EventArgs e)
        {
            insertCar.ShowDialog();
        }

        public async Task ListCar()
        {
            var listCarBrands = await carService.GetCarBrands();

            foreach (var brand in listCarBrands)
            {
                SearchMarcacomboBox.Items.Add(brand.nome);
            }
        }

        public async Task ListModelYear(string idModel)
        {
            var listModels = await carService.GetCarCodigo(idModel);
            var modelCar = ListModelCar(listModels);

            ListCardataGridView.Rows.Clear();

            foreach (var model in modelCar)
            {
                ListCardataGridView.Rows.Add(model.Modelo, model.Ano);
            }
        }

        public List<CarDTO> ListModelCar(ResponseCarBrand listModels)
        {
            List<CarDTO> modelCar = new();

            for (int i = 0; i < Math.Max(listModels.modelos.Count, listModels.anos.Count); i++)
            {
                CarDTO carDTO = new();

                if (i < listModels.modelos.Count)
                    carDTO.Modelo = listModels.modelos[i].nome;

                if (i < listModels.anos.Count && !string.IsNullOrEmpty(listModels.anos[i].nome))
                    carDTO.Ano = listModels.anos[i].nome;

                modelCar.Add(carDTO);
            }

            return modelCar;
        }
    }
}
