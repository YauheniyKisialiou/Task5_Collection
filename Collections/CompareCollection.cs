using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Collections
{
    public static class CompareCollection
    {
        static string path = @"d:\TimeResult.txt";
        static List<string> resultList= new List<string>();
        public static TimeSpan GetTime(DateTime firstTime, DateTime secondTime)
        {
            return secondTime - firstTime;
        }

        public static void AddToList()
        {
            resultList.Add("Add:");
            List<int> list = new List<int>();

            for (int i = 0; i < 100000; i++)
            {
                list.Add(i);
            }
            DateTime nowTime1 = DateTime.Now;
            for (int i = 0; i < 5000; i++)
            {
                list.Insert(i, i);
            }
            
            DateTime nowTime2 = DateTime.Now;
            resultList.Add($"AddToList: {GetTime(nowTime1, nowTime2)}"); 
        }

        public static void AddToLinkedList()
        {
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i < 100000; i++)
            {
                list.AddLast(i);
            }
            DateTime nowTime1 = DateTime.Now;
            for (int i = 0; i < 5000; i++)
            {
                list.AddAfter(list.First, i);
            }
            
            DateTime nowTime2 = DateTime.Now;
            resultList.Add($"AddToLinkedList: {GetTime(nowTime1, nowTime2)}");
        }

        public static void AddToDictionary()
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            for (int i = 0; i < 100000; i++)
            {
                dic.Add($"{i}", i);
            }
            DateTime nowTime1 = DateTime.Now;
            for (int i = 0; i < 5000; i++)
            {
                dic.Add($"add{i}", i);
            }
            
            DateTime nowTime2 = DateTime.Now;
            resultList.Add($"AddToDictionary: {GetTime(nowTime1, nowTime2)}");
        }

        public static void AddToQueue()
        {
            Queue<int> q = new Queue<int>();
        
            for (int i = 0; i < 100000; i++)
            {
                q.Enqueue(i);
            }
            DateTime nowTime1 = DateTime.Now;
            for (int i = 0; i < 5000; i++)
            {
                q.Enqueue(i);
            }
            DateTime nowTime2 = DateTime.Now;
            resultList.Add($"AddToQueue: {GetTime(nowTime1, nowTime2)}");
        }

        public static void AddToStack()
        {
            Stack<int> s = new Stack<int>();

            for (int i = 0; i < 100000; i++)
            {
                s.Push(i);
            }
            DateTime nowTime1 = DateTime.Now;
            for (int i = 0; i < 5000; i++)
            {
                s.Push(i);
            }
            DateTime nowTime2 = DateTime.Now;
            resultList.Add($"AddToStack: {GetTime(nowTime1, nowTime2)}");
        }

        public static void AddToSortedSet()
        {
            SortedSet<int> ss = new SortedSet<int>();

            for (int i = 0; i < 100000; i++)
            {
                ss.Add(i);
            }
            DateTime nowTime1 = DateTime.Now;
            for (int i = 100000; i < 105000; i++)
            {
                ss.Add(i);
            }
            DateTime nowTime2 = DateTime.Now;
            resultList.Add($"AddToSortedSet: {GetTime(nowTime1, nowTime2)}");
        }

        public static void AddToSortedDictionary()
        {
            SortedDictionary<string, int> sdic = new SortedDictionary<string, int>();

            for (int i = 0; i < 100000; i++)
            {
                sdic.Add($"{i}", i);
            }
            DateTime nowTime1 = DateTime.Now;
            for (int i = 0; i < 5000; i++)
            {
                sdic.Add($"add{i}", i);
            }

            DateTime nowTime2 = DateTime.Now;
            resultList.Add($"AddToSortedDictionary: {GetTime(nowTime1, nowTime2)}");
        }

        //get elements
        
        

        public static void GetFromList()
        {
            resultList.Add("Get:");
            List<int> list = new List<int>();

            for (int i = 0; i < 100000; i++)
            {
                list.Add(i);
            }
            DateTime nowTime1 = DateTime.Now;
            for (int i = 5000; i < 10000; i++)
            {
                int a = list[i];
            }

            DateTime nowTime2 = DateTime.Now;
            resultList.Add($"GetFromList: {GetTime(nowTime1, nowTime2)}");
        }

        public static void GetFromLinkedList()
        {
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i < 100000; i++)
            {
                list.AddLast(i);
            }
            DateTime nowTime1 = DateTime.Now;
            for (int i = 5000; i < 10000; i++)
            {
                int a = list.ElementAt(i);
            }

            DateTime nowTime2 = DateTime.Now;
            resultList.Add($"GetFromLinkedList: {GetTime(nowTime1, nowTime2)}");
        }

        public static void GetFromDictionary()
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            for (int i = 0; i < 100000; i++)
            {
                dic.Add($"{i}", i);
            }
            DateTime nowTime1 = DateTime.Now;
            for (int i = 5000; i < 10000; i++)
            {
                
                var d = dic.ElementAt(i);
            }

            DateTime nowTime2 = DateTime.Now;
            resultList.Add($"GetFromDictionary: {GetTime(nowTime1, nowTime2)}");
        }

        public static void GetFromQueue()
        {
            Queue<int> q = new Queue<int>();

            for (int i = 0; i < 100000; i++)
            {
                q.Enqueue(i);
            }
            DateTime nowTime1 = DateTime.Now;
            for (int i = 0; i < 5000; i++)
            {
                q.Peek();
            }
            DateTime nowTime2 = DateTime.Now;
            resultList.Add($"GetFromQueue: {GetTime(nowTime1, nowTime2)}");
        }

        public static void GetFromStack()
        {
            Stack<int> s = new Stack<int>();

            for (int i = 0; i < 100000; i++)
            {
                s.Push(i);
            }
            DateTime nowTime1 = DateTime.Now;
            for (int i = 0; i < 5000; i++)
            {
                s.Peek();
            }
            DateTime nowTime2 = DateTime.Now;
            resultList.Add($"GetFromStack: {GetTime(nowTime1, nowTime2)}");
        }

        public static void GetFromSortedSet()
        {
            SortedSet<int> ss = new SortedSet<int>();

            for (int i = 0; i < 100000; i++)
            {
                ss.Add(i);
            }
            DateTime nowTime1 = DateTime.Now;
            for (int i = 5000; i < 10000; i++)
            {
                int a = ss.ElementAt(i);
            }
            DateTime nowTime2 = DateTime.Now;
            resultList.Add($"GetFromSortedSet: {GetTime(nowTime1, nowTime2)}");
        }

        public static void GetFromSortedDictionary()
        {
            SortedDictionary<string, int> sdic = new SortedDictionary<string, int>();

            for (int i = 0; i < 100000; i++)
            {
                sdic.Add($"{i}", i);
            }
            DateTime nowTime1 = DateTime.Now;
            for (int i = 5000; i < 10000; i++)
            {
                var d = sdic.ElementAt(i);
            }

            DateTime nowTime2 = DateTime.Now;
            resultList.Add($"GetFromSortedDictionary: {GetTime(nowTime1, nowTime2)}");
        }

        //Remove

        public static void RemoveFromList()
        {
            resultList.Add("Remove:");
            List<int> list = new List<int>();

            for (int i = 0; i < 100000; i++)
            {
                list.Add(i);
            }
            DateTime nowTime1 = DateTime.Now;
            for (int i = 5000; i < 10000; i++)
            {
                list.Remove(i);
            }

            DateTime nowTime2 = DateTime.Now;
            resultList.Add($"RemoveFromList: {GetTime(nowTime1, nowTime2)}");
        }

        public static void RemoveFromLinkedList()
        {
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i < 100000; i++)
            {
                list.AddLast(i);
            }
            DateTime nowTime1 = DateTime.Now;
            for (int i = 5000; i < 10000; i++)
            {
                list.Remove(i);
            }

            DateTime nowTime2 = DateTime.Now;
            resultList.Add($"RemoveFromLinkedList: {GetTime(nowTime1, nowTime2)}");
        }

        public static void RemoveFromDictionary()
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            for (int i = 0; i < 100000; i++)
            {
                dic.Add($"{i}", i);
            }
            DateTime nowTime1 = DateTime.Now;
            for (int i = 5000; i < 10000; i++)
            {

                dic.Remove($"{i}");
            }

            DateTime nowTime2 = DateTime.Now;
            resultList.Add($"RemoveFromDictionary: {GetTime(nowTime1, nowTime2)}");
        }

        public static void RemoveFromQueue()
        {
            Queue<int> q = new Queue<int>();

            for (int i = 0; i < 100000; i++)
            {
                q.Enqueue(i);
            }
            DateTime nowTime1 = DateTime.Now;
            for (int i = 0; i < 5000; i++)
            {
                q.Dequeue();
            }
            DateTime nowTime2 = DateTime.Now;
            resultList.Add($"RemoveFromQueue: {GetTime(nowTime1, nowTime2)}");
        }

        public static void RemoveFromStack()
        {
            Stack<int> s = new Stack<int>();

            for (int i = 0; i < 100000; i++)
            {
                s.Push(i);
            }
            DateTime nowTime1 = DateTime.Now;
            for (int i = 0; i < 5000; i++)
            {
                s.Pop();
            }
            DateTime nowTime2 = DateTime.Now;
            resultList.Add($"RemoveFromStack: {GetTime(nowTime1, nowTime2)}");
        }

        public static void RemoveFromSortedSet()
        {
            SortedSet<int> ss = new SortedSet<int>();

            for (int i = 0; i < 100000; i++)
            {
                ss.Add(i);
            }
            DateTime nowTime1 = DateTime.Now;
            for (int i = 5000; i < 10000; i++)
            {
                ss.Remove(i);
            }
            DateTime nowTime2 = DateTime.Now;
            resultList.Add($"RemoveFromSortedSet: {GetTime(nowTime1, nowTime2)}");
        }

        public static void RemoveFromSortedDictionary()
        {
            SortedDictionary<string, int> sdic = new SortedDictionary<string, int>();

            for (int i = 0; i < 100000; i++)
            {
                sdic.Add($"{i}", i);
            }
            DateTime nowTime1 = DateTime.Now;
            for (int i = 5000; i < 10000; i++)
            {
                sdic.Remove($"{i}");
            }

            DateTime nowTime2 = DateTime.Now;
            resultList.Add($"RemoveFromSortedDictionary: {GetTime(nowTime1, nowTime2)}");
        }


        public static void WriteToFile()
        {
            File.WriteAllLines(path, resultList);
        }

    }
}
