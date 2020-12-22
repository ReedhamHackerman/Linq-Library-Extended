using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class LinqAdvance
{
   
    
    //It will Return random element;
    public static T GetRandomElement<T>(this T[] element)
    {
        return element[Random.Range(0,element.Length)];
    }
    public static string ConvertCollectionToString<T>(this T[] element)
    {
        return string.Join(",", element.ToArray());
    }

    public static string ConvertCollectionToString<T>(this IEnumerable<T> element)
    {
        return string.Join(",", element.ToArray());
    }
    public static void CallAfter(this TimeManager.MyDelegate myDelegate,float timer)
    {
        TimeManager.Instance.AddDelegate(myDelegate, timer);
    }
   
    public static List<T> arrayToList<T>(this T[] element)
    {
        return element.ToList();
    }
    public static int Fact(this int a)
    {
        if (a == 1)
        {
            return 1;
        }
        else
        {
            return a * Fact(a - 1);
        }
    }
}
