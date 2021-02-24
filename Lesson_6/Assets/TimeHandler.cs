using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeHandler : MonoBehaviour
{
    public Text textTime;
    public Text circleCounter;
    private int circleNumber = 0;

    void Start()
    {
        Debug.Log("7.7f + Mathf.Round = " + Mathf.Round(7.7f));
        Debug.Log("1.4f + Mathf.Round = " + Mathf.Round(1.4f));
        Debug.Log("5.5f + Mathf.Round = " + Mathf.Round(5.5f));
        Debug.Log("6.5f + Mathf.Round = " + Mathf.Round(6.5f));
        Debug.Log("-0.5f + Mathf.Round = " + Mathf.Round(-0.5f));
    }

    // Update is called once per frame
    void Update()
    {
        textTime.text = Mathf.Round(Time.time).ToString();
      //  circleCounter.text = ((int)Mathf.Round(Time.time)/10).ToString();
        
    }

    public void CircleFinishButton()
    {
        circleCounter.text = (++circleNumber).ToString();
    }
}
