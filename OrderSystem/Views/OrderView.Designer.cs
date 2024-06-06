namespace OrderSystem.Views
{
    partial class OrderView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewOrders = new DataGridView();
            backButton = new Button();
            sortComboBox = new ComboBox();
            searchTextBox = new TextBox();
            searchText = new Label();
            filterLabel = new Label();
            statusLabel = new Label();
            machineLabel = new Label();
            startDateLabel = new Label();
            descriptionLabel = new Label();
            nameLabel = new Label();
            saveButton = new Button();
            printOrders = new Button();
            machineComboBox = new ComboBox();
            statusComboBox = new ComboBox();
            nameTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            startDatePicker = new DateTimePicker();
            orderIdLable = new Label();
            endOrder = new Button();
            startOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(12, 258);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.Size = new Size(972, 273);
            dataGridViewOrders.TabIndex = 0;
            dataGridViewOrders.SelectionChanged += dataGridViewOrders_SelectionChanged;
            // 
            // backButton
            // 
            backButton.Location = new Point(298, 537);
            backButton.Name = "backButton";
            backButton.Size = new Size(137, 31);
            backButton.TabIndex = 1;
            backButton.Text = "Tilbage";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // sortComboBox
            // 
            sortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sortComboBox.FormattingEnabled = true;
            sortComboBox.Location = new Point(798, 229);
            sortComboBox.Name = "sortComboBox";
            sortComboBox.Size = new Size(186, 23);
            sortComboBox.TabIndex = 2;
            sortComboBox.SelectedIndexChanged += sortComboBox_SelectedIndexChanged;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(48, 229);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(295, 23);
            searchTextBox.TabIndex = 3;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // searchText
            // 
            searchText.AutoSize = true;
            searchText.Location = new Point(12, 232);
            searchText.Name = "searchText";
            searchText.Size = new Size(30, 15);
            searchText.TabIndex = 4;
            searchText.Text = "Søg:";
            // 
            // filterLabel
            // 
            filterLabel.AutoSize = true;
            filterLabel.Location = new Point(756, 232);
            filterLabel.Name = "filterLabel";
            filterLabel.Size = new Size(36, 15);
            filterLabel.TabIndex = 5;
            filterLabel.Text = "Filter:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(48, 162);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(42, 15);
            statusLabel.TabIndex = 23;
            statusLabel.Text = "Status:";
            // 
            // machineLabel
            // 
            machineLabel.AutoSize = true;
            machineLabel.Location = new Point(48, 133);
            machineLabel.Name = "machineLabel";
            machineLabel.Size = new Size(54, 15);
            machineLabel.TabIndex = 22;
            machineLabel.Text = "Maskine:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new Point(48, 107);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(61, 15);
            startDateLabel.TabIndex = 16;
            startDateLabel.Text = "Start dato:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(341, 75);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(67, 15);
            descriptionLabel.TabIndex = 13;
            descriptionLabel.Text = "Beskrivelse:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(48, 75);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(38, 15);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Navn:";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(12, 537);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(137, 31);
            saveButton.TabIndex = 24;
            saveButton.Text = "Gem ændringer";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // printOrders
            // 
            printOrders.Location = new Point(155, 537);
            printOrders.Name = "printOrders";
            printOrders.Size = new Size(137, 31);
            printOrders.TabIndex = 26;
            printOrders.Text = "Opret CSV";
            printOrders.UseVisualStyleBackColor = true;
            printOrders.Click += printOrders_Click;
            // 
            // machineComboBox
            // 
            machineComboBox.FormattingEnabled = true;
            machineComboBox.Location = new Point(134, 130);
            machineComboBox.Name = "machineComboBox";
            machineComboBox.Size = new Size(138, 23);
            machineComboBox.TabIndex = 27;
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(134, 159);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(138, 23);
            statusComboBox.TabIndex = 28;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(134, 72);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(138, 23);
            nameTextBox.TabIndex = 29;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(414, 72);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(323, 110);
            descriptionTextBox.TabIndex = 32;
            // 
            // startDatePicker
            // 
            startDatePicker.Location = new Point(134, 101);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(138, 23);
            startDatePicker.TabIndex = 33;
            // 
            // orderIdLable
            // 
            orderIdLable.AutoSize = true;
            orderIdLable.Location = new Point(48, 41);
            orderIdLable.Name = "orderIdLable";
            orderIdLable.Size = new Size(13, 15);
            orderIdLable.TabIndex = 34;
            orderIdLable.Text = "0";
            // 
            // endOrder
            // 
            endOrder.Location = new Point(847, 537);
            endOrder.Name = "endOrder";
            endOrder.Size = new Size(137, 31);
            endOrder.TabIndex = 35;
            endOrder.Text = "Afslut Ordre";
            endOrder.UseVisualStyleBackColor = true;
            endOrder.Click += endOrder_Click;
            // 
            // startOrder
            // 
            startOrder.Location = new Point(704, 537);
            startOrder.Name = "startOrder";
            startOrder.Size = new Size(137, 31);
            startOrder.TabIndex = 36;
            startOrder.Text = "Start Ordre";
            startOrder.UseVisualStyleBackColor = true;
            startOrder.Click += startOrder_Click;
            // 
            // OrderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 572);
            Controls.Add(startOrder);
            Controls.Add(endOrder);
            Controls.Add(orderIdLable);
            Controls.Add(startDatePicker);
            Controls.Add(descriptionTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(statusComboBox);
            Controls.Add(machineComboBox);
            Controls.Add(printOrders);
            Controls.Add(saveButton);
            Controls.Add(statusLabel);
            Controls.Add(machineLabel);
            Controls.Add(startDateLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(nameLabel);
            Controls.Add(filterLabel);
            Controls.Add(searchText);
            Controls.Add(searchTextBox);
            Controls.Add(sortComboBox);
            Controls.Add(backButton);
            Controls.Add(dataGridViewOrders);
            Name = "OrderView";
            Text = "OrderView";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewOrders;
        private Button backButton;
        private ComboBox sortComboBox;
        private TextBox searchTextBox;
        private Label searchText;
        private Label filterLabel;
        private Label statusLabel;
        private Label machineLabel;
        private Label startDateLabel;
        private Label createdByLabel;
        private Label descriptionLabel;
        private Label nameLabel;
        private Button saveButton;
        private Button button2;
        private Button printOrders;
        private ComboBox machineComboBox;
        private ComboBox statusComboBox;
        private TextBox nameTextBox;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox descriptionTextBox;
        private DateTimePicker startDatePicker;
        private Label orderIdLable;
        private Button endOrder;
        private Button startOrder;
    }
}