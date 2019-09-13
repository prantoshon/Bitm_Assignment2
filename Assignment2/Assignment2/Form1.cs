using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CustomerNameTextBox.Text == "" )
            {

                MessageBox.Show("Please Write Your Name");
            }
            else  if (CustomerNumberTextBox.Text =="")
            {

                MessageBox.Show("Please Write Your Phone Number");
            }
            else if(AddressTextBox.Text =="")
            {
              MessageBox.Show("Please Write Your Address");
            }
              else if(OrderComboBox.Text =="")
            {
               MessageBox.Show("Please Select Item");
            }
              else if(QuantityTextBox.Text =="")
            {
               MessageBox.Show("Please Write Order Qunatity");
            }

      else
            {

                ShowCustomerInfoRichTextBox.AppendText("Customer Name : " + CustomerNameTextBox.Text + "\n\n");
                ShowCustomerInfoRichTextBox.AppendText("Customer Contract Number : " + CustomerNumberTextBox.Text + "\n\n");
                ShowCustomerInfoRichTextBox.AppendText("Customer Address : " + AddressTextBox.Text + "\n\n");
                ShowCustomerInfoRichTextBox.AppendText("Order Itmes : " + OrderComboBox.Text + "\n\n");
                ShowCustomerInfoRichTextBox.AppendText("Qunatity : " + QuantityTextBox.Text + "\n\n");

                string billShow;
                double totalBill;
                string quantity = QuantityTextBox.Text;
                double quantityOfItem = Convert.ToDouble(quantity);
                if (OrderComboBox.Text == "Black - 120 BDT")
                {
                    totalBill = 120 * quantityOfItem;
                    billShow = Convert.ToString(totalBill);
                    ShowCustomerInfoRichTextBox.AppendText("Total Bill : " + billShow);
                }
                else if (OrderComboBox.Text == "Cold  - 100 BDT")
                {
                    totalBill = 100 * quantityOfItem;
                    billShow = Convert.ToString(totalBill);
                    ShowCustomerInfoRichTextBox.AppendText("Total Bill : " + billShow);

                }

                else if (OrderComboBox.Text == "Hot    - 90  BDT")
                {
                    totalBill = 90 * quantityOfItem;
                    billShow = Convert.ToString(totalBill);
                    ShowCustomerInfoRichTextBox.AppendText("Total Bill : " + billShow);

                }

                else if (OrderComboBox.Text == "Regular - 80 BDT")
                {
                    totalBill = 80 * quantityOfItem;
                    billShow = Convert.ToString(totalBill);
                    ShowCustomerInfoRichTextBox.AppendText("Total Bill : " + billShow);

                }


            }
         
         
  
         
          

           

        
           
        }
    }
}
