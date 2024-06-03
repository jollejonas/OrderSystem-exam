using OrderSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystem.Views
{
    public partial class MenuView : Form, IView
    {
        private Navigator _navigator;
        public MenuView()
        {
            InitializeComponent();
        }

        public void SetNavigator(Navigator navigator)
        {
            _navigator = navigator;
        }

        private void showOrders_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Showing orders");
            _navigator?.ShowOrderView();
        }

        private void createOrder_Click(object sender, EventArgs e)
        {
            _navigator?.ShowCreateView();
        }
    }
}
