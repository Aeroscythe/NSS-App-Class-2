using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    public GameObject[] sets;
    public GameObject done;
    int a;
    public Text correct;


    void Start()
    {
        a = 0;
        Q1();
    }

    void Update()
    {
        
    }
    public void Q1()
    {
        correct.text = "";
        sets[a].SetActive(true);
        
    }
    public void Q2()
    {
        correct.text = "";
        sets[a - 1].SetActive(false);
        sets[a].SetActive(true);
        
    }
    public void Q3()
    {
        correct.text = "";
        sets[a - 1].SetActive(false);
        sets[a].SetActive(true);
        
    }
    public void Q4()
    {
        correct.text = "";
        sets[a - 1].SetActive(false);
        sets[a].SetActive(true);
        
    }public void Q5()
    {
        correct.text = "";
        sets[a - 1].SetActive(false);
        sets[a].SetActive(true);
        
    }public void Q6()
    {
        correct.text = "";
        sets[a - 1].SetActive(false);
        sets[a].SetActive(true);
        
    }



    public void Buttonclick1()
    {
        if (a == 0)
        {
            a++;
            correct.text = "Correct";
            Invoke("Q2", 1);

        }
        else if (a == 4)
        {
            a++;
            correct.text = "Correct";
            Invoke("Q6", 1);
        }
        else if (a == 5)
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
        else if (a == 2)
        {
            a++;
            correct.text = "Correct";
            Invoke("Q4", 1);
        }
        else if (a == 3)
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
    public void wrong()
    {
        correct.text = "";
    }

    public void alldone()
    {
       
        sets[a - 1].SetActive(false);
        correct.text = "";
      
        done.SetActive(true);
    }
}
