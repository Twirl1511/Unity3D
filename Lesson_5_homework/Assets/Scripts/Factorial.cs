using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Factorial : MonoBehaviour
{
    [SerializeField] private Text _resultText;
    [SerializeField] private InputField _digit;

    public void OnClickFactorial()
    {
        if(isDigit(_digit.text))
        {
            int digit = System.Int32.Parse(_digit.text);
            if(digit < 1)
            {
                _resultText.text = "Значение не может быть меньше единицы!";
                return;
            }
            if (digit > 65)
            {
                _resultText.text = "Увы, число получится таким большим, что мне негде его хранить =(\n" +
                    "Попробуйте значение поменьше ";
                return;
            }
            ulong result = 1;
            for (int i = 1; i <= digit; i++)
            {
                result = result * (ulong)i;
            }
            _resultText.text = result.ToString();
        }
        else
        {
            _resultText.text = "Вы ввели некорректное значение!";
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
