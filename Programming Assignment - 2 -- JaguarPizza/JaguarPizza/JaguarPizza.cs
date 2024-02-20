

// Programmed BY: Kanakam Vamsi Krishna Prasad
//                J00744483




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace JaguarPizza
{
    public partial class JaguarPizza : Form
    {
        public JaguarPizza()
        {
            InitializeComponent();
        }

        //Global Variables
        List<string[]> customers = new List<string[]>();
        //Declare variable CustomerReader at class Level
        StreamWriter customerWriter;
        int customerNumber;
        //--------------------------------- Data Loading -----------------------------------------------------------

        private void JaguarPizza_Load(object sender, EventArgs e)
        {
            try
            {
                string currentLine;
                string[] fields;
                StreamReader CustomerReader = new StreamReader("Customer.txt");

                while (CustomerReader.EndOfStream == false)
                {
                    currentLine = CustomerReader.ReadLine();
                    fields = currentLine.Split(',');
                    customers.Add(fields);
                    cboCustomerName.Items.Add(fields[1].ToString());
                    customerNumber = int.Parse(fields[0]);
                }
                CustomerReader.Close();

                //Process Order Default Settings
                rdbLarge.Checked = true;
                rdbTraditional.Checked = true;
                rdbPickUp.Checked = true;
                string[] toppings = { "Pepperoni", "Bacon", "Sausage", "Ham",
                "Mushrooms", "Onions", "Olives", "Tomatoes","Green Peppers","Extra Cheese"};
                foreach (string topping in toppings)
                {
                    lstToppings.Items.Add(topping);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //----------------------------------- Process Order ----------------------------------------------------------
        private void btnProcessOrder_Click(object sender, EventArgs e)
        {
            //--------------- VALIDADTION ----------------------------------------------------------------------
            if(cboCustomerName.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the Customer");
                return;
            }

            if(lstToppings.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please Select the toppinggs you need.");
                return;
            }
            if(hsbNoofPizzas.Value < 1)
            {
                MessageBox.Show("Please Select the no.of.Pizzas");
                return;
            }


            try
            {
                //Declaration
                int numberOfPizzas = hsbNoofPizzas.Value;
                double pizzaPrice = 10, crustPrice = 0, toppingPrice = 0, deliveryPrice = 0, totalPrice, studentDiscount = 0, TAX_RATE = 0.12, subTotal;
                string sizeName = null, crustName = null;

                //Pizza Price
                if (rdbSmall.Checked)
                {
                    pizzaPrice = 6.00;
                    sizeName = "Small";
                }
                else if (rdbMedium.Checked)
                {
                    pizzaPrice = 8.00;
                    sizeName = "Medium";
                }
                else if (rdbLarge.Checked)
                {
                    pizzaPrice = 10.00;
                    sizeName = "Large";
                }
                else if (rdbSuper.Checked)
                {
                    pizzaPrice = 12.00;
                    sizeName = "Super";
                }
                //CrustType price
                if (rdbDeepDish.Checked)
                {
                    crustPrice = 2.00;
                    crustName = "Deep Dish";
                }
                else if (rdbTraditional.Checked)
                {
                    crustPrice = 0;
                    crustName = "Traditional";
                }
                else if (rdbThin.Checked)
                {
                    crustPrice = 0;
                    crustName = "Thin";
                }

                //Topping Price
                toppingPrice = lstToppings.SelectedItems.Count - 1;

                //Delivery Price
                if (rdbDelivery.Checked)
                {
                    deliveryPrice = 5.00;
                }

                //Calculation

                subTotal = numberOfPizzas * (pizzaPrice + crustPrice + toppingPrice);

                if (cbStudent.Checked)
                {
                    studentDiscount = 0.1 * subTotal;
                }

                double subTotalAfterDiscount = subTotal - studentDiscount;
                double salesTax = subTotalAfterDiscount * TAX_RATE;
                totalPrice = subTotalAfterDiscount + salesTax + deliveryPrice;


                //Display Receipt
                string[] outputArray = new string[2];
                outputArray[0] = "Customer Name:";
                outputArray[1] = cboCustomerName.SelectedItem.ToString();

                //create listview item to hold output
                ListViewItem customerName = new ListViewItem(outputArray);
                //add the list view items to the list view
                lvwReceipt.Items.Add(customerName);
                //----NoofPizzas
                outputArray[0] = "Number of Pizzas:";
                outputArray[1] = numberOfPizzas.ToString();
                ListViewItem Pizzas = new ListViewItem(outputArray);
                lvwReceipt.Items.Add(Pizzas);

                //----PizzaSize

                outputArray[0] = "Size: " + sizeName;
                outputArray[1] = pizzaPrice.ToString("C");
                ListViewItem size = new ListViewItem(outputArray);
                lvwReceipt.Items.Add(size);

                //----crustType

                outputArray[0] = "Crust Type: " + crustName;
                outputArray[1] = crustPrice.ToString("C");
                ListViewItem crust = new ListViewItem(outputArray);
                lvwReceipt.Items.Add(crust);

                //----Toppings

                outputArray[0] = "Listing of Toppings:";
                outputArray[1] = null;
                foreach (string lstTopping in lstToppings.SelectedItems)
                {
                    outputArray[1] += lstTopping + ", ";
                }
                ListViewItem topping = new ListViewItem(outputArray);
                lvwReceipt.Items.Add(topping);

                //----SubTotal
                outputArray[0] = "Sub Total";
                outputArray[1] = subTotal.ToString("C");
                ListViewItem sub = new ListViewItem(outputArray);
                lvwReceipt.Items.Add(sub);

                //----Student Discount
                if (cbStudent.Checked)
                {
                    outputArray[0] = "Student Discount";
                    outputArray[1] = studentDiscount.ToString("C");
                    ListViewItem Discount = new ListViewItem(outputArray);
                    lvwReceipt.Items.Add(Discount);

                    //----SubTotal After Discount
                    outputArray[0] = "Sub Total After Discount";
                    outputArray[1] = subTotalAfterDiscount.ToString("C");
                    ListViewItem subAfter = new ListViewItem(outputArray);
                    lvwReceipt.Items.Add(subAfter);
                }

                //---- Tax Amount
                outputArray[0] = "Tax Amount";
                outputArray[1] = salesTax.ToString("C");
                ListViewItem Tax = new ListViewItem(outputArray);
                lvwReceipt.Items.Add(Tax);

                //---- Checkout
                outputArray[0] = "PickUp/Delivery";
                if (rdbDelivery.Checked)
                {
                    outputArray[1] = "Delivery";
                }
                else if (rdbPickUp.Checked)
                {
                    outputArray[1] = "PickUp";
                }
                ListViewItem pickUp = new ListViewItem(outputArray);
                lvwReceipt.Items.Add(pickUp);

                if (rdbDelivery.Checked)
                {
                    outputArray[0] = "Delivery Cost";
                    outputArray[1] = deliveryPrice.ToString("C");
                    ListViewItem delivery = new ListViewItem(outputArray);
                    lvwReceipt.Items.Add(delivery);

                    outputArray[0] = "Customer Address";
                    outputArray[1] = customers[cboCustomerName.SelectedIndex][2];
                    
                    ListViewItem address = new ListViewItem(outputArray);
                    lvwReceipt.Items.Add(address);

                }

                //----Total Cost
                outputArray[0] = "Total Amount";
                outputArray[1] = totalPrice.ToString("C");
                ListViewItem total = new ListViewItem(outputArray);
                lvwReceipt.Items.Add(total);

                tabPizzaOrder.SelectedTab = tbpReceipt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //----------------------------Horizontal Scroll Bar ------------------------------------------------------
        private void hsbNoofPizzas_Scroll(object sender, ScrollEventArgs e)
        {
            lblNoofPizzas.Text = hsbNoofPizzas.Value.ToString();
        }
        //------------------------------------Add Customers Tab -------------------------------------------------------------
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //-------------------------- VAILDATION ---------------------------------------------------------------
            if (txtCustomerName.Text.Length==0)
            {
                MessageBox.Show("Customer Name Need Not be null");
            }

            if (txtStreetAddress.Text.Length==0)
            {
                MessageBox.Show("Street Name is empty");
            }

            if(txtZipCode.Text.Length == 0)
            {
                MessageBox.Show("ZipCode should no be empty");
            }
            long zipCode;
            if(long.TryParse(txtZipCode.Text,out zipCode) == false)
            {
                MessageBox.Show("ZipCode is a numeric type");
            }

            long phoneNumber;
            if (long.TryParse(txtPhoneNumber.Text, out phoneNumber) == false)
            {
                MessageBox.Show("PhoneNumber is a numeric type");
            }

            if(txtPhoneNumber.Text.Length == 0)
            {
                MessageBox.Show("PhoneNumber should not be null");
            }

            if(zipCode < 0)
            {
                MessageBox.Show("ZipCode is a positive numeric type");
            }
            if(phoneNumber < 0)
            {
                MessageBox.Show("PhoneNumber must not be a negative number.");
            }

            ofdAddCustomer.ShowDialog();
            string fileName = ofdAddCustomer.FileName;
            customerWriter = new StreamWriter(fileName,true);
            int customerNum = customerNumber + 1;
            customerNumber = customerNum;
            customerWriter.WriteLine(customerNum + "," + txtCustomerName.Text + "," + txtStreetAddress.Text + "," + txtZipCode.Text + "," + txtPhoneNumber.Text);
            cboCustomerName.Items.Add(txtCustomerName.Text);
            string[] newfield = {customerNum.ToString(),txtCustomerName.Text,txtStreetAddress.Text,txtZipCode.Text,txtPhoneNumber.Text };
            customers.Add(newfield);
            MessageBox.Show("New Customer Added.");
            customerWriter.Close();
        }
        //---------------------------------- Clear -------------------------------------------------------
        private void btnClearInput_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtStreetAddress.Clear();
            txtZipCode.Clear();
            txtPhoneNumber.Clear();
        }
        //----------------------------------------- Clear -----------------------------------------------------------
        private void btnClear_Click(object sender, EventArgs e)
        {
            cboCustomerName.SelectedIndex = -1;
            hsbNoofPizzas.Value = 0;
            rdbLarge.Checked = true;
            rdbTraditional.Checked = true;
            rdbPickUp.Checked = true;
            lstToppings.SelectedIndex = -1;
            cbStudent.Checked = false;
            lvwReceipt.Items.Clear();
        }
        //------------------------------------- Exit ----------------------------------------------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
