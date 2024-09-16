using WineCardAppVersionFour.Service;
using WineCardAppVersionFour.Uc;

namespace WineCardAppVersionFour
{
    public partial class FormMain : Form
    {
        private UserControl _ucLogin;
        public FormMain()
        {
            InitializeComponent();

            if (_ucLogin is null)
            {
                _ucLogin = new UcLogin(this);
            }
            panelMain.Controls.Add(_ucLogin);
        }

        public void OnLoginStatus(bool loginLogout)
        {
            if (loginLogout is true)
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(new UcManageUserControls());
            }
        }
    }
}
