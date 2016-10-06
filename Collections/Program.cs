using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            CompareCollection.AddToList();
            CompareCollection.AddToLinkedList();
            CompareCollection.AddToDictionary();
            CompareCollection.AddToQueue();
            CompareCollection.AddToStack();
            CompareCollection.AddToSortedSet();
            CompareCollection.AddToSortedDictionary();
            CompareCollection.GetFromList();
            CompareCollection.GetFromLinkedList();
            CompareCollection.GetFromDictionary();
            CompareCollection.GetFromQueue();
            CompareCollection.GetFromStack();
            CompareCollection.GetFromSortedSet();
            CompareCollection.GetFromSortedDictionary();
            CompareCollection.RemoveFromList();
            CompareCollection.RemoveFromLinkedList();
            CompareCollection.RemoveFromDictionary();
            CompareCollection.RemoveFromQueue();
            CompareCollection.RemoveFromStack();
            CompareCollection.RemoveFromSortedSet();
            CompareCollection.RemoveFromSortedDictionary();
            CompareCollection.WriteToFile();
            List<BigInteger> list = LINQ.FillList(200);
            Console.WriteLine("Quantity of simple number " + LINQ.GetSimpleNumber(list));


            Console.WriteLine("Quantity of number div on sum: " + LINQ.GetDivOnSum(list));
            var var1 = LINQ.DivByFive(list);
            var var2 = LINQ.IsContainTwo(list);
            var var3 = LINQ.SortBySecondNumber(list);
            var var4 = LINQ.MaxPow(list);
            Console.WriteLine(var4);
            var var5 = LINQ.AverageNullInNumber(list);
            Console.WriteLine(var5);


            ////foreach (var item in var3)
            ////{
            ////    Console.WriteLine(item);
            ////}
            ////foreach (var item in list)
            ////{
            ////    Console.WriteLine(item);
            ////}

            LinqXml lx = new LinqXml();
            //lx.CustomersOrderSum(10000);
            //lx.GroupByCountry();
            lx.CustomersOrderMoreThen(1000);
            Console.ReadLine();
        }
    }
}
