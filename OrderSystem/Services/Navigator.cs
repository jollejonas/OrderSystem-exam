using OrderSystem.Views;
using OrderSystem.Models;
using Microsoft.Extensions.DependencyInjection;

namespace OrderSystem.Services
{
    public class Navigator
    {
        private User _loggedInUser;
        private MainForm _mainForm;
        private readonly IServiceProvider _serviceProvider;
        public Navigator(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Initialize(MainForm mainForm)
        {
            _mainForm = mainForm;
        }

        public void SetLoggedInUser(User user)
        {
            _loggedInUser = user;
        }

        public void ShowView(Form view)
        {
            if (_mainForm == null)
            {
                throw new InvalidOperationException("MainForm is not initialized");
            }
            _mainForm.ShowView(view);
        }

        public void ShowOrderView()
        {
            var orderView = _serviceProvider.GetRequiredService<OrderView>();
            orderView.SetNavigator(this);
            ShowView(orderView);
        }

        public void ShowCreateView()
        {
            var createView = _serviceProvider.GetRequiredService<CreateView>();
            createView.SetNavigator(this);
            createView.SetLoggedInUser(_loggedInUser);
            ShowView(createView);
        }
        public void ShowMenuView()
        {
            var menuView = _serviceProvider.GetRequiredService<MenuView>();
            menuView.SetNavigator(this);
            ShowView(menuView);
        }
    }
}
