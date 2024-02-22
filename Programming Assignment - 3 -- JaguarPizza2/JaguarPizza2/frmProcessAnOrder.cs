

//      Programmed BY: Kanakam Vamsi Krishna Prasad
//                  J00744483


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

namespace JaguarPizza2
{
    public partial class frmProcessAnOrder : Form
    {
        public frmProcessAnOrder()
        {
            InitializeComponent();
        }

        //Global Variables
        public static List<string[]> customers = new List<string[]>();
        public static int customerNumber;

        
        //--------------------------------- Data Loading -----------------------------------------------------------

        private void frmProcessAnOrder_Load(object sender, EventArgs e)
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
                cbDelivery.CheckState = CheckState.Unchecked;
                string[] toppings = { "Pepperoni", "Bacon", "Sausage", "Ham",
                "Mushrooms", "Onions", "Olives", "Tomatoes","Green Peppers","Extra Cheese"};
                foreach (string topping in toppings)
                {
                    lstToppings.Items.Add(topping);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //----------------------------------- Process Order ----------------------------------------------------------
        private void btnProcessOrder_Click(object sender, EventArgs e)
        {
            ProceessOrder();
        }

        //--------------------------- PROCESS ORDER METHOD -------------------------------------------------------
        public void ProceessOrder()
        {
            //frmreceipt instance
            frmReceipt theReceipt = new frmReceipt();

            //--------------- VALIDADTION ----------------------------------------------------------------------
            if (cboCustomerName.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the Customer");
                return;
            }

            if (hsbNoofPizzas.Value < 1)
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
                if (cbDelivery.Checked)
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
                theReceipt.lvwReceipt.Items.Add(customerName);
                //----NoofPizzas
                outputArray[0] = "Number of Pizzas:";
                outputArray[1] = numberOfPizzas.ToString();
                ListViewItem Pizzas = new ListViewItem(outputArray);
                theReceipt.lvwReceipt.Items.Add(Pizzas);

                //----PizzaSize

                outputArray[0] = "Size: " + sizeName;
                outputArray[1] = pizzaPrice.ToString("C");
                ListViewItem size = new ListViewItem(outputArray);
                theReceipt.lvwReceipt.Items.Add(size);

                //----crustType

                outputArray[0] = "Crust Type: " + crustName;
                outputArray[1] = crustPrice.ToString("C");
                ListViewItem crust = new ListViewItem(outputArray);
                theReceipt.lvwReceipt.Items.Add(crust);

                //----Toppings

                outputArray[0] = "Toppings:";
                outputArray[1] = "No Toppings";
                int count = 0;
                foreach (string lstTopping in lstToppings.SelectedItems)
                {
                    if (count == 0)
                    {
                        outputArray[1] = lstTopping + " $0.00";
                    }
                    else
                    {
                        outputArray[1] = lstTopping + " $1.00";
                    }

                    ListViewItem topping = new ListViewItem(outputArray);
                    theReceipt.lvwReceipt.Items.Add(topping);
                    count++;
                }
                if(lstToppings.SelectedItems.Count == 0)
                {
                    ListViewItem topping = new ListViewItem(outputArray);
                    theReceipt.lvwReceipt.Items.Add(topping);
                }

                //----Toppings cost
                if(lstToppings.SelectedItems.Count >= 1)
                {
                    outputArray[0] = "Toppings Cost";
                    outputArray[1] = (count - 1).ToString("C");
                    ListViewItem toppingCost = new ListViewItem(outputArray);
                    theReceipt.lvwReceipt.Items.Add(toppingCost);
                }

                //----- seperator
                outputArray[0] = "-----------------------------";
                outputArray[1] = "-----------------------------";
                ListViewItem seperator = new ListViewItem(outputArray);
                theReceipt.lvwReceipt.Items.Add(seperator);

                //----SubTotal
                outputArray[0] = "Sub Total";
                outputArray[1] = subTotal.ToString("C");
                ListViewItem sub = new ListViewItem(outputArray);
                theReceipt.lvwReceipt.Items.Add(sub);

                //----Student Discount
                if (cbStudent.Checked)
                {
                    outputArray[0] = "Student Discount";
                    outputArray[1] = studentDiscount.ToString("C");
                    ListViewItem Discount = new ListViewItem(outputArray);
                    theReceipt.lvwReceipt.Items.Add(Discount);

                    //----SubTotal After Discount
                    outputArray[0] = "Sub Total After Discount";
                    outputArray[1] = subTotalAfterDiscount.ToString("C");
                    ListViewItem subAfter = new ListViewItem(outputArray);
                    theReceipt.lvwReceipt.Items.Add(subAfter);
                }

                //---- Tax Amount
                outputArray[0] = "Tax Amount";
                outputArray[1] = salesTax.ToString("C");
                ListViewItem Tax = new ListViewItem(outputArray);
                theReceipt.lvwReceipt.Items.Add(Tax);

                //---- Checkout
                outputArray[0] = "PickUp/Delivery";
                if (cbDelivery.Checked)
                {
                    outputArray[1] = "Delivery";
                }
                else if (!cbDelivery.Checked)
                {
                    outputArray[1] = "PickUp";
                }
                ListViewItem pickUp = new ListViewItem(outputArray);
                theReceipt.lvwReceipt.Items.Add(pickUp);

                if (cbDelivery.Checked)
                {
                    outputArray[0] = "Delivery Cost";
                    outputArray[1] = deliveryPrice.ToString("C");
                    ListViewItem delivery = new ListViewItem(outputArray);
                    theReceipt.lvwReceipt.Items.Add(delivery);

                    outputArray[0] = "Customer Address";
                    outputArray[1] = customers[cboCustomerName.SelectedIndex][2];

                    ListViewItem address = new ListViewItem(outputArray);
                    theReceipt.lvwReceipt.Items.Add(address);

                }

                //----- seperator
                outputArray[0] = "-----------------------------";
                outputArray[1] = "-----------------------------";
                ListViewItem seperator2 = new ListViewItem(outputArray);
                theReceipt.lvwReceipt.Items.Add(seperator2);

                //----Total Cost
                outputArray[0] = "Total Amount";
                outputArray[1] = totalPrice.ToString("C");
                ListViewItem total = new ListViewItem(outputArray);
                theReceipt.lvwReceipt.Items.Add(total);

                //----- seperator
                outputArray[0] = "-----------------------------";
                outputArray[1] = "-----------------------------";
                ListViewItem seperator3 = new ListViewItem(outputArray);
                theReceipt.lvwReceipt.Items.Add(seperator3);

                theReceipt.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //---------------------------------- HORIZONTAL SCROLL BAR ----------------------------------------
        private void hsbNoofPizzas_Scroll(object sender, ScrollEventArgs e)
        {
            lblNoofPizzas.Text = hsbNoofPizzas.Value.ToString();
        }


        // ------------------------------------ MENU STRIP ----------------------------------------------
        private void processOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProceessOrder();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        //---------------------------------- CLOSE FORM ----------------------------------------------------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-------------------- CLEAR FORM --------------------------------------------------------
        public void ClearForm()
        {
            cboCustomerName.SelectedIndex = -1;
            hsbNoofPizzas.Value = 0;
            rdbLarge.Checked = true;
            rdbTraditional.Checked = true;
            cbDelivery.Checked = false;
            lstToppings.SelectedIndex = -1;
            cbStudent.Checked = false;
        }

    }
}
