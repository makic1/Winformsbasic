using WineCardAppVersionFour.Entities;
using WineCardAppVersionFour.Service;

namespace WineCardAppVersionFour.Uc
{
    public partial class UcLogin : UserControl
    {
        private readonly ServiceAccount _serviceAccount;
        private readonly FormMain _formMain;

        public UcLogin(FormMain formMain)
        {
            InitializeComponent();

            var context = new DbContextWineCardApp();
            _serviceAccount = new ServiceAccount(context);
            _formMain = formMain;

            textBoxPassword.PasswordChar = '*';

            // Todo: am schluss löschen
            textBoxPassword.Text = "admin";
            textBoxUsername.Text = "admin";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var loginModel = new LoginModel
            {
                Username = textBoxUsername.Text,
                Password = textBoxPassword.Text,
            };

            var account = _serviceAccount.FindAccount(loginModel.Username);

            if (loginModel is not null && BCrypt.Net.BCrypt.Verify(loginModel.Password, account.HashPassword))
            {
                AuthService.Instance.Login(loginModel.Username);
                _formMain.OnLoginStatus(true);
               
            }
            else
            {
                MessageBox.Show("Benutzername oder Passwort falsch");
            }
        }
    }
}
