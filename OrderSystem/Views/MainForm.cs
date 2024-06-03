using OrderSystem.Services;
using OrderSystem.Models;

namespace OrderSystem.Views
{
    public partial class MainForm : Form
    {

        private readonly Navigator _navigator;
        private User _loggedInUser;

        public MainForm(Navigator navigator)
        {
            _navigator = navigator;
            InitializeComponent();
            _navigator.Initialize(this); // Ensure Navigator is initialized here
            _navigator.ShowMenuView(); // Directly use the navigator to initialize MenuView
        }

        public void ShowView(Form view)
        {
            panelMain.Controls.Clear();
            view.TopLevel = false;
            view.FormBorderStyle = FormBorderStyle.None;
            view.Dock = DockStyle.Fill;
            panelMain.Controls.Add(view);
            view.Show();
        }

        public void SetLoggedInUser(User user)
        {
            _loggedInUser = user;
            _navigator.SetLoggedInUser(user);
        }
    }
}
