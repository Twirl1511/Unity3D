using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Aliquote : MonoBehaviour
{
    [SerializeField] private Text _resultText;
    [SerializeField] private InputField _from;
    [SerializeField] private InputField _to;
    [SerializeField] private InputField _A;
    [SerializeField] private InputField _B;

    public void OnClickAliquote()
    {
        if(isDigit(_from.text) && isDigit(_to.text) && isDigit(_A.text) && isDigit(_B.text))
        {
            int from = System.Int32.Parse(_from.text);
            int to = System.Int32.Parse(_to.text);

            int A = System.Int32.Parse(_A.text);
            int B = System.Int32.Parse(_B.text);

            if (from > to && from < 1)
            {
                _resultText.text = "Вы ввели некорректные значения!";
                return;
            }
            int result = 0;

            for (int i = from; i <= to; i++)
            {
                if ((i % A == 0) || (i % B == 0))
                {
                    result += i;
                }
            }

            _resultText.text = result.ToString();
        }
        else
        {
            _resultText.text = "Вы ввели некорректные значения!";
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
