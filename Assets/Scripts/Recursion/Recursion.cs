using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recursion : MonoBehaviour {
    public int factorial;
    private void Start()
    {
        FactFor();
    }
    void FactFor()
    {
        int total = 1;
        for (int i = factorial; i > 1; i--)
        {
            total *= i;
            Debug.Log(total);
        }
        Debug.Log(total);
    }
}
