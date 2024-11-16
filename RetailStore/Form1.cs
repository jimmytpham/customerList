//Jimmy Pham
//T00629354
//COMP 2211


using System.Globalization;

namespace RetailStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PreferredCustomer preferredCustomer = new PreferredCustomer();

            // Get information from the textbox that do not need to be verified
            preferredCustomer.Name = nameTextBox.Text;
            preferredCustomer.Address = adressTextBox.Text;
            preferredCustomer.CustomerNumber = customerIDTextBox.Text;
            preferredCustomer.MailingList = mailingListBox.Checked;

            // verify phone number textbox and format to (000) 000-0000
            string phoneNumber = phoneTextBox.Text;
            checkPhoneNumber(phoneNumber);
            formatNumber(ref phoneNumber);
            preferredCustomer.PhoneNumber = phoneNumber;

            //verify discount level
            if (int.TryParse(purchaseTextBox.Text, out int purchaseAmount))
            {
                preferredCustomer.PurchaseAmount = purchaseAmount;
                preferredCustomer.DiscountLevel = discountLevel(purchaseAmount);

                //update discount level label
                string discount = preferredCustomer.DiscountLevel.ToString("p");
                discountLevelTextBox.Text = (discount);
            }
            else
            {
                //resets application if characters are added that are not integers
                MessageBox.Show("Enter a valid amount! (ex. 1000)");
                Application.Restart();
            }

            //verify that each textbox is filled out
            if (checkCustomer(preferredCustomer))
            {
                string customerString = "Name: " + preferredCustomer.Name
                    + ", Phone: " + preferredCustomer.PhoneNumber
                    + ", Customer ID: " + preferredCustomer.CustomerNumber
                    + ", Mailing List: " + preferredCustomer.MailingList
                    + ", Total Spent: " + preferredCustomer.PurchaseAmount.ToString("c")
                    + ", Discount Level: " + preferredCustomer.DiscountLevel.ToString("p");


                CustomerList.Items.Add(customerString);
                MessageBox.Show("Customer Added");

            }
            else
            {
                //Error message if one of the boxes are not filled out
                MessageBox.Show("Invalid Customer Information!");
            }
        }

        private void checkPhoneNumber(string str)
        {
            //verify that the phone number is valid
            if (str.Length == 10)
            {
                foreach (char ch in str)
                {
                    if (!char.IsDigit(ch))
                    {
                        MessageBox.Show("Enter a Valid Phone Number!");
                        //restarts application so that customer info is not added without a phone number
                        Application.Restart();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter a Valid Phone Number!");
                Application.Restart();
            }
        }
        private void formatNumber(ref string str)
        {
            //Format phone number to (000) 000-0000
            str = str.Insert(0, "(");
            str = str.Insert(4, ")");
            str = str.Insert(5, " ");
            str = str.Insert(9, "-");
        }
        private decimal discountLevel(int purchaseAmount)
        {
            if (purchaseAmount >= 2000)
            {
                return 0.1m;
            }
            else if (purchaseAmount >= 1500)
            {
                return 0.07m;
            }
            else if (purchaseAmount >= 1000)
            {
                return 0.06m;
            }
            else if (purchaseAmount >= 500)
            {
                return 0.05m;
            }
            return 0;
        }

        private bool checkCustomer(PreferredCustomer customer)
        {
            //verify that each customer box is filled out
            if (customer.Name != "" && customer.Address != "" && customer.PhoneNumber != "" && customer.CustomerNumber != "")
            {
                return true;
            }
            return false;
        }
    }
}