using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DShapeSelectorMinimum : MonoBehaviour
{

    [SerializeField] Text codeText;
    string codeTextValue = "";
    int i = 0;

    TextPanelManger text;

    private void OnEnable()
    {
        codeTextValue = "";
    }

    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == "CUBE")
        {
            text = FindObjectOfType<TextPanelManger>();
            text.MinimumCorrect();
            Invoke("Tick", 1.0f);
        }

        if (codeTextValue != "CUBE" && codeTextValue.Length >= 4)
        {
            while (i < 3)  //change
            {
                codeTextValue = "";
                text = FindObjectOfType<TextPanelManger>();
                text.WrongActive();
                text = FindObjectOfType<TextPanelManger>();
                text.MinWrong();
                Invoke("Cross", 1.0f);
                if (i == 2)
                {
                    text = FindObjectOfType<TextPanelManger>();
                    text.WrongActive();
                    text = FindObjectOfType<TextPanelManger>();
                    text.MinWrong();
                    Invoke("CWW", 3.0f);
                    Invoke("CWWW", 1.0f);

                }
                Invoke("CW", 1.0f);
                i++;
                break;
            }
            /*codeTextValue = "";
            text = FindObjectOfType<TextPanelManger>();
            text.WrongActive();
            text = FindObjectOfType<TextPanelManger>();
            text.MinWrong();
            Invoke("Cross", 1.0f);
            Invoke("CW", 1.0f);*/
        }
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }

    public void Tick()
    {
        text = FindObjectOfType<TextPanelManger>();
        text.MinCorrect();
    }

    public void Cross()
    {
        text = FindObjectOfType<TextPanelManger>();
        text.WrongNotActive();
    }

    public void CW()
    {
        text = FindObjectOfType<TextPanelManger>();
        text.MinWrongWrong();
    }

    public void CWW() //change
    {
        text = FindObjectOfType<TextPanelManger>();
        text.WrongNotActive();
    }
    public void CWWW() //change
    {
        text = FindObjectOfType<TextPanelManger>();
        text.MinCorrect();
    }
}
