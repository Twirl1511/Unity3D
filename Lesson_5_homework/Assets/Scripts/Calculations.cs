using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculations : MonoBehaviour
{
    private void Start()
    {
        //showEvenDigits();
        //showMultiplicationTable();
        //showFactorial(4);
    }
    public void showEvenDigits()
    {
        for(int i = 1; i <= 10; i++)
        {
            if(i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
    }

    public void showMultiplicationTable()
    {
        for(int i = 1; i <= 10; i++)
        {
            for(int j = 1; j <= 10; j++)
            {
                Debug.Log($"{i} x {j} = {i*j}" );
            }
        }
    }

    public void showFactorial(int n)
    {
        int result = 1;
        for(int i = 1; i <= n; i++)
        {
            result *= i;
        }
        Debug.Log(result);
    }

}
