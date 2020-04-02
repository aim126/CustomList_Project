using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTesting
{

    public class MyListIEnumerable
    {
        private readonly object Length;
       
          int count = 4;

           }

        private.Collections.IEnumerator GetEnumerator()
        {



          for (int index = 0; index < length.count; index++)
          {

             yield return "capacity:" + Length[index] + testingList[index];


            }
            yield return "that is the end of the list!";

        }

    }
        