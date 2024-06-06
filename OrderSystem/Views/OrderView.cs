using OrderSystem.Controllers;
using OrderSystem.Services;
using OrderSystem.Models;
using System.Text;

namespace OrderSystem.Views
{
    public partial class OrderView : Form
    {
        private readonly OrderController _orderController;
        private readonly MachineController _machineController;
        private Navigator _navigator;
        private List<Order> _orders;
        private User _loggedInUser;

        public OrderView(OrderController orderController, MachineController machineController)
        {
            _orderController = orderController;
            _machineController = machineController;
            InitializeComponent();
            InitializeSortComboBox();
            LoadMachines();
            LoadStatuses();
        }
        public void SetNavigator(Navigator navigator)
        {
            _navigator = navigator;
        }
        public void SetLoggedInUser(User user)
        {
            _loggedInUser = user;
        }

        private void InitializeSortComboBox()
        {
            LoadOrders();
            sortComboBox.Items.AddRange(new object[] {
                "Nyeste",
                "Ældste"
            });
            sortComboBox.SelectedIndex = 0; // Set default selection to avoid null value
        }

        private void LoadOrders()
        {
            _orders = _orderController.GetAllOrders();
            UpdateOrderDataGridView();
        }

        private void LoadMachines()
        {
            var machines = _machineController.GetAllMachines();
            machineComboBox.DataSource = machines;
            machineComboBox.DisplayMember = "Name";
            machineComboBox.ValueMember = "Id";
        }

        private void LoadStatuses()
        {
            statusComboBox.Items.AddRange(new object[] {
                "Ny",
                "Planlagt",
                "Igangværende"
            });
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            _navigator?.ShowMenuView();
        }

        private void UpdateOrderDataGridView()
        {
            if (_orders == null || !_orders.Any())
            {
                MessageBox.Show("Ingen ordrer.");
                return;
            }

            dataGridViewOrders.DataSource = null;
            dataGridViewOrders.DataSource = _orders.Select(o => new
            {
                o.Id,
                Navn = o.Name,
                Beskrivelse = o.Description,
                OprrettetDato = o.CreatedAt == default(DateTime) ? "" : o.CreatedAt.ToString("yyyy-MM-dd"),
                StartDato = o.StartDate == default(DateTime) ? "" : o.StartDate?.ToString("yyyy-MM-dd"),
                AfslutningsDato = o.EndDate == default(DateTime) ? "" : o.EndDate?.ToString("yyyy-MM-dd"),
                o.Status,
                Maskine = o.MachineObject != null ? o.MachineObject.Name : "Ikke valgt",
                OprettetAf = o.CreatedByUser != null ? o.CreatedByUser.Name : "",
                AfsluttetAf = o.EndedByUser != null ? o.EndedByUser.Name : "",
                SidstOpdateretAf = o.LastEditByUser != null ? o.LastEditByUser.Name : ""
            }).ToList();
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_orders == null || !_orders.Any())
            {
                return;
            }
            if (sortComboBox.SelectedItem == null)
            {
                return;
            }
            switch (sortComboBox.SelectedItem.ToString())
            {
                case "Nyeste":
                    _orders = _orders.OrderByDescending(o => o.CreatedAt).ToList();
                    break;
                case "Ældste":
                    _orders = _orders.OrderBy(o => o.CreatedAt).ToList();
                    break;
                default:
                    break;
            }
            UpdateOrderDataGridView();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string serachText = searchTextBox.Text.ToLower();

            var filteredOrders = _orders.Where(o =>
                o.Id.ToString().Contains(serachText) ||
                o.Name.ToLower().Contains(serachText) ||
                o.Description.ToLower().Contains(serachText) ||
                o.Status.ToLower().Contains(serachText) ||
                (o.MachineObject != null && o.MachineObject.Name.ToLower().Contains(serachText)) ||
                (o.CreatedByUser != null && o.CreatedByUser.Name.ToLower().Contains(serachText)) ||
                (o.EndedByUser != null && o.EndedByUser.Name.ToLower().Contains(serachText)) ||
                (o.LastEditByUser != null && o.LastEditByUser.Name.ToLower().Contains(serachText))
            ).ToList();



