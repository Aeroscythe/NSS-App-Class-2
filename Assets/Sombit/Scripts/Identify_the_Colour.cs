using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class colourstype
{
    public Color colour;
    public string name;
    public int index;
}


public class Identify_the_Colour : MonoBehaviour
{
    public colourstype[] colours;
    int rnum;
    Button[] buttons;
    colourstype[] ChosenColours;
    public Image colourbox;
    int rightAnswer;
    public Text AnswerStatus;
    
    
    void Start()
    {
        ChosenColours = new colourstype[3];
        buttons = GetComponentsInChildren<Button>();

        Initialize();
    }

    void Initialize()
    {
        for (int i = 0; i < colours.Length; i++)
            colours[i].index = i;
        ChooseColours();
        for (int i = 0; i < buttons.Length; i++)
            buttons[i].interactable = true;
        AnswerStatus.text = " ";
        colourbox.color = ChosenColours[0].colour;
        rightAnswer = Random.Range(0, 3);
        int j = 1;
        for(int i=0; i<buttons.Length ; i++)
        {
            if (i == rightAnswer)
                buttons[i].GetComponentInChildren<Text>().text = ChosenColours[0].name;
            else
            {
                buttons[i].GetComponentInChildren<Text>().text = ChosenColours[j].name;
                j++;
            }
        }

    }

    void ChooseColours()
    {
        int i, j;
        ChosenColours = new colourstype[3];
        for(i=0;i<3;i++)
        {
            do
            {
                rnum = Random.Range(0, colours.Length);
                for (j = 0; j < i; j++)
                {
                    if (rnum == ChosenColours[j].index)
                        break;
                }
                

            } while (j != i);
            ChosenColours[i] = colours[rnum];
        }
    }

    void Evaluate(int x)
    {
        if (x == rightAnswer)
            AnswerStatus.text = "Correct!";
        else
            AnswerStatus.text = "Wrong!";
        for (int i = 0; i < buttons.Length; i++)
            buttons[i].interactable = false;
        Invoke("Initialize", 1);
    }
    
    public void Click0()
    {
        Evaluate(0);
    }
    public void Click1()
    {
        Evaluate(1);
    }
    public void Click2()
    {
        Evaluate(2);
    }


}
