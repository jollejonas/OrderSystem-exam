using OrderSystem.Controllers;
using OrderSystem.Models;
using OrderSystem.Services;

namespace OrderSystem.Views
{
    public partial class CreateView : Form, IView
    {
        private readonly OrderController _orderController;
        private User _loggedInUser;
        private Navigator _navigator;
        public CreateView(OrderController orderController)
        {
            _orderController = orderController;
            InitializeComponent();
        }

        public void SetNavigator(Navigator navigator)
        {
            _navigator = navigator;
        }
        public void SetLoggedInUser(User user)
        {
            _loggedInUser = user;
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            var orderName = nameTextbox.Text;
            var orderDescription = descriptionTextbox.Text;
            var createdBy = _loggedInUser;

            if (string.IsNullOrWhiteSpace(orderName) || string.IsNullOrWhiteSpace(orderDescription))
            {
                MessageBox.Show("Udfyld alle felter");
                return;
            }

            try
            {
                _orderController.CreateOrder(orderName, orderDescription, _loggedInUser.Id);
                MessageBox.Show("Orden blev oprettet");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Der opstod en fejl: {ex.Message}");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            nameTextbox.Text = "";
            descriptionTextbox.Text = "";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            _navigator?.ShowMenuView();
        }
    }
}
