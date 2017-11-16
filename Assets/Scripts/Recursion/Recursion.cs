
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recursion : MonoBehaviour {
    public int factorial;


    public bool factFor,fact;

    private void Start()
    {
        if (factFor)
            FactFor();
        else if (fact)
            Debug.Log(Fact(factorial));
        //else if()
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
    int Fact(int num)
    {
        if (num == 0)
            return 1;                             
        return num * Fact(num-1);
    }
}
