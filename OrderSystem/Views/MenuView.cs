using OrderSystem.Services;
using OrderSystem.Models;
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
        private User _loggedInUser;
        public MenuView()
        {
            InitializeComponent();
        }

        public void SetNavigator(Navigator navigator)
        {
            _navigator = navigator;
        }

        public void SetLoggedInUser(User user)
        {
            _loggedInUser = user;
            _navigator.SetLoggedInUser(user);
        }

        private void showOrders_Click(object sender, EventArgs e)
        {
            if(!_loggedInUser.CanHandleOrders())
            {
                MessageBox.Show("Du har ikke adgang til at se ordrer");
            }
            else
            {
                _navigator?.ShowOrderView();
            }
        }

        private void createOrder_Click(object sender, EventArgs e)
        {
            if (!_loggedInUser.CanCreateOrders())
            {
                MessageBox.Show("Du har ikke adgang til at oprette ordrer");
            }
            else
            {
                _navigator?.ShowCreateView();
            }
        }
    }
}
