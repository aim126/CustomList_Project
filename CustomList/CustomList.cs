using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList<T>
    {
        int count;
        public int Count { get; set; }
        int capacity;
        public int Capacity { get; set; }
        private T[] items;
        public MyList()
        {
            capacity = 4;
            items = new T[capacity];
        }
        //Declaring an array for storing data
        //private T[] arr = new T[100];

        public T this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }



        }
        
        public void Add(int value1)
        {

        }
       
        public class CustomList  :IEnumerable
        {
            private string[] integerArray;
            private List<T> MyList;

            public MyList()
            {
                indexArray new string[] { "Value1", "Value2", Value3","Value4" };
                MyList = new List<T>() {  "Value1","Value2", "Value3","Value4" };
                public private readonly object Length;
                int Count = (int++);
                int Length = (Value1; int++);
            }

           public Enumarator GetEnumerator()
           {
               for (int index = 0; index < integrArray.Length; index++)
               {
                    yield return indexArray[indesx];
                    yield return MyList[index];
               }
               yield return"That is the end of the list"

                                
        }
            
           
           
              
       
            
            
        
                
                 


            
          
                                


