using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DShapeSelectorMaximum1 : MonoBehaviour
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

        if (codeTextValue == "CUBOID")
        {
            text = FindObjectOfType<TextPanelManger1>();
            text.MaximumCorrect();
            Invoke("Tick", 1.0f);
        }

        if (codeTextValue != "CUBOID" && codeTextValue.Length >= 4)
        {
            while (i < 3)  //change
            {
                codeTextValue = "";
                text = FindObjectOfType<TextPanelManger1>();
                text.WrongActive();
                text = FindObjectOfType<TextPanelManger1>();
                text.MaxWrong();
                Invoke("Cross", 1.0f);
                if (i == 2)
                {
                    text = FindObjectOfType<TextPanelManger1>();
                    text.WrongActive();
                    text = FindObjectOfType<TextPanelManger1>();
                    text.MaxWrong();
                    Invoke("CWW", 3.0f);
                    Invoke("CWWW", 1.0f);

                }
                Invoke("CW", 1.0f);
                i++;
                break;
            }
            /*codeTextValue = "";
            text = FindObjectOfType<TextPanelManger1>();
            text.WrongActive();
            text = FindObjectOfType<TextPanelManger1>();
            text.MaxWrong();
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
        text.MaxCorrect();
    }

    public void Cross()
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.WrongNotActive();
    }
    public void CW()
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.MaxWrongWrong();
    }

    public void CWW() //change
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.WrongNotActive();
    }
    public void CWWW() //change
    {
        text = FindObjectOfType<TextPanelManger1>();
        text.MaxCorrect();
    }
}
