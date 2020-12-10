using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] colors = { "Hello", "Reedham", "Patel" };
        Debug.Log(colors.GetRandomElement());
        Debug.Log(colors.ConvertCollectionToString());
        int a = 5;

        Debug.Log(a.Fact());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
