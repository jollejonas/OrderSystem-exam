using OrderSystem.Controllers;
using OrderSystem.Services;

namespace OrderSystem.Views
{
    public partial class OrderView : Form
    {
        private readonly OrderController _orderController;
        private Navigator _navigator;

        public OrderView(OrderController orderController)
        {
            _orderController = orderController;
            InitializeComponent();
            LoadOrders();
        }
        public void SetNavigator(Navigator navigator)
        {
            _navigator = navigator;
        }

        private void LoadOrders()
        {
            var orders = _orderController.GetAllOrders();
            dataGridViewOrders.DataSource = orders;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            _navigator?.ShowMenuView();
        }
    }
}
