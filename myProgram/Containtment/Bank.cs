using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Containtment
{

    class Account
    {
        double balance;

        public double Balance

        {

            get { return balance; }

            set { balance = value; }

        }
    }
    class Bank
    {
        int accountno;
        string name;
        string branch;
        Account acc;

        public int Accountno
        {
            get { return accountno; }
            set { accountno = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Branch
        {
            get { return branch; }
            set { branch = value; }

        }

        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }

        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.Accountno = 325831803;
            b.Name = "SBI";
            b.Branch = "Pune";
            b.Acc = new Account();
            b.Acc.Balance = 14500.20;


            Console.WriteLine(b.Accountno+" "+b.Name+" "+b.Branch+" "+b.Acc.Balance+" ");
            
        }
    }




    //class Account
    //{
    //    double balance;

    //    public double Balance

    //    {

    //        get { return balance; }

    //        set { balance = value; }

    //    }
    //}
    //class Bank
    //{
    //    int accountno;
    //    string name;
    //    string branch;
    //    Account acc;

    //    public int Accountno
    //    {
    //        get { return accountno; }
    //        set { accountno = value; }
    //    }

    //    public string Name
    //    {
    //        get { return name; }
    //        set { name = value; }
    //    }

    //    public string Branch
    //    {
    //        get { return branch; }
    //        set { branch = value; }

    //    }

    //    public Account Acc
    //    {
    //        get { return acc; }
    //        set { acc = value; }
    //    }

    //    static void Main(string[] args)
    //    {
    //        Bank b = new Bank();
    //        b.Accountno = 325831803;
    //        b.Name = "SBI";
    //        b.Branch = "Pune";
    //        b.Acc = new Account();
    //        b.Acc.Balance = 14500.20;


    //        Console.WriteLine(b.Accountno + " " + b.Name + " " + b.Branch + " " + b.Acc.Balance + " ");

    //    }
    //}


    //class Account
    //{
    //    double balance;

    //    public double Balance

    //    {

    //        get { return balance; }

    //        set { balance = value; }

    //    }
    //}
    //class Bank
    //{
    //    int accountno;
    //    string name;
    //    string branch;
    //    Account acc;

    //    public int Accountno
    //    {
    //        get { return accountno; }
    //        set { accountno = value; }
    //    }

    //    public string Name
    //    {
    //        get { return name; }
    //        set { name = value; }
    //    }

    //    public string Branch
    //    {
    //        get { return branch; }
    //        set { branch = value; }

    //    }

    //    public Account Acc
    //    {
    //        get { return acc; }
    //        set { acc = value; }
    //    }

    //    static void Main(string[] args)
    //    {
    //        Bank b = new Bank();
    //        b.Accountno = 325831803;
    //        b.Name = "SBI";
    //        b.Branch = "Pune";
    //        b.Acc = new Account();
    //        b.Acc.Balance = 14500.20;


    //        Console.WriteLine(b.Accountno + " " + b.Name + " " + b.Branch + " " + b.Acc.Balance + " ");

    //    }
    //}

}
