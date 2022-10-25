using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_5
{
    public abstract class Operations
    {

        public abstract void displayBalance();
        public abstract int replenishment(int amount);
        public abstract int takeoff(int amount);

    }
    public class Check : Operations
    {
        public int balance { get; set; }
        public bool blocked
        {
            get; set;
        }

        virtual public string name { get; set; }

        override public int replenishment(int amount)
        {
            balance = +amount;
            return balance;
        }
        override public int takeoff(int amount)
        {
            balance = -amount;
            return balance;
        }

        override public void displayBalance() { Console.WriteLine($"Баланс равен: {balance}"); }
        public Check(string name, int balance, bool blocked)
        {
            this.name = name;
            this.balance = balance;
            this.blocked = blocked;
        }
        public override string ToString()
        {
            return $"Type is Check ;Name :{name};balance {balance},blocked-status: {blocked}";
        }
    }
    public class Currency : Check
    {
        public Currency(string name, int balance, bool blocked) : base(name, balance, blocked) { }
        public override string name { get => "Валюта"; }
        public override string ToString()
        {
            return $"Type is Currency;Name :{name};balance {balance},blocked-status: {blocked}";
        }

    }
    public class Accumulative : Check, IData
    {
        public string Data { get; set; }
        public long Password { get; set; }
        void IData.displayBalance()
        {

            Console.WriteLine($"Банковские данные о балансе: {balance}");

        }
        public override void displayBalance()
        {

            Console.WriteLine($"Баланс равен: {balance}");

        }
        public Accumulative(string name, int balance, bool blocked) : base(name, balance, blocked) { }
        public override string name { get => "Накопительный"; }
        public override string ToString()
        {
            return $"Type is Accumulative;Name :{name};balance {balance},blocked-status: {blocked}";
        }

    }
    public sealed class Estimated : Check
    {
        public Estimated(string name, int balance, bool blocked) : base(name, balance, blocked) { }
        public override string name { get => "Расчетный"; }
        public override string ToString()
        {
            return $"Type is Estimated;Name :{name};balance {balance},blocked-status: {blocked}";
        }
    }
    public class General : Check
    {
        public General(string name, int balance, bool blocked) : base(name, balance, blocked) { }
        public override string name { get => "Общий"; }
        public override string ToString()
        {
            return $"Type is General;Name :{name};balance {balance} ,blocked-status: {blocked}";
        }

    }
    public partial class Person
    {
        int ID;
        public Person(string Name)
        {
            this.Name = Name;
            ID = GetHashCode();
        }
        public override string ToString()
        {
            return $"Type is Person ;Id: {ID}; Name :{Name} ";
        }
    }
    public class Client : Person
    {
        long ID;
        public int amountOfCards;
        public Client(string Name) : base(Name) { ID = GetHashCode(); }
        public override string ToString()
        {
            return $"Type is Client ;amountOfCards: {amountOfCards}; Name :{Name} ";
        }

    }
    public class Card : IData
    {
        public int balance { get; set; }
        public bool blocked
        {
            get; set;
        }

        public string name { get; set; }
        public string Data { get; set; }
        public long Password { get; set; }
        public void displayBalance()
        {

            Console.WriteLine($"Банковские данные о балансе: {balance}");

        }
        public override string ToString()
        {
            return $"Type is {GetType};balance: {balance}; name :{name}; Password:{Password}; ";
        }
    }
    public struct Adress
    {
        public string adres { get; set; }
        public int nums { get; set; }
        public void infoadd(string adres, int nums)
        {
            Console.WriteLine($"Вот ваш адрес: {adres},{nums} ");
        }

    }
}
