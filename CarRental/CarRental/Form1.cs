using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Form1 : Form
    {

        private ADODB.Connection Cn;
        private ADODB.Recordset Rscar;
        private ADODB.Recordset Rsuser;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String Sqlstr1, Sqlstr2;
            Cn = new ADODB.Connection();
            Rscar = new ADODB.Recordset();
            Rsuser = new ADODB.Recordset();


            Cn.Provider = "Microsoft.Jet.Oledb.4.0";
            Cn.ConnectionString = "DataBase\\Cars.mdb";
            Cn.Open();

            Sqlstr1 = "select * from Car";
            Sqlstr2 = "select * from Customer";

            Rscar.Open(Sqlstr1, Cn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
            Rsuser.Open(Sqlstr2, Cn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);

            menu.Parent = tab;
            info.Parent = null;
            customer.Parent = null;
            modify.Parent = null;
            returnCar.Parent = null;

            Rscar.MoveFirst();
            //Rsuser.MoveFirst();


        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            info.Parent = null;
            menu.Parent = tab;
        }

        private void cancelRent_Click(object sender, EventArgs e)
        {
            menu.Parent = tab;
            customer.Parent = null;
        }

        private void rent_Click(object sender, EventArgs e)
        {
            Rscar.MoveFirst();
            Rsuser.MoveFirst();
            while (!Rscar.EOF)
            {
                if (carID.Text.Equals(Rscar.Fields["CarID"].Value))
                {
                    Rscar.Fields["Availability"].Value = "No";
                    
                    Rsuser.AddNew();
                    Rsuser.Fields["CarID"].Value = Convert.ToInt32(carID.Text);
                    Rsuser.Fields["FirstName"].Value = firstName.Text;
                    Rsuser.Fields["LastName"].Value = lastName.Text;
                    Rsuser.Fields["PhoneNumber"].Value = phoneNumber.Text;
                    Rsuser.Fields["RentDate"].Value = Convert.ToDateTime(rentDate.Text);
                    Rsuser.Fields["ReturnDate"].Value = Convert.ToDateTime(returnDate.Text);
                    Rsuser.Fields["Rent"].Value = "Yes";
                    Rscar.Update();
                    Rsuser.Update();
                    MessageBox.Show("You rent car successfully");
                    return;
                }
                Rscar.MoveNext();
            }
            MessageBox.Show("Something wrong....");
        }

       

        private void chose_Click(object sender, EventArgs e)
        {
            carID.Text = carNum.Text;
            carID.Enabled = false;
            info.Parent = null;
            customer.Parent = tab;
           
        }

        private void cancelModifyButton_Click(object sender, EventArgs e)
        {
            menu.Parent = tab;
            modify.Parent = null;
        }

        private void modifyDelete_Click(object sender, EventArgs e)
        {

            modifyID.Text = carNum.Text;
            modifyName.Text = carname.Text;
            modifyMake.Text = carmake.Text;
            modifyModel.Text = carmodel.Text;
            modifyColor.Text = carColor.Text;
            modifyType.Text = cartype.Text;
            modifyVIN.Text = carvin.Text;
            modifyPrice.Text = carprice.Text;

            modifyID.Enabled = false;
            modifyName.Enabled = false;
            modifyMake.Enabled = false;
            modifyModel.Enabled = false;
            modifyColor.Enabled = false;
            modifyType.Enabled = false;
            modifyVIN.Enabled = false;
            modifyPrice.Enabled = false;

            deleteButton.Visible = true;
            addButton.Visible = false;

            info.Parent = null;
            modify.Parent = tab;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Rscar.MoveFirst();
            Rsuser.MoveFirst();
            Boolean flag = false;

            while (!Rsuser.EOF)
            {
                if (Rsuser.Fields["CarID"].Value == Convert.ToInt32(returnID.Text))
                {
                    if (Rsuser.Fields["FirstName"].Value.Equals(returnFirstName.Text) && Rsuser.Fields["LastName"].Value.Equals(returnLastName))
                    {
                        flag = true;
                        break;
                    }
                }
                Rsuser.MoveNext();
            }

            if (flag == true)
            {
                while (!Rscar.EOF)
                {
                    if (Rscar.Fields["CarID"].Value == Convert.ToInt32(returnID.Text))
                    {
                        Rsuser.Fields["Rent"].Value = "No";
                        Rsuser.Update();

                        Rscar.Fields["Availability"].Value = "Yes";
                        Rscar.Update();
                    }
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            returnCar.Parent = null;
            menu.Parent = tab;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu.Parent = null;
            returnCar.Parent = tab;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            info.Parent = tab;
            menu.Parent = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteButton.Visible = false;
            addButton.Visible = true;

            modify.Parent = tab;
            menu.Parent = null;
        }

        private void Show()
        {
            carNum.Text = Rscar.Fields["CarID"].Value.ToString();
            carname.Text = Rscar.Fields["Name"].Value.ToString();
            carmodel.Text = Rscar.Fields["Model"].Value.ToString();
            carmake.Text = Rscar.Fields["Make"].Value.ToString();
            cartype.Text = Rscar.Fields["Type"].Value.ToString();
            carColor.Text = Rscar.Fields["Color"].Value.ToString();
            carvin.Text = Rscar.Fields["VIN"].Value.ToString();
            carprice.Text = Rscar.Fields["Price"].Value.ToString();

            if (Rscar.Fields["Availability"].Value == true)
            {
                caravailability.Text = "Yes";
            }
            else
            {
                caravailability.Text = "No";
            }
            //caravailability.Text = Rscar.Fields["Availability"].Value.ToString();
        }

        private void goFirst_Click(object sender, EventArgs e)
        {
            Rscar.MoveFirst();
            Show();
        }

        private void goLast_Click(object sender, EventArgs e)
        {
            Rscar.MoveLast();
            Show();
        }

        private void goNext_Click(object sender, EventArgs e)
        {
            Rscar.MoveNext();
            Show();
        }

        private void goPrevious_Click(object sender, EventArgs e)
        {
            Rscar.MovePrevious();
            Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Rscar.MoveLast();
            Rscar.AddNew();
            Rscar.Fields["CarID"].Value  = Convert.ToInt32(carID.Text);
            Rscar.Fields["Name"].Value = modifyName.Text;  
            Rscar.Fields["Model"].Value = modifyModel.Text;
            Rscar.Fields["Make"].Value = modifyMake.Text;
            Rscar.Fields["Type"].Value = modifyType.Text;
            Rscar.Fields["Color"].Value = modifyColor.Text;
            Rscar.Fields["VIN"].Value = Convert.ToInt32(modifyVIN.Text);
            Rscar.Fields["Price"].Value = Convert.ToInt32(modifyPrice.Text);
            Rscar.Fields["Availability"].Value = true;
            Rscar.Update();
            modify.Parent = null;
            menu.Parent = tab;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Boolean flag = false;
            Rscar.MoveFirst();
            while (!Rscar.EOF)
            {
                //if (flag == true)
                //{
                //    Rscar.Fields["CarID"].Value -= 1;
                //}

                if (Rscar.Fields["CarID"].Value == Convert.ToInt32(modifyID.Text))
                {
                    Rscar.Delete();
                    MessageBox.Show("You delete car successfully");
                    break;
                    //flag = true;
                }

               
                Rscar.MoveNext();
            }
            Rscar.MoveFirst();
            modify.Parent = null;
            info.Parent = tab;
            Show();
        }


      
    }
}
