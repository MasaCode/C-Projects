namespace CarRental
{
    partial class Form1
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
            this.modify = new System.Windows.Forms.TabPage();
            this.customer = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.carID = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.rentDate = new System.Windows.Forms.TextBox();
            this.returnDate = new System.Windows.Forms.TextBox();
            this.rent = new System.Windows.Forms.Button();
            this.cancelRent = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.carname = new System.Windows.Forms.TextBox();
            this.carmodel = new System.Windows.Forms.TextBox();
            this.carmake = new System.Windows.Forms.TextBox();
            this.cartype = new System.Windows.Forms.TextBox();
            this.carColor = new System.Windows.Forms.TextBox();
            this.carvin = new System.Windows.Forms.TextBox();
            this.carprice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.carNum = new System.Windows.Forms.TextBox();
            this.chose = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.TabControl();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.modifyID = new System.Windows.Forms.TextBox();
            this.modifyName = new System.Windows.Forms.TextBox();
            this.modifyMake = new System.Windows.Forms.TextBox();
            this.modifyModel = new System.Windows.Forms.TextBox();
            this.modifyType = new System.Windows.Forms.TextBox();
            this.modifyColor = new System.Windows.Forms.TextBox();
            this.modifyVIN = new System.Windows.Forms.TextBox();
            this.modifyPrice = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.returnCar = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.returnID = new System.Windows.Forms.TextBox();
            this.returnFirstName = new System.Windows.Forms.TextBox();
            this.returnLastName = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.cancelModifyButton = new System.Windows.Forms.Button();
            this.modifyDelete = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.caravailability = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.goFirst = new System.Windows.Forms.Button();
            this.goNext = new System.Windows.Forms.Button();
            this.goPrevious = new System.Windows.Forms.Button();
            this.goLast = new System.Windows.Forms.Button();
            this.modify.SuspendLayout();
            this.customer.SuspendLayout();
            this.info.SuspendLayout();
            this.tab.SuspendLayout();
            this.returnCar.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // modify
            // 
            this.modify.Controls.Add(this.cancelModifyButton);
            this.modify.Controls.Add(this.deleteButton);
            this.modify.Controls.Add(this.addButton);
            this.modify.Controls.Add(this.modifyPrice);
            this.modify.Controls.Add(this.modifyVIN);
            this.modify.Controls.Add(this.modifyColor);
            this.modify.Controls.Add(this.modifyType);
            this.modify.Controls.Add(this.modifyModel);
            this.modify.Controls.Add(this.modifyMake);
            this.modify.Controls.Add(this.modifyName);
            this.modify.Controls.Add(this.modifyID);
            this.modify.Controls.Add(this.label23);
            this.modify.Controls.Add(this.label22);
            this.modify.Controls.Add(this.label21);
            this.modify.Controls.Add(this.label20);
            this.modify.Controls.Add(this.label19);
            this.modify.Controls.Add(this.label18);
            this.modify.Controls.Add(this.label17);
            this.modify.Controls.Add(this.label16);
            this.modify.Controls.Add(this.label15);
            this.modify.Location = new System.Drawing.Point(4, 22);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(711, 538);
            this.modify.TabIndex = 3;
            this.modify.Text = "Modify Car";
            this.modify.UseVisualStyleBackColor = true;
            // 
            // customer
            // 
            this.customer.Controls.Add(this.cancelRent);
            this.customer.Controls.Add(this.rent);
            this.customer.Controls.Add(this.returnDate);
            this.customer.Controls.Add(this.rentDate);
            this.customer.Controls.Add(this.phoneNumber);
            this.customer.Controls.Add(this.lastName);
            this.customer.Controls.Add(this.firstName);
            this.customer.Controls.Add(this.carID);
            this.customer.Controls.Add(this.label13);
            this.customer.Controls.Add(this.label12);
            this.customer.Controls.Add(this.label11);
            this.customer.Controls.Add(this.label10);
            this.customer.Controls.Add(this.label9);
            this.customer.Controls.Add(this.label7);
            this.customer.Location = new System.Drawing.Point(4, 22);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(711, 538);
            this.customer.TabIndex = 2;
            this.customer.Text = "Rent";
            this.customer.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(128, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "First Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(128, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Last Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(128, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Phone Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(128, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Rent Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(128, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Return Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(127, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Car ID";
            // 
            // carID
            // 
            this.carID.Location = new System.Drawing.Point(319, 52);
            this.carID.Name = "carID";
            this.carID.Size = new System.Drawing.Size(188, 20);
            this.carID.TabIndex = 6;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(319, 94);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(188, 20);
            this.firstName.TabIndex = 7;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(319, 137);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(188, 20);
            this.lastName.TabIndex = 8;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(319, 181);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(188, 20);
            this.phoneNumber.TabIndex = 9;
            // 
            // rentDate
            // 
            this.rentDate.Location = new System.Drawing.Point(319, 229);
            this.rentDate.Name = "rentDate";
            this.rentDate.Size = new System.Drawing.Size(188, 20);
            this.rentDate.TabIndex = 10;
            // 
            // returnDate
            // 
            this.returnDate.Location = new System.Drawing.Point(319, 279);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(188, 20);
            this.returnDate.TabIndex = 11;
            // 
            // rent
            // 
            this.rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rent.Location = new System.Drawing.Point(132, 392);
            this.rent.Name = "rent";
            this.rent.Size = new System.Drawing.Size(135, 52);
            this.rent.TabIndex = 12;
            this.rent.Text = "Rent Car";
            this.rent.UseVisualStyleBackColor = true;
            this.rent.Click += new System.EventHandler(this.rent_Click);
            // 
            // cancelRent
            // 
            this.cancelRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelRent.Location = new System.Drawing.Point(424, 392);
            this.cancelRent.Name = "cancelRent";
            this.cancelRent.Size = new System.Drawing.Size(135, 52);
            this.cancelRent.TabIndex = 13;
            this.cancelRent.Text = "Cancel";
            this.cancelRent.UseVisualStyleBackColor = true;
            this.cancelRent.Click += new System.EventHandler(this.cancelRent_Click);
            // 
            // info
            // 
            this.info.Controls.Add(this.goLast);
            this.info.Controls.Add(this.goPrevious);
            this.info.Controls.Add(this.goNext);
            this.info.Controls.Add(this.goFirst);
            this.info.Controls.Add(this.caravailability);
            this.info.Controls.Add(this.label27);
            this.info.Controls.Add(this.modifyDelete);
            this.info.Controls.Add(this.cancel);
            this.info.Controls.Add(this.chose);
            this.info.Controls.Add(this.carNum);
            this.info.Controls.Add(this.carprice);
            this.info.Controls.Add(this.carvin);
            this.info.Controls.Add(this.carColor);
            this.info.Controls.Add(this.cartype);
            this.info.Controls.Add(this.carmake);
            this.info.Controls.Add(this.carmodel);
            this.info.Controls.Add(this.carname);
            this.info.Controls.Add(this.label14);
            this.info.Controls.Add(this.label8);
            this.info.Controls.Add(this.label6);
            this.info.Controls.Add(this.label5);
            this.info.Controls.Add(this.label4);
            this.info.Controls.Add(this.label3);
            this.info.Controls.Add(this.label2);
            this.info.Controls.Add(this.label1);
            this.info.Location = new System.Drawing.Point(4, 22);
            this.info.Name = "info";
            this.info.Padding = new System.Windows.Forms.Padding(3);
            this.info.Size = new System.Drawing.Size(711, 538);
            this.info.TabIndex = 1;
            this.info.Text = "Infomation";
            this.info.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Make";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "VIN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(103, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Price";
            // 
            // carname
            // 
            this.carname.Location = new System.Drawing.Point(273, 104);
            this.carname.Name = "carname";
            this.carname.Size = new System.Drawing.Size(153, 20);
            this.carname.TabIndex = 8;
            // 
            // carmodel
            // 
            this.carmodel.Location = new System.Drawing.Point(273, 152);
            this.carmodel.Name = "carmodel";
            this.carmodel.Size = new System.Drawing.Size(153, 20);
            this.carmodel.TabIndex = 9;
            // 
            // carmake
            // 
            this.carmake.Location = new System.Drawing.Point(273, 198);
            this.carmake.Name = "carmake";
            this.carmake.Size = new System.Drawing.Size(153, 20);
            this.carmake.TabIndex = 10;
            // 
            // cartype
            // 
            this.cartype.Location = new System.Drawing.Point(273, 244);
            this.cartype.Name = "cartype";
            this.cartype.Size = new System.Drawing.Size(153, 20);
            this.cartype.TabIndex = 11;
            // 
            // carColor
            // 
            this.carColor.Location = new System.Drawing.Point(273, 286);
            this.carColor.Name = "carColor";
            this.carColor.Size = new System.Drawing.Size(153, 20);
            this.carColor.TabIndex = 12;
            // 
            // carvin
            // 
            this.carvin.Location = new System.Drawing.Point(273, 327);
            this.carvin.Name = "carvin";
            this.carvin.Size = new System.Drawing.Size(153, 20);
            this.carvin.TabIndex = 13;
            // 
            // carprice
            // 
            this.carprice.Location = new System.Drawing.Point(273, 365);
            this.carprice.Name = "carprice";
            this.carprice.Size = new System.Drawing.Size(153, 20);
            this.carprice.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(105, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "Car ID";
            // 
            // carNum
            // 
            this.carNum.Location = new System.Drawing.Point(273, 53);
            this.carNum.Name = "carNum";
            this.carNum.Size = new System.Drawing.Size(153, 20);
            this.carNum.TabIndex = 16;
            // 
            // chose
            // 
            this.chose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chose.Location = new System.Drawing.Point(306, 457);
            this.chose.Name = "chose";
            this.chose.Size = new System.Drawing.Size(120, 50);
            this.chose.TabIndex = 17;
            this.chose.Text = "Chose Car";
            this.chose.UseVisualStyleBackColor = true;
            this.chose.Click += new System.EventHandler(this.chose_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(494, 457);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(120, 50);
            this.cancel.TabIndex = 18;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.menu);
            this.tab.Controls.Add(this.info);
            this.tab.Controls.Add(this.customer);
            this.tab.Controls.Add(this.modify);
            this.tab.Controls.Add(this.returnCar);
            this.tab.Location = new System.Drawing.Point(0, -2);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(719, 564);
            this.tab.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(136, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Car ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(136, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 20);
            this.label16.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(136, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 20);
            this.label17.TabIndex = 2;
            this.label17.Text = "Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(136, 162);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 20);
            this.label18.TabIndex = 3;
            this.label18.Text = "Make";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(136, 209);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 20);
            this.label19.TabIndex = 4;
            this.label19.Text = "Model";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(136, 252);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 20);
            this.label20.TabIndex = 5;
            this.label20.Text = "Type";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(136, 300);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 20);
            this.label21.TabIndex = 6;
            this.label21.Text = "Color";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(136, 342);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 20);
            this.label22.TabIndex = 7;
            this.label22.Text = "VIN";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(136, 383);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 20);
            this.label23.TabIndex = 8;
            this.label23.Text = "Price";
            // 
            // modifyID
            // 
            this.modifyID.Location = new System.Drawing.Point(310, 71);
            this.modifyID.Name = "modifyID";
            this.modifyID.Size = new System.Drawing.Size(269, 20);
            this.modifyID.TabIndex = 9;
            // 
            // modifyName
            // 
            this.modifyName.Location = new System.Drawing.Point(310, 114);
            this.modifyName.Name = "modifyName";
            this.modifyName.Size = new System.Drawing.Size(269, 20);
            this.modifyName.TabIndex = 10;
            // 
            // modifyMake
            // 
            this.modifyMake.Location = new System.Drawing.Point(310, 162);
            this.modifyMake.Name = "modifyMake";
            this.modifyMake.Size = new System.Drawing.Size(269, 20);
            this.modifyMake.TabIndex = 11;
            // 
            // modifyModel
            // 
            this.modifyModel.Location = new System.Drawing.Point(310, 209);
            this.modifyModel.Name = "modifyModel";
            this.modifyModel.Size = new System.Drawing.Size(269, 20);
            this.modifyModel.TabIndex = 12;
            // 
            // modifyType
            // 
            this.modifyType.Location = new System.Drawing.Point(310, 252);
            this.modifyType.Name = "modifyType";
            this.modifyType.Size = new System.Drawing.Size(269, 20);
            this.modifyType.TabIndex = 13;
            // 
            // modifyColor
            // 
            this.modifyColor.Location = new System.Drawing.Point(310, 300);
            this.modifyColor.Name = "modifyColor";
            this.modifyColor.Size = new System.Drawing.Size(269, 20);
            this.modifyColor.TabIndex = 14;
            // 
            // modifyVIN
            // 
            this.modifyVIN.Location = new System.Drawing.Point(310, 342);
            this.modifyVIN.Name = "modifyVIN";
            this.modifyVIN.Size = new System.Drawing.Size(269, 20);
            this.modifyVIN.TabIndex = 15;
            // 
            // modifyPrice
            // 
            this.modifyPrice.Location = new System.Drawing.Point(310, 383);
            this.modifyPrice.Name = "modifyPrice";
            this.modifyPrice.Size = new System.Drawing.Size(269, 20);
            this.modifyPrice.TabIndex = 16;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(177, 446);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 54);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "Add Car";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(177, 446);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(120, 54);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Delete Car";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // returnCar
            // 
            this.returnCar.Controls.Add(this.cancelButton);
            this.returnCar.Controls.Add(this.returnButton);
            this.returnCar.Controls.Add(this.returnLastName);
            this.returnCar.Controls.Add(this.returnFirstName);
            this.returnCar.Controls.Add(this.returnID);
            this.returnCar.Controls.Add(this.label26);
            this.returnCar.Controls.Add(this.label25);
            this.returnCar.Controls.Add(this.label24);
            this.returnCar.Location = new System.Drawing.Point(4, 22);
            this.returnCar.Name = "returnCar";
            this.returnCar.Size = new System.Drawing.Size(711, 538);
            this.returnCar.TabIndex = 4;
            this.returnCar.Text = "Return";
            this.returnCar.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(170, 95);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 20);
            this.label24.TabIndex = 0;
            this.label24.Text = "Car ID";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(170, 146);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(96, 20);
            this.label25.TabIndex = 1;
            this.label25.Text = "First Name";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(170, 208);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(95, 20);
            this.label26.TabIndex = 2;
            this.label26.Text = "Last Name";
            // 
            // returnID
            // 
            this.returnID.Location = new System.Drawing.Point(357, 95);
            this.returnID.Name = "returnID";
            this.returnID.Size = new System.Drawing.Size(216, 20);
            this.returnID.TabIndex = 3;
            // 
            // returnFirstName
            // 
            this.returnFirstName.Location = new System.Drawing.Point(357, 146);
            this.returnFirstName.Name = "returnFirstName";
            this.returnFirstName.Size = new System.Drawing.Size(216, 20);
            this.returnFirstName.TabIndex = 4;
            // 
            // returnLastName
            // 
            this.returnLastName.Location = new System.Drawing.Point(357, 208);
            this.returnLastName.Name = "returnLastName";
            this.returnLastName.Size = new System.Drawing.Size(216, 20);
            this.returnLastName.TabIndex = 5;
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(225, 307);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(297, 102);
            this.returnButton.TabIndex = 6;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // cancelModifyButton
            // 
            this.cancelModifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelModifyButton.Location = new System.Drawing.Point(459, 446);
            this.cancelModifyButton.Name = "cancelModifyButton";
            this.cancelModifyButton.Size = new System.Drawing.Size(120, 54);
            this.cancelModifyButton.TabIndex = 19;
            this.cancelModifyButton.Text = "Cancel";
            this.cancelModifyButton.UseVisualStyleBackColor = true;
            this.cancelModifyButton.Click += new System.EventHandler(this.cancelModifyButton_Click);
            // 
            // modifyDelete
            // 
            this.modifyDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyDelete.Location = new System.Drawing.Point(142, 457);
            this.modifyDelete.Name = "modifyDelete";
            this.modifyDelete.Size = new System.Drawing.Size(120, 50);
            this.modifyDelete.TabIndex = 19;
            this.modifyDelete.Text = "Delete Car";
            this.modifyDelete.UseVisualStyleBackColor = true;
            this.modifyDelete.Click += new System.EventHandler(this.modifyDelete_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(321, 439);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(92, 38);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(101, 410);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(93, 20);
            this.label27.TabIndex = 20;
            this.label27.Text = "Availability";
            // 
            // caravailability
            // 
            this.caravailability.Location = new System.Drawing.Point(273, 410);
            this.caravailability.Name = "caravailability";
            this.caravailability.Size = new System.Drawing.Size(153, 20);
            this.caravailability.TabIndex = 21;
            // 
            // menu
            // 
            this.menu.Controls.Add(this.button3);
            this.menu.Controls.Add(this.button2);
            this.menu.Controls.Add(this.button1);
            this.menu.Location = new System.Drawing.Point(4, 22);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(711, 538);
            this.menu.TabIndex = 5;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(213, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 93);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Car";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(213, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 93);
            this.button2.TabIndex = 1;
            this.button2.Text = "Return Car";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(213, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 93);
            this.button3.TabIndex = 2;
            this.button3.Text = "Available Car";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // goFirst
            // 
            this.goFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goFirst.Location = new System.Drawing.Point(514, 74);
            this.goFirst.Name = "goFirst";
            this.goFirst.Size = new System.Drawing.Size(132, 50);
            this.goFirst.TabIndex = 22;
            this.goFirst.Text = "Go First";
            this.goFirst.UseVisualStyleBackColor = true;
            this.goFirst.Click += new System.EventHandler(this.goFirst_Click);
            // 
            // goNext
            // 
            this.goNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goNext.Location = new System.Drawing.Point(514, 152);
            this.goNext.Name = "goNext";
            this.goNext.Size = new System.Drawing.Size(132, 50);
            this.goNext.TabIndex = 23;
            this.goNext.Text = "Go Next";
            this.goNext.UseVisualStyleBackColor = true;
            this.goNext.Click += new System.EventHandler(this.goNext_Click);
            // 
            // goPrevious
            // 
            this.goPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goPrevious.Location = new System.Drawing.Point(514, 228);
            this.goPrevious.Name = "goPrevious";
            this.goPrevious.Size = new System.Drawing.Size(132, 50);
            this.goPrevious.TabIndex = 24;
            this.goPrevious.Text = "Go Previous";
            this.goPrevious.UseVisualStyleBackColor = true;
            this.goPrevious.Click += new System.EventHandler(this.goPrevious_Click);
            // 
            // goLast
            // 
            this.goLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goLast.Location = new System.Drawing.Point(514, 309);
            this.goLast.Name = "goLast";
            this.goLast.Size = new System.Drawing.Size(132, 50);
            this.goLast.TabIndex = 25;
            this.goLast.Text = "Go Last";
            this.goLast.UseVisualStyleBackColor = true;
            this.goLast.Click += new System.EventHandler(this.goLast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 565);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.modify.ResumeLayout(false);
            this.modify.PerformLayout();
            this.customer.ResumeLayout(false);
            this.customer.PerformLayout();
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            this.tab.ResumeLayout(false);
            this.returnCar.ResumeLayout(false);
            this.returnCar.PerformLayout();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage modify;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage customer;
        private System.Windows.Forms.Button cancelRent;
        private System.Windows.Forms.Button rent;
        private System.Windows.Forms.TextBox returnDate;
        private System.Windows.Forms.TextBox rentDate;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox carID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage info;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button chose;
        private System.Windows.Forms.TextBox carNum;
        private System.Windows.Forms.TextBox carprice;
        private System.Windows.Forms.TextBox carvin;
        private System.Windows.Forms.TextBox carColor;
        private System.Windows.Forms.TextBox cartype;
        private System.Windows.Forms.TextBox carmake;
        private System.Windows.Forms.TextBox carmodel;
        private System.Windows.Forms.TextBox carname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TextBox modifyPrice;
        private System.Windows.Forms.TextBox modifyVIN;
        private System.Windows.Forms.TextBox modifyColor;
        private System.Windows.Forms.TextBox modifyType;
        private System.Windows.Forms.TextBox modifyModel;
        private System.Windows.Forms.TextBox modifyMake;
        private System.Windows.Forms.TextBox modifyName;
        private System.Windows.Forms.TextBox modifyID;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TabPage returnCar;
        private System.Windows.Forms.TextBox returnLastName;
        private System.Windows.Forms.TextBox returnFirstName;
        private System.Windows.Forms.TextBox returnID;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button cancelModifyButton;
        private System.Windows.Forms.Button modifyDelete;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox caravailability;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TabPage menu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button goLast;
        private System.Windows.Forms.Button goPrevious;
        private System.Windows.Forms.Button goNext;
        private System.Windows.Forms.Button goFirst;

    }
}

