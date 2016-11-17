using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSimulator
{
    public partial class Form1 : Form
    {

        ADODB.Connection CnAccount;
        ADODB.Recordset RsUser;
        ADODB.Recordset RsAccount;
        ADODB.Connection CnTranscript;
        ADODB.Recordset RsTranscript;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CnAccount = new ADODB.Connection();
            RsUser = new ADODB.Recordset();
            RsAccount = new ADODB.Recordset();
            CnTranscript = new ADODB.Connection();
            RsTranscript = new ADODB.Recordset();
            String Sqlstr1;
            String Sqlstr2;
            String Sqlstr3;

            CnAccount.Provider = "Microsoft.Jet.Oledb.4.0";
            CnAccount.ConnectionString = "DataBase\\BankSimulator.mdb";
            //CnAccount.ConnectionString = "C:\\Users\\masashi\\Desktop\\BankSimulator\\DataBase\\BankSimulator.mdb";
            //CnAccount.ConnectionString = "C:\\Users\\masashi.morita\\Desktop\\BankSimulator\\DataBase\\BankSimulator.mdb";
            CnAccount.Open();

            CnTranscript.Provider = "Microsoft.Jet.Oledb.4.0";
            CnTranscript.ConnectionString = "DataBase\\Transcript.mdb";
            //CnTranscript.ConnectionString = "C:\\Users\\masashi\\Desktop\\BankSimulator\\DataBase\\Transcript.mdb";
            //CnTranscript.ConnectionString = "C:\\Users\\masashi.morita\\Desktop\\BankSimulator\\DataBase\\Transcript.mdb";
            CnTranscript.Open();


            Sqlstr1 = "select * from AccountHolder";
            Sqlstr2 = "select * from AccountInfo";
            Sqlstr3 = "select * from Transcript";

            RsAccount.Open(Sqlstr1, CnAccount, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
            RsUser.Open(Sqlstr2, CnAccount, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);
            RsTranscript.Open(Sqlstr3, CnTranscript, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic);

            RsUser.MoveFirst();
            RsAccount.MoveFirst();
            RsTranscript.MoveFirst();
            transcript.Parent = null;
            info.Parent = null;
            createAccount.Parent = null;
        }



        private Boolean Check(String pass, int ID)
        {
            RsUser.MoveFirst();
            while (!RsUser.EOF)
            {
                if((ID == RsUser.Fields["ClientID"].Value) && pass.Equals(RsUser.Fields["Password"].Value.ToString())) {
                    return true;
                }
                RsUser.MoveNext();
            }
            return false;
        }

        private void Show(int id)
        {
            while (!RsAccount.EOF)
            {
                if (id == RsAccount.Fields["ClientID"].Value)
                {
                    break;
                }
                RsAccount.MoveNext();
            }

            IDbox.Text = RsAccount.Fields["ClientID"].Value.ToString();
            Passbox.Text = RsUser.Fields["Password"].Value.ToString();
            AccountNumbox.Text = RsAccount.Fields["AccountNumber"].Value.ToString();
            AccountTypebox.Text = RsAccount.Fields["AccountType"].Value.ToString();
            Balancebox.Text = RsAccount.Fields["Balance"].Value.ToString();
            Limitbox.Text = RsAccount.Fields["CreditLimit"].Value.ToString();
            branchbox.Text = RsAccount.Fields["BranchNumber"].Value.ToString();

            IDbox.Enabled = false;
            Passbox.Enabled = false;
            AccountNumbox.Enabled = false;
            AccountTypebox.Enabled = false;
            Balancebox.Enabled = false;
            Limitbox.Enabled = false;
            branchbox.Enabled = false;
        }


        private void Show()
        {
            IDbox.Text = RsAccount.Fields["ClientID"].Value.ToString();
            Passbox.Text = RsUser.Fields["Password"].Value.ToString();
            AccountNumbox.Text = RsAccount.Fields["AccountNumber"].Value.ToString();
            AccountTypebox.Text = RsAccount.Fields["AccountType"].Value.ToString();
            Balancebox.Text = RsAccount.Fields["Balance"].Value.ToString();
            Limitbox.Text = RsAccount.Fields["CreditLimit"].Value.ToString();
            branchbox.Text = RsAccount.Fields["BranchNumber"].Value.ToString();

            IDbox.Enabled = false;
            Passbox.Enabled = false;
            AccountNumbox.Enabled = false;
            AccountTypebox.Enabled = false;
            Balancebox.Enabled = false;
            Limitbox.Enabled = false;
            branchbox.Enabled = false;
        }


        private void go_Click(object sender, EventArgs e)
        {
            Boolean tryLogin;
            int id;
            if (userID.Text.Equals("") || pass.Text.Equals(""))
            {
                MessageBox.Show("Please enter your Client ID and Password");
                userID.Clear();
                pass.Clear();
            }
            else
            {
                id = Convert.ToInt32(userID.Text);
                tryLogin = Check(pass.Text.ToString(), id);
                if (tryLogin == true)
                {
                    login.Parent = null;
                    createAccount.Parent = null;
                    info.Parent = tabControl1;

                    Show(id);
                }
                else
                {
                    MessageBox.Show("Wrong Infomation");
                    userID.Clear();
                    pass.Clear();
                }
            }
       }

        private void cancel_Click(object sender, EventArgs e)
        {
            login.Parent = null;
            createAccount.Parent = tabControl1;
            limitIN.Text = "1000";
            limitIN.Enabled = false;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Boolean flag = false;

            
            RsAccount.MoveFirst();
            if (amountbox.Text.Equals("") || numbox.Text.Equals("") || typebox.Text.Equals("") || branchnumbox.Text.Equals(""))
            {
                MessageBox.Show("Please enter full of your infomation.");
                Clear();
            }
            else
            {
                while (!RsAccount.EOF)
                {
                    if (Convert.ToInt32(numbox.Text) == RsAccount.Fields["AccountNumber"].Value && Convert.ToInt32(branchnumbox.Text) == RsAccount.Fields["BranchNumber"].Value)
                    {
                        flag = true;
                        break;
                    }
                    RsAccount.MoveNext();
                }
                if (flag == true)
                {



                    RsTranscript.AddNew();
                    RsTranscript.Fields["Date"].Value = datebox.Text;
                    RsTranscript.Fields["Time"].Value = timebox.Text;
                    RsTranscript.Fields["Amount"].Value = Convert.ToInt32(amountbox.Text);
                    RsTranscript.Fields["AccountNumber"].Value = Convert.ToInt32(numbox.Text);
                    RsTranscript.Fields["TransactionType"].Value = typebox.Text;
                    RsTranscript.Fields["BranchNumber"].Value = Convert.ToInt32(branchnumbox.Text);

                    if (typebox.Text.Equals("Deposit"))
                    {
                        int total = Convert.ToInt32(amountbox.Text) + RsAccount.Fields["Balance"].Value;
                        RsAccount.Fields["Balance"].Value = total;
                    }
                    else if (typebox.Text.Equals("Withdraw"))
                    {
                        int total = RsAccount.Fields["Balance"].Value - Convert.ToInt32(amountbox.Text);
                        RsAccount.Fields["Balance"].Value = total;
                    }
                    RsAccount.Update();
                    RsTranscript.Update();
                    MessageBox.Show("Your transaction completed successfully!!!!");
                    Show();
                    info.Parent = tabControl1;
                    transcript.Parent = null;
                    createAccount.Parent = null;

                }
                else
                {
                    MessageBox.Show("Your transaction faild....");
                    Clear();
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            login.Parent = null;
            transcript.Parent = null;
            createAccount.Parent = null;
            info.Parent = tabControl1;
        }

        private void Clear()
        {
            datebox.Clear();
            timebox.Clear();
            amountbox.Clear();
            numbox.Clear();
            typebox.Clear();
            branchnumbox.Clear();
        }

        private void transbutton_Click(object sender, EventArgs e)
        {
            transcript.Parent = tabControl1;
            info.Parent = null;
            DateTime today = DateTime.Now;
            String todate = today.ToShortDateString();
            datebox.Text = todate;
            timebox.Text = today.ToString("H:mm");
            datebox.Enabled = false;
            timebox.Enabled = false;


            

        }

        private void createAccount_Click(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {


            if (clientIN.Text.Equals("") || accountIN.Text.Equals("") || typeIN.Text.Equals("") || balanceIN.Text.Equals("") || limitIN.Text.Equals("") || branchIN.Text.Equals(""))
            {
                MessageBox.Show("Please enter full of your infomation.");
            }
            else
            {
                RsAccount.AddNew();
                RsUser.AddNew();
                RsUser.Fields["ClientID"].Value = clientIN.Text;
                RsUser.Fields["Password"].Value = passIN.Text;


                RsAccount.Fields["ClientID"].Value = Convert.ToInt32(clientIN.Text);
                RsAccount.Fields["AccountNumber"].Value = Convert.ToInt32(accountIN.Text);
                RsAccount.Fields["AccountType"].Value = typeIN.Text;
                RsAccount.Fields["Balance"].Value = Convert.ToInt32(balanceIN.Text);
                RsAccount.Fields["CreditLimit"].Value = Convert.ToInt32(limitIN.Text);
                RsAccount.Fields["BranchNumber"].Value = Convert.ToInt32(branchIN.Text);


                RsUser.Update();
                RsAccount.Update();
                Show();
                createAccount.Parent = null;
                login.Parent = tabControl1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login.Parent = tabControl1;
            transcript.Parent = null;
            createAccount.Parent = null;
            info.Parent = null;
            userID.Clear();
            pass.Clear();
        }

        private void cancelCreate_Click(object sender, EventArgs e)
        {
            login.Parent = tabControl1;
            info.Parent = null;
            createAccount.Parent = null;
            transcript.Parent = null;
            userID.Clear();
            pass.Clear();

        }

        private void see_CheckedChanged(object sender, EventArgs e)
        {
            if (see.Checked == true)
            {
                pass.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar = true;
            }
        }

       
    }
}
