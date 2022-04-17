using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Words_to_numbers_Qgenerator : MonoBehaviour
{
    public string[] word;
    int number;
    int answernumber;
    public Text NumberToWordBox;
    public Text AnswerDisplay;
    public Text AnswerStatus;
    Button[] buttons;


    void Start()
    {
        buttons = GetComponentsInChildren<Button>();
        InitializeQuestion();
    }

    void NumbertoWord()
    {
        if (number == 100)
            NumberToWordBox.text = word[word.Length-1];
        else if(number<20)
            NumberToWordBox.text = word[number];
        else
            NumberToWordBox.text = word[(number/10)+18]+" "+word[number%10];
    }

    void InitializeQuestion()
    {
        number = Random.Range(1, 101);
        NumbertoWord();
        answernumber = 0;
        for (int i = 0; i < buttons.Length; i++)
            buttons[i].interactable = true;
        ClearDisplay();
        AnswerStatus.text = " ";
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
        if(answernumber==number)
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
