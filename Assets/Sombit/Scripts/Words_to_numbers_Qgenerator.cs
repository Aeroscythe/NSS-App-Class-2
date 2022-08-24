using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Words_to_numbers_Qgenerator : MonoBehaviour
{
    string[] word;
    string target;
    int number;
    int answernumber;
    public Text NumberToWordBox;
    public Text AnswerDisplay;
    public Text AnswerStatus;
    int tries;
    bool status;
    Button[] buttons;


    void Start()
    {
        buttons = GetComponentsInChildren<Button>();
        word = new string[29];
        word[0] = "";
        word[1] = "one";
        word[2] = "two";
        word[3] = "three";
        word[4] = "four";
        word[5] = "five";
        word[6] = "six";
        word[7] = "seven";
        word[8] = "eight";
        word[9] = "nine";
        word[10] = "ten";
        word[11] = "eleven";
        word[12] = "twelve";
        word[13] = "thirteen";
        word[14] = "fourteen";
        word[15] = "fifteen";
        word[16] = "sixteen";
        word[17] = "seventeen";
        word[18] = "eighteen";
        word[19] = "nineteen";
        word[20] = "twenty";
        word[21] = "thirty";
        word[22] = "forty";
        word[23] = "fifty";
        word[24] = "sixty";
        word[25] = "seventy";
        word[26] = "eighty";
        word[27] = "ninety";
        word[28] = "hundred";
        InitializeQuestion();
    }

    void NumbertoWord()
    {
        if (number == 100)
            target = word[word.Length - 1];
        else if (number < 20)
            target = word[number];
        else
            target = word[(number / 10) + 18] + " " + word[number % 10];
        target = char.ToUpper(target[0]) + target.Substring(1);
        NumberToWordBox.text = target;
    }

    void InitializeQuestion()
    {
        number = Random.Range(1, 101);
        NumbertoWord();
        answernumber = 0;
        for (int i = 0; i < buttons.Length; i++)
            buttons[i].interactable = true;
        ClearDisplay();
        tries = 0;
        status = false;
    }

    void UpdateDisplay()
    {
        AnswerDisplay.text = answernumber.ToString();
    }
    public void ClearDisplay()
    {
        AnswerDisplay.text = " ";
        answernumber = 0;
        AnswerStatus.text = " ";
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


        if (answernumber == number)
        {
            AnswerStatus.text = "Correct!";
            status = true;

        }
        else
        {
            AnswerStatus.text = "Wrong!";
            tries++;
        }




        if (tries > 2 || status == true)
        {
            if (tries > 2)
            {
                AnswerDisplay.text = "Correct answer:\n" + number.ToString();
                for (int i = 0; i < buttons.Length; i++)
                    buttons[i].interactable = false;
                Invoke("InitializeQuestion", 3);

            }

            else
            {
                for (int i = 0; i < buttons.Length; i++)
                    buttons[i].interactable = false;
                Invoke("InitializeQuestion", 1);
            }
        }

        else if (tries < 3)
        {
            Invoke("ClearDisplay", 1);
        }
    }



}
