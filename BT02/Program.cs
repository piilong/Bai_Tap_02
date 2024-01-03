using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap2
{
    class Account
    {
        private string id;
        private string name;
        private int balance;
        public Account(string id, string name, int balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }
        public string getID()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public int getBalance()
        {
            return balance;
        }
        public void credit(int acmount)
        {
            if (acmount > 0)
                balance += acmount;
        }
        public void debit(int acmount)
        {
            if (acmount <= 0)
                balance -= acmount;
            else
                Console.WriteLine("so tien vuot qua so du. rut tien khong thanh cong");
        }
        public void tranfeto(Account acc, int acmount)
        {
            if (acmount <= balance)
            {
                balance -= acmount;
                acc.balance += acmount;
            }
            else
            {
                Console.WriteLine("so tien vuot so du. chuyen khoan khong thanh cong");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account my = new Account("900111", "Le Van Tri", 600);
            Account myFriend = new Account("900112", "Le Van Dat", 30);
            Console.WriteLine("---Thong tin tai khoan ban dau---");
            Console.WriteLine("My Account:[id;{0},name: {1},balance: {2}",
                my.getID(), my.getName(), my.getBalance());
            Console.WriteLine("My Friend Account:[id;{0},name: {1},balance: {2}",
                myFriend.getID(), myFriend.getName(), myFriend.getBalance());
            //rut tien
            my.debit(200);
            my.tranfeto(myFriend, 450);
            //ket qua sau khi thuc hien mot so hanh vi(nap,rut,chuyen khoan)
            Console.WriteLine("---Thong tin 2 tai khoan ban dau---");
            Console.WriteLine("My Account:[id;{0},name: {1},balance: {2}",
                my.getID(), my.getName(), my.getBalance());
            Console.WriteLine("My Friend Account:[id;{0},name: {1},balance: {2}",
                myFriend.getID(), myFriend.getName(), myFriend.getBalance());
            Console.ReadLine();
        }
    }
}