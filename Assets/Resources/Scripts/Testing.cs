using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TimeManager.Instance.Initialize();
        string[] colors = { "Hello", "Reedham", "Patel" };
        Debug.Log(colors.GetRandomElement());
        Debug.Log(colors.ConvertCollectionToString());
        int a = 5;
        TimeManager.MyDelegate myDelegate = Hello;
        myDelegate.CallAfter(3.4f);
        Debug.Log(a.Fact());
    }
    void Hello()
    {
        Debug.Log("Hello");
    }
    // Update is called once per frame
    void Update()
    {
        TimeManager.Instance.Refresh();
    }
}
