using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Biggest_or_Smallest_number : MonoBehaviour
{
    int[] dig;
    int rnum;
    int choicenum;
    int targetnum;
    public Text digitDisplay;
    public Text AnswerDisplay;
    public Text AnswerStatus;
    public Text Question;
    int answernumber;
    Button[] buttons;

    void Start()
    {
        buttons = GetComponentsInChildren<Button>();
        InitializeQuestion();
    }

    void InitializeQuestion()
    {
        choicenum = Random.Range(0, 2);
        generateDigits();
        for (int i = 0; i < buttons.Length; i++)
            buttons[i].interactable = true;
        ClearDisplay();
        Question.text = "Make the ";
        if (choicenum == 0)
            Question.text += "biggest ";
        else
            Question.text += "smallest ";
        Question.text += "possible number from the given digits without repeating";
        AnswerStatus.text = " ";
    }

    void generateDigits()
    {
        int i, j;
        dig = new int[3];
        for (i = 0; i < 3; i++)
            dig[i] = -1;
        for (i = 0; i < 3; i++)
        {
            do
            {
                rnum = Random.Range(0, 10);
                for (j = 0; j < i; j++)
                {
                    if (dig[j] == rnum)
                        break;
                }
            } while (j != i);
            dig[i] = rnum;
        }
        digitDisplay.text = dig[0].ToString() + ",\t" + dig[1].ToString() + ",\t" + dig[2].ToString();
        FindTargetNumber();
    }

    void FindTargetNumber()
    {
        int t;
        if (dig[0] < dig[1])
        {
            t = dig[0];
            dig[0] = dig[1];
            dig[1] = t;
        }
        if (dig[0] < dig[2])
        {
            t = dig[0];
            dig[0] = dig[2];
            dig[2] = t;
        }
        if (dig[1] < dig[2])
        {
            t = dig[1];
            dig[1] = dig[2];
            dig[2] = t;
        }
        if(choicenum==0)
            targetnum = dig[0] * 100 + dig[1] * 10 + dig[2];
        else
            targetnum = dig[2] * 100 + dig[1] * 10 + dig[0];

    }

    void UpdateDisplay()
    {
        AnswerDisplay.text = answernumber.ToString();
    }
    public void ClearDisplay()
    {
        AnswerDisplay.text = " ";
        answernumber = 0;
    }

    public void Add1()
    {
        answernumber = answernumber * 10 + 1;
        UpdateDisplay();
    }
    public void Add2()
    {
        answernumber = answernumber * 10 + 2;
        UpdateDisplay();
    }
    public void Add3()
    {
        answernumber = answernumber * 10 + 3;
        UpdateDisplay();
    }
    public void Add4()
    {
        answernumber = answernumber * 10 + 4;
        UpdateDisplay();
    }
    public void Add5()
    {
        answernumber = answernumber * 10 + 5;
        UpdateDisplay();
    }
    public void Add6()
    {
        answernumber = answernumber * 10 + 6;
        UpdateDisplay();
    }
    public void Add7()
    {
        answernumber = answernumber * 10 + 7;
        UpdateDisplay();
    }
    public void Add8()
    {
        answernumber = answernumber * 10 + 8;
        UpdateDisplay();
    }
    public void Add9()
    {
        answernumber = answernumber * 10 + 9;
        UpdateDisplay();
    }
    public void Add0()
    {
        answernumber = answernumber * 10;
        UpdateDisplay();
    }

    public void Evaluate()
    {
        if (answernumber == targetnum)
        {
            AnswerStatus.text = "Correct!";
        }
        else
        {
            AnswerStatus.text = "Wrong!";
        }


        for (int i = 0; i < buttons.Length; i++)
            buttons[i].interactable = false;
        Invoke("InitializeQuestion", 1);
    }
}
