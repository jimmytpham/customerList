namespace RetailStore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameLabel = new Label();
            nameTextBox = new TextBox();
            adressTextBox = new TextBox();
            phoneTextBox = new TextBox();
            customerIDTextBox = new TextBox();
            purchaseTextBox = new TextBox();
            adressLabel = new Label();
            phoneLabel = new Label();
            customerNumberLabel = new Label();
            purchaseLabel = new Label();
            customerIDGroupBox = new GroupBox();
            mailingListBox = new CheckBox();
            discountLevelLabel = new Label();
            discountLevelTextBox = new Label();
            createUpdateButton = new Button();
            CustomerList = new ListBox();
            customerIDGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(55, 58);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(83, 32);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(302, 58);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 39);
            nameTextBox.TabIndex = 1;
            // 
            // adressTextBox
            // 
            adressTextBox.Location = new Point(302, 128);
            adressTextBox.Multiline = true;
            adressTextBox.Name = "adressTextBox";
            adressTextBox.Size = new Size(200, 91);
            adressTextBox.TabIndex = 2;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(302, 251);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(200, 39);
            phoneTextBox.TabIndex = 3;
            // 
            // customerIDTextBox
            // 
            customerIDTextBox.Location = new Point(302, 328);
            customerIDTextBox.Name = "customerIDTextBox";
            customerIDTextBox.Size = new Size(200, 39);
            customerIDTextBox.TabIndex = 4;
            // 
            // purchaseTextBox
            // 
            purchaseTextBox.Location = new Point(302, 385);
            purchaseTextBox.Name = "purchaseTextBox";
            purchaseTextBox.Size = new Size(200, 39);
            purchaseTextBox.TabIndex = 5;
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Location = new Point(55, 128);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new Size(103, 32);
            adressLabel.TabIndex = 6;
            adressLabel.Text = "Address:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(55, 251);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(108, 32);
            phoneLabel.TabIndex = 7;
            phoneLabel.Text = "Phone #:";
            // 
            // customerNumberLabel
            // 
            customerNumberLabel.AutoSize = true;
            customerNumberLabel.Location = new Point(55, 318);
            customerNumberLabel.Name = "customerNumberLabel";
            customerNumberLabel.Size = new Size(143, 32);
            customerNumberLabel.TabIndex = 8;
            customerNumberLabel.Text = "Customer #:";
            // 
            // purchaseLabel
            // 
            purchaseLabel.AutoSize = true;
            purchaseLabel.Location = new Point(55, 385);
            purchaseLabel.Name = "purchaseLabel";
            purchaseLabel.Size = new Size(241, 32);
            purchaseLabel.TabIndex = 9;
            purchaseLabel.Text = "Amount Purchased: $";
            // 
            // customerIDGroupBox
            // 
            customerIDGroupBox.Controls.Add(mailingListBox);
            customerIDGroupBox.Controls.Add(discountLevelLabel);
            customerIDGroupBox.Controls.Add(discountLevelTextBox);
            customerIDGroupBox.Controls.Add(createUpdateButton);
            customerIDGroupBox.Controls.Add(nameLabel);
            customerIDGroupBox.Controls.Add(purchaseLabel);
            customerIDGroupBox.Controls.Add(nameTextBox);
            customerIDGroupBox.Controls.Add(customerNumberLabel);
            customerIDGroupBox.Controls.Add(adressTextBox);
            customerIDGroupBox.Controls.Add(phoneLabel);
            customerIDGroupBox.Controls.Add(phoneTextBox);
            customerIDGroupBox.Controls.Add(adressLabel);
            customerIDGroupBox.Controls.Add(customerIDTextBox);
            customerIDGroupBox.Controls.Add(purchaseTextBox);
            customerIDGroupBox.Location = new Point(665, 51);
            customerIDGroupBox.Name = "customerIDGroupBox";
            customerIDGroupBox.Size = new Size(543, 647);
            customerIDGroupBox.TabIndex = 10;
            customerIDGroupBox.TabStop = false;
            customerIDGroupBox.Text = "Customer ID";
            // 
            // mailingListBox
            // 
            mailingListBox.AutoSize = true;
            mailingListBox.Location = new Point(55, 436);
            mailingListBox.Name = "mailingListBox";
            mailingListBox.Size = new Size(247, 36);
            mailingListBox.TabIndex = 13;
            mailingListBox.Text = "Add to Mailing List";
            mailingListBox.UseVisualStyleBackColor = true;
            // 
            // discountLevelLabel
            // 
            discountLevelLabel.AutoSize = true;
            discountLevelLabel.Location = new Point(302, 540);
            discountLevelLabel.Name = "discountLevelLabel";
            discountLevelLabel.Size = new Size(170, 32);
            discountLevelLabel.TabIndex = 12;
            discountLevelLabel.Text = "Discount Level";
            // 
            // discountLevelTextBox
            // 
            discountLevelTextBox.BorderStyle = BorderStyle.FixedSingle;
            discountLevelTextBox.Location = new Point(302, 572);
            discountLevelTextBox.Name = "discountLevelTextBox";
            discountLevelTextBox.Size = new Size(200, 52);
            discountLevelTextBox.TabIndex = 11;
            // 
            // createUpdateButton
            // 
            createUpdateButton.Location = new Point(55, 487);
            createUpdateButton.Name = "createUpdateButton";
            createUpdateButton.Size = new Size(292, 46);
            createUpdateButton.TabIndex = 10;
            createUpdateButton.Text = "Create Customer";
            createUpdateButton.UseVisualStyleBackColor = true;
            createUpdateButton.Click += button1_Click;
            // 
            // CustomerList
            // 
            CustomerList.FormattingEnabled = true;
            CustomerList.HorizontalScrollbar = true;
            CustomerList.ItemHeight = 32;
            CustomerList.Location = new Point(82, 51);
            CustomerList.Name = "CustomerList";
            CustomerList.Size = new Size(459, 644);
            CustomerList.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 822);
            Controls.Add(CustomerList);
            Controls.Add(customerIDGroupBox);
            Name = "Form1";
            Text = "Form1";
            customerIDGroupBox.ResumeLayout(false);
            customerIDGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private TextBox adressTextBox;
        private TextBox phoneTextBox;
        private TextBox customerIDTextBox;
        private TextBox purchaseTextBox;
        private Label adressLabel;
        private Label phoneLabel;
        private Label customerNumberLabel;
        private Label purchaseLabel;
        private GroupBox customerIDGroupBox;
        private ListBox CustomerList;
        private Label discountLevelLabel;
        private Label discountLevelTextBox;
        private Button createUpdateButton;
        private CheckBox mailingListBox;
    }
}