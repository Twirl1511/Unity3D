using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvenDigits : MonoBehaviour
{
    [SerializeField] private Text _resultText;
    [SerializeField] private InputField _from;
    [SerializeField] private InputField _to;

    public void OnClickEvenDigits()
    {
        if(isDigit(_from.text) && isDigit(_to.text))
        {
            int from = System.Int32.Parse(_from.text);
            int to = System.Int32.Parse(_to.text);
            if(from > to)
            {
                _resultText.text = "Вы ввели некорректные значения ОТ и ДО!";
                return;
            }
            string result = "";

            for (int i = from; i <= to; i++)
            {
                if (i % 2 == 0)
                {
                    result = $"{result}; {i}";
                }
            }

            _resultText.text = result.TrimStart(';', ' ');
        }
        else
        {
            _resultText.text = "Вы ввели некорректные значения ОТ и ДО!";
        }
        
    }

    private bool isDigit(string text)
    {
        int result;
        if(System.Int32.TryParse(text, out result))
        {
            return true;
        }
        return false;
    }


}
