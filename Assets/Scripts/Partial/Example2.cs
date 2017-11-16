using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example2 : MonoBehaviour
{

    void Start()
    {
        //ClassExample cEX = new ClassExample();
    }
}
public partial class ClassExample// make sure that it is outside of the other class -_-
{
    public float myFloat = 0;

    public void PrintFloat()
    {
        Debug.Log(myFloat);
    }
    partial void InternalSum()
    {
        Debug.Log((int)myFloat + myInt);
    }
    public void Sum()
    {
        InternalSum();
    }
}
