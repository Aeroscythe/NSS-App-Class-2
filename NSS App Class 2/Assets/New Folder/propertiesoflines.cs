using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class propertiesoflines : MonoBehaviour
{
    public GameObject[] arrows;
    public GameObject quiz, done;
    int a, i;
    public Text b1, b2, b3, b4, correct, question;


    void Start()
    {
        i = 10;
        a = 0;
        Q1();
        question.text = "Select the correct answer";
    }
    public void Buttonclick1()
    {
        if (a == 3)
        {
            a++;
            correct.text = "Correct";
            Invoke("alldone", 1);
        }



        else
        {
            correct.text = "Wrong";
            Invoke("wrong", 1);
        }
    }
    public void Buttonclick2()
    {
        if (a == 1)
        {
            a++;
            correct.text = "Correct";
            Invoke("Q3", 1);

        }
        

        else
        {
            correct.text = "Wrong";
            Invoke("wrong", 1);
        }
    }
    public void Buttonclick3()
    {
        if (a == 2)
        {
            a++;
            correct.text = "Correct";
            Invoke("Q4", 1);

        }
        
        

        else
        {
            correct.text = "Wrong";
            Invoke("wrong", 1);
        }
    }
    public void Buttonclick4()
    {
        if (a == 0)
        {
            a++;
            correct.text = "Correct";
            Invoke("Q2", 1);

        }



        else
        {
            correct.text = "Wrong";
            Invoke("wrong", 1);
        }
    }

    public void Q1()
    {
        arrows[a].SetActive(true);
        b1.text = "Straight";
        b2.text = "Slanting";
        b3.text = "Laying down";
        b4.text = "Curved";
    }
    public void Q2()
    {
        correct.text = "";
        arrows[a - 1].SetActive(false);
        arrows[a].SetActive(true);
        b1.text = "Straight";
        b2.text = "Slanting";
        b3.text = "Laying down";
        b4.text = "Curved";
    }
    public void Q3()
    {
        correct.text = "";
        arrows[a - 1].SetActive(false);
        arrows[a].SetActive(true);
        b1.text = "Straight";
        b2.text = "Slanting";
        b3.text = "Laying down";
        b4.text = "Curved";
    }
    public void Q4()
    {
        correct.text = "";
        arrows[a - 1].SetActive(false);
        arrows[a].SetActive(true);
        b1.text = "Straight";
        b2.text = "Slanting";
        b3.text = "Laying down";
        b4.text = "Curved";
    }

   

    public void wrong()
    {
        correct.text = "";
    }

    public void alldone()
    {
        question.text = "";
        arrows[a - 1].SetActive(false);
        correct.text = "";
        quiz.SetActive(false);
        done.SetActive(true);
    }

}
