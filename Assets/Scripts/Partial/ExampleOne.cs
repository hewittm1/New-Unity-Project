using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleOne : MonoBehaviour {

	void Start () {
        ClassExample ex = new ClassExample();
        ex.myInt = 120;
        ex.myFloat = 2000;
        ex.Sum();
	}
}
public partial class ClassExample
{
    public int myInt;
    public void PrintInt()
    {
        Debug.Log(myInt);
    }
    partial void InternalSum();
}
