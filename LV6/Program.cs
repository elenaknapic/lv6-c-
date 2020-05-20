using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Z1.
            //Notebook notebook = new Notebook();
            //Note note1 = new Note("Zabilješka", "Rampage");
            //Note note2 = new Note("Add note", "Chroma");
            //Note note3 = new Note("Add another note", "Nvidia geforce");

            //notebook.AddNote(note1);
            //notebook.AddNote(note2);
            //notebook.AddNote(note3);

            //Iterator iterator = (Iterator)notebook.GetIterator();

            //for (int i = 0; i < notebook.Count; i++)
            //{
            //    iterator.Current.Show();
            //    iterator.Next();
            //}
            //Console.WriteLine("\n");

            //Z2.
            //    Box box = new Box();
            //    Product product1 = new Product("Product1", 2);
            //    Product product2 = new Product("Product2", 9);
            //    Product product3 = new Product("Product3", 18);

            //    box.AddProduct(product1);
            //    box.AddProduct(product2);
            //    box.AddProduct(product3);

            //    BoxIterator boxIterator = (BoxIterator)box.GetIterator();

            //    for (int i = 0; i < box.Count; i++)
            //    {
            //        Console.WriteLine(boxIterator.Current);
            //        boxIterator.Next();
            //    }

            //    Console.WriteLine("\n");

            //}

            //Z3
            //var datum = new DateTime(2018, 8, 27, 11, 3, 3);
            //ToDoItem item = new ToDoItem("to do", "just do it", datum);
            //Console.WriteLine(item.ToString());
            //CareTaker care = new CareTaker();
            //care.PushStack(item.StoreState());
            //item.Rename("item");
            //item.ChangeTask("change task");
            //Console.WriteLine(item.ToString());
            //item.RestoreState(care.PopStack());
            //Console.WriteLine(item.ToString());


            //Z4
            //BankAccount bank = new BankAccount("Knapic", "Slatina", 19827728);
            //BankAccountMemento bankMemento = bank.StoreState();
            //Console.WriteLine("Balance: " + bank.Balance);
            //bank.UpdateBalance(-500);
            //Console.WriteLine("Balance: " + bank.Balance);
            //bank.RestoreState(bankMemento);
            //Console.WriteLine("Balance: " + bank.Balance);

            //Console.WriteLine("\n");

            //Z5.
            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger = new FileLogger(MessageType.ERROR | MessageType.WARNING, "dat.txt");
            logger.SetNextLogger(fileLogger);

            logger.Log("INFO", MessageType.INFO);
            logger.Log("ERROR", MessageType.ERROR);
            logger.Log("WARNING", MessageType.WARNING);




        }
    }
}
