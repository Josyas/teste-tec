using Teste.Models;

namespace ShoppingCar.Views
{
    public partial class Login : Form
    {
        public Login() => InitializeComponent();

        private readonly LoginService _loginService = new();

        private void Login_Load(object sender, EventArgs e){}

        private async void AcessButton_Click(object sender, EventArgs e)
        {
            try
            {
                object response = null;
                var user = userTextBox.Text;
                var password = passwordTextBox.Text;

                if (!String.IsNullOrWhiteSpace(user) && !String.IsNullOrWhiteSpace(password))
                {
                    ResquestLogin resquestLogin = new()
                    {
                        User = user,
                        Password = password
                    }; 

                    response = await _loginService.AccessLogin(resquestLogin);
                }

                if(Convert.ToBoolean(response) == true)
                {
                    this.Hide();
                    PageInicial telaInicial = new();
                    telaInicial.ShowDialog();
                }
                else
                {
                    MessageBox.Show("usuário ou senha inválida.");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
