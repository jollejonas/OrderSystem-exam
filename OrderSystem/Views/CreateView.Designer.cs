namespace OrderSystem.Views
{
    partial class CreateView
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
            nameTextbox = new TextBox();
            descriptionTextbox = new TextBox();
            nameLabel = new Label();
            descriptionLabel = new Label();
            createButton = new Button();
            resetButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(353, 139);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(308, 23);
            nameTextbox.TabIndex = 0;
            // 
            // descriptionTextbox
            // 
            descriptionTextbox.Location = new Point(353, 191);
            descriptionTextbox.Multiline = true;
            descriptionTextbox.Name = "descriptionTextbox";
            descriptionTextbox.Size = new Size(308, 208);
            descriptionTextbox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(353, 121);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(66, 15);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Ordre navn";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(353, 173);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(64, 15);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Beskrivelse";
            // 
            // createButton
            // 
            createButton.Location = new Point(353, 405);
            createButton.Name = "createButton";
            createButton.Size = new Size(90, 23);
            createButton.TabIndex = 5;
            createButton.Text = "Opret";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(462, 405);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(90, 23);
            resetButton.TabIndex = 6;
            resetButton.Text = "Nulstil";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(571, 405);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(90, 23);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Annuller";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // CreateView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 523);
            Controls.Add(cancelButton);
            Controls.Add(resetButton);
            Controls.Add(createButton);
            Controls.Add(descriptionLabel);
            Controls.Add(nameLabel);
            Controls.Add(descriptionTextbox);
            Controls.Add(nameTextbox);
            Name = "CreateView";
            Text = "CreateMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextbox;
        private TextBox descriptionTextbox;
        private Label nameLabel;
        private Label descriptionLabel;
        private Button createButton;
        private Button resetButton;
        private Button cancelButton;
    }
}