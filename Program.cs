using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker();
            worker1.Name = "Dido";
            worker1.LastName = "Hello";
            worker1.No = 4;
            worker1.Department = "IT";
            worker1.InformationOfWorkers();
            Console.WriteLine("--------------------");
            Worker worker2 =new Worker("Dilay","Hi");
            worker2.InformationOfWorkers();
        }
    }
    class Worker
    {
        public string Name;
        public string LastName;
        public int No;
        public string Department;

    public Worker(){}
    public Worker(string name, string lastName)
    {
        this.Name = name;
        this.LastName = lastName;
    }

    public void InformationOfWorkers()
    {
        Console.WriteLine("Worker's name:{0}",Name);
        Console.WriteLine("Worker's last name:{0}",LastName);
        Console.WriteLine("Worker's number:{0}",No);
        Console.WriteLine("Worker's department:{0}",Department);
    }
}
}