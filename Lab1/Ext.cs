using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public static class Ext
    {
        public static IEnumerable<Tret> Map<T, Tret>(this IEnumerable<T> seq, Func<T, Tret> act) where T:IComparable<T> 
        {
            var l = new List<Tret>();
            foreach (var x in seq)
            {
                yield return act(x);
            }
        }
        public delegate Tret Func<T, Tret>(T arg);
    }
}
