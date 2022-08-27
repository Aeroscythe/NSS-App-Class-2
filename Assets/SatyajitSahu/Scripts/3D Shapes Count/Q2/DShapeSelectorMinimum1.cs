using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DShapeSelectorMinimum1 : MonoBehaviour
{

    [SerializeField] Text codeText;
    string codeTextValue = "";

    int i = 0;

    TextPanelManger1 text;

    private void OnEnable()
    {
        codeTextValue = "";
    }

    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == "CYLINDER")
        {
            text = FindObjectOfType<TextPanelManger1>();
            text.MinimumCorrect();
            Invoke("Tick", 1.0f);
        }

        if (codeTextValue != "CYLINDER" && codeTextValue.Length >= 4)
        {
            while (i < 3)  //change
            {
                codeTextValue = "";
                text = FindObjectOfType<TextPanelManger1>();
                text.WrongActive();
                text = FindObjectOfType<TextPanelManger1>();
                text.MinWrong();
                Invoke("Cross", 1.0f);
                if (i == 2)
                {
                    text = FindObjectOfType<TextPanelManger1>();
                    text.WrongActive();
                    text = FindObjectOfType<TextPanelManger1>();
                    text.MinWrong();
                    Invoke("CWW", 3.0f);
                    Invoke("CWWW", 1.0f);

                }
                Invoke("CW", 1.0f);
                i++;
                break;
            }
            /*codeTextValue = "";
            text = FindObjectOfType<TextPanelManger1>();
            text = FindObjectOfType<TextPanelManger1>();
            text.MinWrong();
            text.WrongActive();
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
        text = FindObjectOfType<TextPanelManger1>();
        text.MinCorrect();
    }

    public void Cross()
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.WrongNotActive();
    }
    public void CW()
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.MinWrongWrong();
    }

    public void CWW() //change
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.WrongNotActive();
    }
    public void CWWW() //change
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.MinCorrect();
    }
}