            dataGridViewOrders.DataSource = filteredOrders.Select(o => new
            {
                o.Id,
                o.Name,
                o.Description,
                CreatedAt = o.CreatedAt == default(DateTime) ? "" : o.CreatedAt.ToString("yyyy-MM-dd"),
                StartDate = o.StartDate == default(DateTime) ? "" : o.StartDate?.ToString("yyyy-MM-dd"),
                EndDate = o.EndDate == default(DateTime) ? "" : o.EndDate?.ToString("yyyy-MM-dd"),
                o.Status,
                Machine = o.MachineObject != null ? o.MachineObject.Name : "Ikke valgt",
                CreatedBy = o.CreatedByUser != null ? o.CreatedByUser.Name : "",
                EndedBy = o.EndedByUser != null ? o.EndedByUser.Name : "",
                LastEditBy = o.LastEditByUser != null ? o.LastEditByUser.Name : ""
            }).ToList();
        }

        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewOrders.SelectedRows[0];
                if (selectedRow != null)
                {
                    var selectedOrder = _orders.FirstOrDefault(o => o.Id == (int)selectedRow.Cells["Id"].Value);
                    if (selectedOrder != null)
                    {
                        orderIdLable.Text = selectedOrder.Id.ToString();
                        nameTextBox.Text = selectedOrder.Name;
                        descriptionTextBox.Text = selectedOrder.Description;
                        startDatePicker.Value = selectedOrder.StartDate ?? DateTime.Now;
                        statusComboBox.SelectedItem = selectedOrder.Status;
                        machineComboBox.SelectedValue = selectedOrder.Machine ?? 0;
                    }
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var orderId = Int32.Parse(orderIdLable.Text);
            var orderName = nameTextBox.Text;
            var orderDescription = descriptionTextBox.Text;
            var orderStatus = statusComboBox.SelectedItem?.ToString();
            var orderStartDate = startDatePicker.Value;
            var orderMachineId = (int)machineComboBox.SelectedValue;
            var lastEditedBy = _loggedInUser;

            if ((string.IsNullOrWhiteSpace(orderName) || string.IsNullOrWhiteSpace(orderDescription) ||
                string.IsNullOrWhiteSpace(orderStatus) || orderStartDate == default(DateTime) || orderMachineId < 0))
            {
                MessageBox.Show("Udfyld alle felter");
                return;
            }

            try
            {
                _orderController.UpdateOrder(orderId, orderName, _loggedInUser.Id, orderDescription, orderStatus, orderStartDate, orderMachineId);
                MessageBox.Show("Orden blev opdateret");
                UpdateOrderDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Der opstod en fejl: {ex.Message}");
            }
        }

        private void ExportToCsv(string filePath)
        {
            var sb = new StringBuilder();

            var headers = dataGridViewOrders.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow row in dataGridViewOrders.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value?.ToString().Replace("\"", "\"\"") + "\"")));

            }

            File.WriteAllText(filePath, sb.ToString());
        }

        private void printOrders_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToCsv(saveFileDialog.FileName);
            }
        }

        private void startOrder_Click(object sender, EventArgs e)
        {
            var orderId = Int32.Parse(orderIdLable.Text);
            var status = "Igangværende";

            _orderController.UpdateOrder(orderId, status, _loggedInUser.Id);
            UpdateOrderDataGridView();
        }

        private void endOrder_Click(object sender, EventArgs e)
        {
            var orderId = Int32.Parse(orderIdLable.Text);
            var status = "Afsluttet";
            var endDate = DateTime.Now;
            var endedBy = _loggedInUser.Id;

            _orderController.UpdateOrder(orderId, status, endedBy, _loggedInUser.Id);
            UpdateOrderDataGridView();
        }

    }
}
