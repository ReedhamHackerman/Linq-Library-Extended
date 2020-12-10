using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager
{
    public delegate void MyDelegate();
    MyDelegate myDelegate;
    private static TimeManager instance;
    public static TimeManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new TimeManager();
            }
            return instance;
        }
    }
    public delegate string MyArgumentDelegate(string S);

   


    List<DelegateTimer> delegateTimerList;
    public void Initialize()
    {
        delegateTimerList = new List<DelegateTimer>();
    }
    public void Refresh()
    {
        for (int i = delegateTimerList.Count-1; i >= 0; i--)
        {
            if (delegateTimerList[i].timeToInvoke<=Time.time)
            {
                delegateTimerList[i].delegateToInvoke();
                delegateTimerList.RemoveAt(i);
            }
        }
    }
    public void EndGame()
    {
        delegateTimerList.Clear();
    }


    public void AddDelegate(MyDelegate del,float time)
    {
        DelegateTimer toADD = new DelegateTimer(Time.time + time, del);
        delegateTimerList.Add(toADD);
       
    }

    public void AddArgumentDeleGate(MyArgumentDelegate arg,float time)
    {
        DelegateTimer toadd = new DelegateTimer(time + Time.time, arg);
        delegateTimerList.Add(toadd);
    }



    private class DelegateTimer
    {
       public float timeToInvoke;
       public   MyDelegate delegateToInvoke;
       public MyArgumentDelegate MyArgumentDelegate;
        public DelegateTimer(float timeOfInvo,MyDelegate del)
        {
            this.timeToInvoke = timeOfInvo;
            this.delegateToInvoke = del;

        }
        public DelegateTimer(float timeOfInvo, MyArgumentDelegate myArgumentDelegate)
        {
            this.timeToInvoke = timeOfInvo;
            this.MyArgumentDelegate = myArgumentDelegate;
        }

    }
}