using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timecontroller : MonoBehaviour
{
    public GameObject[] arrows;
    public GameObject quiz, done;
    int a, b, i;
    public Text b1, b2, b3, b4, correct, answer;

    void Start()
    {
        i = 0;
        a = 0;
        Q1();
    }
    private void Update()
    {

    }
    public void Buttonclick1()
    {
        if (a == 0)
        {
            a++;
            correct.text = "Correct";
            Invoke("Q2", 1);

        }

        else if (a == 5)
        {
            a++;
            correct.text = "Correct";
            Invoke("Q7", 1);

        }

        else
        {
            correct.text = "Wrong";
            Invoke("wrong", 1);
        }
    }
    public void Buttonclick2()
    {
        if (a == 3)
        {
            a++;
            correct.text = "Correct";
            Invoke("Q5", 1);

        }

        else
        {
            correct.text = "Wrong";
            Invoke("wrong", 1);
        }
    }
    public void Buttonclick3()
    {
        if (a == 1)
        {
            a++;
            correct.text = "Correct";
            Invoke("Q3", 1);

        }
        else if (a == 6)
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
    public void Buttonclick4()
    {
        if (a == 2)
        {
            a++;
            correct.text = "Correct";
            Invoke("Q4", 1);

        }

        else if (a == 4)
        {
            a++;
            correct.text = "Correct";
            Invoke("Q6", 1);

        }

        else
        {
            correct.text = "Wrong";
            Invoke("wrong", 1);
        }
    }

    public void Q1()
    {
        i = 0;
        arrows[a].SetActive(true);
        b1.text = "09:00";
        b2.text = "10:00";
        b3.text = "05:40";
        b4.text = "10:15";
    }
    public void Q2()
    {
        i = 0;
        correct.text = "";
        arrows[a - 1].SetActive(false);
        arrows[a].SetActive(true);
        b1.text = "10:00";
        b2.text = "09:45";
        b3.text = "11:15";
        b4.text = "07:15";
    }
    public void Q3()
    {
        i = 0;
        correct.text = "";
        arrows[a - 1].SetActive(false);
        arrows[a].SetActive(true);
        b1.text = "06:30";
        b2.text = "07:90";
        b3.text = "05:30";
        b4.text = "05:45";
    }
    public void Q4()
    {
        i = 0;
        correct.text = "";
        arrows[a - 1].SetActive(false);
        arrows[a].SetActive(true);
        b1.text = "01:15";
        b2.text = "02:30";
        b3.text = "03:30";
        b4.text = "10:15";
    }

    public void Q5()
    {
        i = 0;
        correct.text = "";
        arrows[a - 1].SetActive(false);
        arrows[a].SetActive(true);
        b1.text = "11:30";
        b2.text = "10:05";
        b3.text = "02:10";
        b4.text = "03:05";
    }

    public void Q6()
    {
        i = 0;
        correct.text = "";
        arrows[a - 1].SetActive(false);
        arrows[a].SetActive(true);
        b1.text = "09:35";
        b2.text = "08:40";
        b3.text = "09:05";
        b4.text = "10:00";
    }
    public void Q7()
    {
        i = 0;
        correct.text = "";
        arrows[a - 1].SetActive(false);
        arrows[a].SetActive(true);
        b1.text = "05:30";
        b2.text = "01:40";
        b3.text = "12:40";
        b4.text = "03:40";
    }


    public void wrong()
    {
        correct.text = "";
        i++;
    }

    public void alldone()
    {
        arrows[a - 1].SetActive(false);
        correct.text = "";
        quiz.SetActive(false);
        done.SetActive(true);
    }
}
