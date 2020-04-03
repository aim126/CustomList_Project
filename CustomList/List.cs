using System;
using System.Collections.Generic;

namespace CustomList
{
    internal class List : List<object>
    {
        public static implicit operator List<object>(List v)
        {
            throw new NotImplementedException();
        }
    }
}