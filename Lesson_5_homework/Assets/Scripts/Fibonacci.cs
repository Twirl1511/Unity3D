using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fibonacci : MonoBehaviour
{
    [SerializeField] private Text _resultText;
    private int counter = 4000000;

    public void OnClickFibonacci()
    {
        int j = 1;
        int result = 0;

        for (int i = 0; i <= counter;)
        {
            if (i % 2 == 0)
            {
                result += i;
            }
            i = i + j;
            j = i-j;
        }

        _resultText.text = result.ToString();
        
    }

    


}
