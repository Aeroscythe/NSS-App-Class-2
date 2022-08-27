using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DCodePanelSquareOne : MonoBehaviour
{

    [SerializeField] Text codeText;
    string codeTextValue = "";
    string enterValue;

    TextPanelManger text;

    private void OnEnable()
    {
        codeTextValue = "";
        enterValue = "";
    }

    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;

        if (enterValue == "3")
        {
            text = FindObjectOfType<TextPanelManger>();
            text.Correct();
            Invoke("Tick", 1.0f);
        }

        if (enterValue != "3" && enterValue.Length >= 1)
        {
            codeTextValue = "";
            text = FindObjectOfType<TextPanelManger>();
            text.WrongActive();
            text = FindObjectOfType<TextPanelManger>();
            text.SquareWrong1();
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
        text = FindObjectOfType<TextPanelManger>();
        text.SquareCorrect1();
    }

    public void Cross()
    {
        text = FindObjectOfType<TextPanelManger>();
        text.WrongNotActive();
    }

    public void CW()
    {
        text = FindObjectOfType<TextPanelManger>();
        text.SquareWrongWrong1();
    }
}
