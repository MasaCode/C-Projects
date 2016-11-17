namespace BankSimulator
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.login = new System.Windows.Forms.TabPage();
            this.see = new System.Windows.Forms.CheckBox();
            this.create = new System.Windows.Forms.Button();
            this.go = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userID = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.transbutton = new System.Windows.Forms.Button();
            this.branchbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Limitbox = new System.Windows.Forms.TextBox();
            this.AccountTypebox = new System.Windows.Forms.TextBox();
            this.Balancebox = new System.Windows.Forms.TextBox();
            this.AccountNumbox = new System.Windows.Forms.TextBox();
            this.Passbox = new System.Windows.Forms.TextBox();
            this.IDbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.transcript = new System.Windows.Forms.TabPage();
            this.branchnumbox = new System.Windows.Forms.TextBox();
            this.typebox = new System.Windows.Forms.TextBox();
            this.numbox = new System.Windows.Forms.TextBox();
            this.amountbox = new System.Windows.Forms.TextBox();
            this.timebox = new System.Windows.Forms.TextBox();
            this.datebox = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.createAccount = new System.Windows.Forms.TabPage();
            this.cancelCreate = new System.Windows.Forms.Button();
            this.limitIN = new System.Windows.Forms.TextBox();
            this.branchIN = new System.Windows.Forms.TextBox();
            this.passIN = new System.Windows.Forms.TextBox();
            this.accountIN = new System.Windows.Forms.TextBox();
            this.typeIN = new System.Windows.Forms.TextBox();
            this.balanceIN = new System.Windows.Forms.TextBox();
            this.clientIN = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.login.SuspendLayout();
            this.info.SuspendLayout();
            this.transcript.SuspendLayout();
            this.createAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.login);
            this.tabControl1.Controls.Add(this.info);
            this.tabControl1.Controls.Add(this.transcript);
            this.tabControl1.Controls.Add(this.createAccount);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(583, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // login
            // 
            this.login.Controls.Add(this.see);
            this.login.Controls.Add(this.create);
            this.login.Controls.Add(this.go);
            this.login.Controls.Add(this.pass);
            this.login.Controls.Add(this.label2);
            this.login.Controls.Add(this.label1);
            this.login.Controls.Add(this.userID);
            this.login.Location = new System.Drawing.Point(4, 22);
            this.login.Name = "login";
            this.login.Padding = new System.Windows.Forms.Padding(3);
            this.login.Size = new System.Drawing.Size(575, 428);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            // 
            // see
            // 
            this.see.AutoSize = true;
            this.see.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.see.Location = new System.Drawing.Point(411, 195);
            this.see.Name = "see";
            this.see.Size = new System.Drawing.Size(110, 17);
            this.see.TabIndex = 6;
            this.see.Text = " See Password";
            this.see.UseVisualStyleBackColor = true;
            this.see.CheckedChanged += new System.EventHandler(this.see_CheckedChanged);
            // 
            // create
            // 
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.Location = new System.Drawing.Point(305, 301);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(123, 68);
            this.create.TabIndex = 5;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.cancel_Click);
            // 
            // go
            // 
            this.go.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go.Location = new System.Drawing.Point(135, 301);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(109, 68);
            this.go.TabIndex = 4;
            this.go.Text = "Login";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(305, 193);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(100, 20);
            this.pass.TabIndex = 3;
            this.pass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client ID";
            // 
            // userID
            // 
            this.userID.Location = new System.Drawing.Point(305, 127);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(100, 20);
            this.userID.TabIndex = 0;
            // 
            // info
            // 
            this.info.Controls.Add(this.button1);
            this.info.Controls.Add(this.transbutton);
            this.info.Controls.Add(this.branchbox);
            this.info.Controls.Add(this.label11);
            this.info.Controls.Add(this.Limitbox);
            this.info.Controls.Add(this.AccountTypebox);
            this.info.Controls.Add(this.Balancebox);
            this.info.Controls.Add(this.AccountNumbox);
            this.info.Controls.Add(this.Passbox);
            this.info.Controls.Add(this.IDbox);
            this.info.Controls.Add(this.label8);
            this.info.Controls.Add(this.label7);
            this.info.Controls.Add(this.label6);
            this.info.Controls.Add(this.label5);
            this.info.Controls.Add(this.label4);
            this.info.Controls.Add(this.label3);
            this.info.Location = new System.Drawing.Point(4, 22);
            this.info.Name = "info";
            this.info.Padding = new System.Windows.Forms.Padding(3);
            this.info.Size = new System.Drawing.Size(575, 428);
            this.info.TabIndex = 1;
            this.info.Text = "Account Info";
            this.info.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(323, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 52);
            this.button1.TabIndex = 15;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // transbutton
            // 
            this.transbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transbutton.Location = new System.Drawing.Point(108, 324);
            this.transbutton.Name = "transbutton";
            this.transbutton.Size = new System.Drawing.Size(133, 52);
            this.transbutton.TabIndex = 14;
            this.transbutton.Text = "Transaction";
            this.transbutton.UseVisualStyleBackColor = true;
            this.transbutton.Click += new System.EventHandler(this.transbutton_Click);
            // 
            // branchbox
            // 
            this.branchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchbox.Location = new System.Drawing.Point(284, 241);
            this.branchbox.Name = "branchbox";
            this.branchbox.Size = new System.Drawing.Size(189, 20);
            this.branchbox.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(61, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Branch Number";
            // 
            // Limitbox
            // 
            this.Limitbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limitbox.Location = new System.Drawing.Point(284, 202);
            this.Limitbox.Name = "Limitbox";
            this.Limitbox.Size = new System.Drawing.Size(189, 20);
            this.Limitbox.TabIndex = 11;
            // 
            // AccountTypebox
            // 
            this.AccountTypebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTypebox.Location = new System.Drawing.Point(284, 137);
            this.AccountTypebox.Name = "AccountTypebox";
            this.AccountTypebox.Size = new System.Drawing.Size(189, 20);
            this.AccountTypebox.TabIndex = 10;
            // 
            // Balancebox
            // 
            this.Balancebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balancebox.Location = new System.Drawing.Point(284, 169);
            this.Balancebox.Name = "Balancebox";
            this.Balancebox.Size = new System.Drawing.Size(189, 20);
            this.Balancebox.TabIndex = 9;
            // 
            // AccountNumbox
            // 
            this.AccountNumbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumbox.Location = new System.Drawing.Point(284, 105);
            this.AccountNumbox.Name = "AccountNumbox";
            this.AccountNumbox.Size = new System.Drawing.Size(189, 20);
            this.AccountNumbox.TabIndex = 8;
            // 
            // Passbox
            // 
            this.Passbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passbox.Location = new System.Drawing.Point(284, 76);
            this.Passbox.Name = "Passbox";
            this.Passbox.Size = new System.Drawing.Size(189, 20);
            this.Passbox.TabIndex = 7;
            // 
            // IDbox
            // 
            this.IDbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDbox.Location = new System.Drawing.Point(284, 47);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(189, 20);
            this.IDbox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Credit Limit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Balance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Account Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Account Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Client ID";
            // 
            // transcript
            // 
            this.transcript.Controls.Add(this.branchnumbox);
            this.transcript.Controls.Add(this.typebox);
            this.transcript.Controls.Add(this.numbox);
            this.transcript.Controls.Add(this.amountbox);
            this.transcript.Controls.Add(this.timebox);
            this.transcript.Controls.Add(this.datebox);
            this.transcript.Controls.Add(this.clear);
            this.transcript.Controls.Add(this.submit);
            this.transcript.Controls.Add(this.label15);
            this.transcript.Controls.Add(this.label14);
            this.transcript.Controls.Add(this.label13);
            this.transcript.Controls.Add(this.label12);
            this.transcript.Controls.Add(this.label10);
            this.transcript.Controls.Add(this.label9);
            this.transcript.Location = new System.Drawing.Point(4, 22);
            this.transcript.Name = "transcript";
            this.transcript.Size = new System.Drawing.Size(575, 428);
            this.transcript.TabIndex = 2;
            this.transcript.Text = "Transcript";
            this.transcript.UseVisualStyleBackColor = true;
            // 
            // branchnumbox
            // 
            this.branchnumbox.Location = new System.Drawing.Point(305, 254);
            this.branchnumbox.Name = "branchnumbox";
            this.branchnumbox.Size = new System.Drawing.Size(153, 20);
            this.branchnumbox.TabIndex = 13;
            // 
            // typebox
            // 
            this.typebox.Location = new System.Drawing.Point(305, 210);
            this.typebox.Name = "typebox";
            this.typebox.Size = new System.Drawing.Size(153, 20);
            this.typebox.TabIndex = 12;
            // 
            // numbox
            // 
            this.numbox.Location = new System.Drawing.Point(305, 168);
            this.numbox.Name = "numbox";
            this.numbox.Size = new System.Drawing.Size(153, 20);
            this.numbox.TabIndex = 11;
            // 
            // amountbox
            // 
            this.amountbox.Location = new System.Drawing.Point(305, 127);
            this.amountbox.Name = "amountbox";
            this.amountbox.Size = new System.Drawing.Size(153, 20);
            this.amountbox.TabIndex = 10;
            // 
            // timebox
            // 
            this.timebox.Location = new System.Drawing.Point(305, 89);
            this.timebox.Name = "timebox";
            this.timebox.Size = new System.Drawing.Size(153, 20);
            this.timebox.TabIndex = 9;
            // 
            // datebox
            // 
            this.datebox.Location = new System.Drawing.Point(305, 49);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(153, 20);
            this.datebox.TabIndex = 8;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(321, 332);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(106, 44);
            this.clear.TabIndex = 7;
            this.clear.Text = "Cancel";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(131, 332);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(106, 44);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(65, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(168, 24);
            this.label15.TabIndex = 5;
            this.label15.Text = "Account Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(65, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 24);
            this.label14.TabIndex = 4;
            this.label14.Text = "Amount";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(65, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 24);
            this.label13.TabIndex = 3;
            this.label13.Text = "Transaction Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(65, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 24);
            this.label12.TabIndex = 2;
            this.label12.Text = "BranchNumber";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(65, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Date";
            // 
            // createAccount
            // 
            this.createAccount.Controls.Add(this.cancelCreate);
            this.createAccount.Controls.Add(this.limitIN);
            this.createAccount.Controls.Add(this.branchIN);
            this.createAccount.Controls.Add(this.passIN);
            this.createAccount.Controls.Add(this.accountIN);
            this.createAccount.Controls.Add(this.typeIN);
            this.createAccount.Controls.Add(this.balanceIN);
            this.createAccount.Controls.Add(this.clientIN);
            this.createAccount.Controls.Add(this.createButton);
            this.createAccount.Controls.Add(this.label22);
            this.createAccount.Controls.Add(this.label21);
            this.createAccount.Controls.Add(this.label20);
            this.createAccount.Controls.Add(this.label19);
            this.createAccount.Controls.Add(this.label18);
            this.createAccount.Controls.Add(this.label17);
            this.createAccount.Controls.Add(this.label16);
            this.createAccount.Location = new System.Drawing.Point(4, 22);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(575, 428);
            this.createAccount.TabIndex = 3;
            this.createAccount.Text = "Create Account";
            this.createAccount.UseVisualStyleBackColor = true;
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // cancelCreate
            // 
            this.cancelCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelCreate.Location = new System.Drawing.Point(332, 356);
            this.cancelCreate.Name = "cancelCreate";
            this.cancelCreate.Size = new System.Drawing.Size(85, 42);
            this.cancelCreate.TabIndex = 15;
            this.cancelCreate.Text = "Cancel";
            this.cancelCreate.UseVisualStyleBackColor = true;
            this.cancelCreate.Click += new System.EventHandler(this.cancelCreate_Click);
            // 
            // limitIN
            // 
            this.limitIN.Location = new System.Drawing.Point(312, 257);
            this.limitIN.Name = "limitIN";
            this.limitIN.Size = new System.Drawing.Size(184, 20);
            this.limitIN.TabIndex = 14;
            // 
            // branchIN
            // 
            this.branchIN.Location = new System.Drawing.Point(312, 298);
            this.branchIN.Name = "branchIN";
            this.branchIN.Size = new System.Drawing.Size(184, 20);
            this.branchIN.TabIndex = 13;
            // 
            // passIN
            // 
            this.passIN.Location = new System.Drawing.Point(312, 95);
            this.passIN.Name = "passIN";
            this.passIN.Size = new System.Drawing.Size(184, 20);
            this.passIN.TabIndex = 12;
            // 
            // accountIN
            // 
            this.accountIN.Location = new System.Drawing.Point(312, 138);
            this.accountIN.Name = "accountIN";
            this.accountIN.Size = new System.Drawing.Size(184, 20);
            this.accountIN.TabIndex = 11;
            // 
            // typeIN
            // 
            this.typeIN.Location = new System.Drawing.Point(312, 173);
            this.typeIN.Name = "typeIN";
            this.typeIN.Size = new System.Drawing.Size(184, 20);
            this.typeIN.TabIndex = 10;
            // 
            // balanceIN
            // 
            this.balanceIN.Location = new System.Drawing.Point(312, 216);
            this.balanceIN.Name = "balanceIN";
            this.balanceIN.Size = new System.Drawing.Size(184, 20);
            this.balanceIN.TabIndex = 9;
            // 
            // clientIN
            // 
            this.clientIN.Location = new System.Drawing.Point(312, 60);
            this.clientIN.Name = "clientIN";
            this.clientIN.Size = new System.Drawing.Size(184, 20);
            this.clientIN.TabIndex = 8;
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(128, 356);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(85, 42);
            this.createButton.TabIndex = 7;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(78, 301);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(133, 20);
            this.label22.TabIndex = 6;
            this.label22.Text = "Branch Number";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(78, 260);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 20);
            this.label21.TabIndex = 5;
            this.label21.Text = "CreditLimit";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(78, 219);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 20);
            this.label20.TabIndex = 4;
            this.label20.Text = "Balance";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(78, 177);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(118, 20);
            this.label19.TabIndex = 3;
            this.label19.Text = "Account Type";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(78, 141);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(142, 20);
            this.label18.TabIndex = 2;
            this.label18.Text = "Account Number";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(78, 99);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Password";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(78, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Client ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            this.transcript.ResumeLayout(false);
            this.transcript.PerformLayout();
            this.createAccount.ResumeLayout(false);
            this.createAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage login;
        private System.Windows.Forms.TabPage info;
        private System.Windows.Forms.TabPage transcript;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.TextBox Limitbox;
        private System.Windows.Forms.TextBox AccountTypebox;
        private System.Windows.Forms.TextBox Balancebox;
        private System.Windows.Forms.TextBox AccountNumbox;
        private System.Windows.Forms.TextBox Passbox;
        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox branchbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox branchnumbox;
        private System.Windows.Forms.TextBox typebox;
        private System.Windows.Forms.TextBox numbox;
        private System.Windows.Forms.TextBox amountbox;
        private System.Windows.Forms.TextBox timebox;
        private System.Windows.Forms.TextBox datebox;
        private System.Windows.Forms.Button transbutton;
        private System.Windows.Forms.TabPage createAccount;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox limitIN;
        private System.Windows.Forms.TextBox branchIN;
        private System.Windows.Forms.TextBox passIN;
        private System.Windows.Forms.TextBox accountIN;
        private System.Windows.Forms.TextBox typeIN;
        private System.Windows.Forms.TextBox balanceIN;
        private System.Windows.Forms.TextBox clientIN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cancelCreate;
        private System.Windows.Forms.CheckBox see;
    }
}

