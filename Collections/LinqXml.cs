using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Collections
{
    class LinqXml
    {
        static string fileName = @"D:\Yauheniy_Kisialiou\Task5\Customers.xml";
        XDocument xDoc = XDocument.Load(fileName);

        public void CustomersOrderSum(int n)
        {
            var a = xDoc.Elements("customers")
                        .Elements("customer")
                        .Select(x => new
                        {
                            name = x.Element("name").Value,
                            sum = x.Elements("orders").Elements("order").Elements("total")
                            .Select(y => double.Parse(y.Value)).Sum()
                        }
                        ).Where(x => x.sum > n);

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }

        public void GroupByCountry()
        {
            var a = xDoc.Elements("customers")
                        .Elements("customer")
                        .Select(x => new
                        {
                            name = x.Element("name").Value,
                            country = x.Element("country").Value
                        }).GroupBy(x => x.country);
                        

            foreach (var item in a)
            {
                Console.WriteLine(item);
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2);
                }
            }
        }

        public void CustomersOrderMoreThen(int n)
        {
            var a = xDoc.Elements("customers")
                        .Elements("customer")
                        .Select(x => new
                        {
                            name = x.Element("name").Value,
                            order = x.Elements("orders").Elements("order")
                            .Select(y => double.Parse(y.Element("total").Value)>n)
                        }
                        );

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
