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
            if (CustomerNametextBox.Text == "" )
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

                ShowCustomerInfoRichTextBox.AppendText("Customer Name : " + CustomerNametextBox.Text + "\n\n");
                ShowCustomerInfoRichTextBox.AppendText("Customer Contract Number : " + CustomerNumberTextBox.Text + "\n\n");
                ShowCustomerInfoRichTextBox.AppendText("Customer Address : " + AddressTextBox.Text + "\n\n");
                ShowCustomerInfoRichTextBox.AppendText("Order Itmes : " + OrderComboBox.Text + "\n\n");
                ShowCustomerInfoRichTextBox.AppendText("Qunatity : " + QuantityTextBox.Text + "\n\n");

                string Bill_Show;
                double Total_Bill;
                string quantity = QuantityTextBox.Text;
                double QuantityOfItem = Convert.ToDouble(quantity);
                if (OrderComboBox.Text == "Black - 120 BDT")
                {
                    Total_Bill = 120 * QuantityOfItem;
                    Bill_Show = Convert.ToString(Total_Bill);
                    ShowCustomerInfoRichTextBox.AppendText("Total Bill : " + Bill_Show);
                }
                else if (OrderComboBox.Text == "Cold  - 100 BDT")
                {
                    Total_Bill = 100 * QuantityOfItem;
                    Bill_Show = Convert.ToString(Total_Bill);
                    ShowCustomerInfoRichTextBox.AppendText("Total Bill : " + Bill_Show);

                }

                else if (OrderComboBox.Text == "Hot    - 90  BDT")
                {
                    Total_Bill = 90 * QuantityOfItem;
                    Bill_Show = Convert.ToString(Total_Bill);
                    ShowCustomerInfoRichTextBox.AppendText("Total Bill : " + Bill_Show);

                }

                else if (OrderComboBox.Text == "Regular - 80 BDT")
                {
                    Total_Bill = 80 * QuantityOfItem;
                    Bill_Show = Convert.ToString(Total_Bill);
                    ShowCustomerInfoRichTextBox.AppendText("Total Bill : " + Bill_Show);

                }


            }
         
         
  
         
          

           

        
           
        }
    }
}
