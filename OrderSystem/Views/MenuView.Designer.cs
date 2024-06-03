namespace OrderSystem.Views
{
    partial class MenuView
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
            showOrders = new Button();
            createOrder = new Button();
            planOrder = new Button();
            startOrder = new Button();
            SuspendLayout();
            // 
            // showOrders
            // 
            showOrders.Location = new Point(286, 158);
            showOrders.Name = "showOrders";
            showOrders.Size = new Size(108, 60);
            showOrders.TabIndex = 0;
            showOrders.Text = "Vis Ordrer";
            showOrders.UseVisualStyleBackColor = true;
            showOrders.Click += showOrders_Click;
            // 
            // createOrder
            // 
            createOrder.Location = new Point(286, 92);
            createOrder.Name = "createOrder";
            createOrder.Size = new Size(108, 60);
            createOrder.TabIndex = 1;
            createOrder.Text = "Opret Ordre";
            createOrder.UseVisualStyleBackColor = true;
            createOrder.Click += createOrder_Click;
            // 
            // planOrder
            // 
            planOrder.Location = new Point(286, 224);
            planOrder.Name = "planOrder";
            planOrder.Size = new Size(108, 60);
            planOrder.TabIndex = 2;
            planOrder.Text = "Planlæg ordre";
            planOrder.UseVisualStyleBackColor = true;
            // 
            // startOrder
            // 
            startOrder.Location = new Point(286, 290);
            startOrder.Name = "startOrder";
            startOrder.Size = new Size(108, 60);
            startOrder.TabIndex = 3;
            startOrder.Text = "Start/Afslut ordre";
            startOrder.UseVisualStyleBackColor = true;
            // 
            // MenuView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 450);
            Controls.Add(startOrder);
            Controls.Add(planOrder);
            Controls.Add(createOrder);
            Controls.Add(showOrders);
            Name = "MenuView";
            Text = "MenuView";
            ResumeLayout(false);
        }

        #endregion

        private Button showOrders;
        private Button createOrder;
        private Button planOrder;
        private Button startOrder;
    }
}