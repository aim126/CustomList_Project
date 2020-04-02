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

        public  T this [int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
         
            

           }
        
            public void Add(int value1)
        {

        }
    }        
           
}
