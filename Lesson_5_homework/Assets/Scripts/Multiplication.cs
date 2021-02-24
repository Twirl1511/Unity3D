using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Multiplication : MonoBehaviour
{
    [SerializeField] private Text[] _textFields;
    [SerializeField] private InputField _from;
    [SerializeField] private InputField _to;

    public void OnClickMultiplication()
    {
        // перед каждым вызовом метода очищаем все поля
        foreach(Text text in _textFields)
        {
            text.text = "";
        }
        // проверям что введены числа
        if(IsDigit(_from.text) && IsDigit(_to.text))
        {
            int from = System.Int32.Parse(_from.text);
            int to = System.Int32.Parse(_to.text);
            // проверяем корректности интервала
            if(from > to)
            {
                _textFields[2].text = "Вы ввели некорректные значения ОТ и ДО!";
                return;
            }
            // проверяем что хватает стобцов для вывода
            if (to - from >= 5)
            {
                _textFields[2].text = "У меня нет столько столбцов, пора бы и подучить таблицу самому!";
                return;
            }
            // переменная в которой храним значение столбца умножения на одно число
            string result = "";
            // порядковый номер стобцов для вывода инфы в массиве
            int k = 0;
            for (int i = from; i <= to; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    result += $"{i} x {j} = {i * j}\n";
                }
                // выводим значение в стобец и обнуляем переменную
                _textFields[k++].text = result;
                result = "";
            } 
        }
        else
        {
            _textFields[2].text = "Вы ввели некорректные значения ОТ и ДО!";
        }
    }
    /// <summary>
    /// проверяет являетс ли текст числом
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    private bool IsDigit(string text)
    {
        int result;
        if(System.Int32.TryParse(text, out result))
        {
            return true;
        }
        return false;
    }


}
