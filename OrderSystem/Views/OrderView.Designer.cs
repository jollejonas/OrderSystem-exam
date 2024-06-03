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
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(12, 95);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.Size = new Size(972, 436);
            dataGridViewOrders.TabIndex = 0;
            // 
            // backButton
            // 
            backButton.Location = new Point(476, 537);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 1;
            backButton.Text = "Tilbage";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // OrderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 572);
            Controls.Add(backButton);
            Controls.Add(dataGridViewOrders);
            Name = "OrderView";
            Text = "OrderView";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewOrders;
        private Button backButton;
    }
}