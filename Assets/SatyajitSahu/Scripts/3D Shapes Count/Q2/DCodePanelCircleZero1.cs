using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DCodePanelCircleZero1 : MonoBehaviour
{

    [SerializeField] Text codeText;
    string codeTextValue = "";
    string enterValue;

    TextPanelManger1 text;

    private void OnEnable()
    {
        codeTextValue = "";
        enterValue = "";
    }

    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;

        if (enterValue == "10")
        {
            text = FindObjectOfType<TextPanelManger1>();
            text.Correct();
            Invoke("Tick", 1.0f);
        }

        if (enterValue != "10" && enterValue.Length >= 1)
        {
            codeTextValue = "";
            text = FindObjectOfType<TextPanelManger1>();
            text.WrongActive();
            text = FindObjectOfType<TextPanelManger1>();
            text.CircleWrong0();
            Invoke("Cross", 3.0f);
            Invoke("CW", 3.0f);
        }
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }

    public void clearDigit()  //CHANGE
    {
        codeTextValue = "";
    }

    public void enter()  //CHANGE
    {
        enterValue = codeTextValue;
    }

    public void Tick()
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.CircleCorrect0();
    }

    public void Cross()
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.WrongNotActive();
    }

    public void CW()
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.CircleWrongWrong0();
    }
}
