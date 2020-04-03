using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList<T>
    {
        MyList<int> vectorlist = new MyList<int>();
       
        int count;
        public int Count { get; set; }
        int capacity;
        public int Capacity { get; set; }
        public object IntegerArray { get; private set; }

        private T[] items;
        public MyList()
        {
            capacity = 4;
            items = new T[capacity];
        }
            public T this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }



        }

        public void Add(int value1)
        {

        }

        public class CustomList : IEnumerable
        {
            
            private string[]IntegerArray;
            private List<T> MyList;
               public List()
            {

                IntegerArray = new string[] { "Value1", "Value2", "Value3", "Value4" };
                MyList = new List() { "Value1", "Value2", "Value3", "Value4" }; }

            public int Length;
            private int Count = Index;

            public static int Index { get; private set; }
        }
            

        public Enumarator GetEnumerator()
        {
            for (int index = 0; index < IntegerArray.Length; index++)
            {
                yield return IntegerArray[index];
                yield return MyList[index];
            }
            yield return "That is the end of the list";

        }

 }  }     
           
              
       
            
            
        
                
                 


            
          
                                


