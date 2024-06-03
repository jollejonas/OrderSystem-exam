using OrderSystem.Controllers;
using OrderSystem.Views;
using OrderSystem.Models;

namespace OrderSystem
{
    public partial class StartView : Form
    {
        private readonly UserController _userController;
        private readonly MainForm _mainForm;
        private User _loggedInUser;


        public StartView(UserController userController, MainForm mainForm)
        {
            _userController = userController;
            _mainForm = mainForm;
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameText.Text;
            string password = passwordText.Text;

            var user = _userController.ValidateUser(username, password);

            if(user != null)
            {
                _loggedInUser = user;
                this.Hide();
                _mainForm.SetLoggedInUser(_loggedInUser);
                _mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
