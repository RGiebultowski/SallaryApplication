using System;

namespace bossAplication
{
    class Person
    {
        protected int id;
        protected string name;
        protected string surname;
        protected int age;

        public Person(int id, string name, string surname, int age)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
    }


    class Employee : Person
    {
        public static int HolidayBonus { get; } = 1000;

        public struct Salary
        {
            public decimal salary;
            public decimal basic;
            public decimal bonus;
            public decimal other;
        }

        protected Salary _salary;

        public Employee(int id, string name, string surname, int age, Salary salary, ContractType contract) : base(id, name,
            surname, age)
        {
            _salary = salary;
            Contract = contract;
        }

        public enum ContractType
        {
            FullTime,
            PartTime,
            Contract,
        }

        public ContractType Contract { get; protected set; }
    }

    class Operation
    {
        public enum OperationType
        {
            Transfer,
            Request,
            Correction,
        }

        public Operation(DateTime timestamp, string title, Operation linkedOperation, Employee employee, string details,
            OperationType type)
        {
            Timestamp = timestamp;
            Title = title;
            LinkedOperation = linkedOperation;
            Employee = employee;
            Details = details;
            Type = type;
        }

        public DateTime Timestamp { get; protected set; } //date time of operation
        public string Title { get; protected set; } //title operation
        public Operation LinkedOperation { get; protected set; } //main operation or corrected operation
        public Employee Employee { get; protected set; } // person who made this operation
        public string Details { get; protected set; }
        public OperationType Type { get; protected set; }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}