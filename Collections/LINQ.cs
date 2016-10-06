using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Collections
{
    static class LINQ
    {
        //public static List<BigInteger> list = new List<BigInteger>();

        public static List<BigInteger> FillList(int n)
        {
            List<BigInteger> list = new List<BigInteger>();
            BigInteger first = 0;
            BigInteger second = 1;
            BigInteger third = 0;
            n = n - 2;
            list.Add(first);
            list.Add(second);
            while (n!=0)
            {

                third = first + second;
                list.Add(third);
                first = second;
                second = third;
                n--;
            }

            return list;
        }

        public static int GetSimpleNumber(List<BigInteger> list)
        {
            int count = 0;
            for (int i = 3; i < list.Count; i++)
            {
                if (IsSimpleNumber(list[i]))
                {
                    count++;
                }
            }
            return count;
        }

        public static bool IsSimpleNumber(this BigInteger a)
        {
            bool prost = true;
            for (BigInteger i = 2; i < a; i++)
            {
                if ((a % i == 0))
                {
                    prost = false;
                    break;
                }
            }
            return prost;
        }

        public static bool DivOnSum(this BigInteger a)
        {
            bool div = false;
            var s = a.ToString();
            BigInteger sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sum += BigInteger.Parse(s.Substring(i,1));
            }
            if ((a%sum)==0)
            {
                div = true;
            }

            return div;
        }

        public static int GetDivOnSum(List<BigInteger> list)
        {
            int count = 0;
            for (int i = 1; i < list.Count; i++)
            {
                if (DivOnSum(list[i]))
                {
                    count++;
                    Console.WriteLine(list[i]);
                }
            }
            return count;
        }

        public static List<BigInteger> DivByFive(List<BigInteger> list)
        {
            var var = list.Where(x=>((x % 5)==0)).ToList();
            return var;
        }

        public static List<BigInteger> IsContainTwo(List<BigInteger> list)
        {
            var var = list.Where(x => (x.ToString().Contains("2")))
                          .Select(x => (BigInteger)Math.Sqrt((double)x))
                          .ToList();
            return var;
        }

        public static List<BigInteger> SortBySecondNumber(List<BigInteger> list)
        {
            var var = list.OrderByDescending(x => x)
                          .Where(x => x.ToString().Length > 1)
                          .OrderByDescending(x => x.ToString().Substring(1, 1))
                          .ToList();
            return var;
        }

        public static BigInteger MaxPow(List<BigInteger> list)
        {
            BigInteger pow;
            BigInteger max = 0;
            BigInteger value = 0;
            for (int i = 0; i < list.Count; i++)
            {
                var s = list[i].ToString();
                pow = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    pow += (BigInteger.Parse(s.Substring(j, 1)))* (BigInteger.Parse(s.Substring(j, 1)));
                }
                if (pow>max)
                {
                    max = pow;
                    value = list[i];
                }
               
            }
            return value;

        }

        public static double AverageNullInNumber(List<BigInteger> list)
        {
            int quantityOfNull = 0;
            for (int i = 0; i < list.Count; i++)
            {
                var s = list[i].ToString();
                for (int j = 0; j < s.Length; j++)
                {
                    if (s.Substring(j,1).Equals("0"))
                    {
                        quantityOfNull++;
                    }
                    
                }
            }

            return (double)quantityOfNull/list.Count;
        }


    }
}
