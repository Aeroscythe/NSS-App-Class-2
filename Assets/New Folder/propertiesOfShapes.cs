using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class propertiesOfShapes : MonoBehaviour
{
    public GameObject[] arrows;
    public GameObject quiz, done;
    int a, i;
    public Text b1, b2, b3, b4, correct,question;


    void Start()
    {
        i = 10;
        a = 4;
        Q5();
        
    }
    public void Buttonclick1()
    {
      
        correct.text = "Wrong";
        Invoke("wrong", 1);
        
    }
    public void Buttonclick2()
    {
        
        if(a== 4)
        {
            if (i == 0)
            {
                a++;
                correct.text = "Correct";
                Invoke("Q6", 1);
                i++;
            }
            else
            {
                
                correct.text = "Correct";
                Invoke("Q5", 1);
                i = 0;
            }
          
        }

        else
        {
            correct.text = "Wrong";
            Invoke("wrong", 1);
        }
    }
    public void Buttonclick3()
    {
        
        if (a == 5)
        {
            if (i == 0)
            {
                a++;
                correct.text = "Correct";
                Invoke("Q7", 1);
                i++;
            }
            else
            {
               
                correct.text = "Correct";
                Invoke("Q6", 1);
                i = 0;
            }

        }
        else if (a == 6)
        {
            if (i == 0)
            {
                a++;
                correct.text = "Correct";
                Invoke("alldone", 1);
                i++;
            }
            else
            {
               
                correct.text = "Correct";
                Invoke("Q7", 1);
                i = 0;
            }

        }

        else
        {
            correct.text = "Wrong";
            Invoke("wrong", 1);
        }
    }
    public void Buttonclick4()
    {
       
         correct.text = "Wrong";
         Invoke("wrong", 1);
        
    }

    

    public void Q5()
    {
        if (i == 0)
        {
            question.text = "Number of sides of the following shape :";
            
        }
        else
        {
            question.text = "Number of corners of the following shape :";
        }
       
        correct.text = "";
        arrows[a - 1].SetActive(false);
        arrows[a].SetActive(true);
        b1.text = "2";
        b2.text = "3";
        b3.text = "4";
        b4.text = "5";
    }

    public void Q6()
    {
        if (i == 0)
        {
            question.text = "Number of sides of the following shape :";

        }
        else
        {
            question.text = "Number of corners of the following shape :";
        }
        correct.text = "";
        arrows[a - 1].SetActive(false);
        arrows[a].SetActive(true);
        b1.text = "2";
        b2.text = "3";
        b3.text = "4";
        b4.text = "5";
    }
    public void Q7()
    {
        if (i == 0)
        {
            question.text = "Number of sides of the following shape :";

        }
        else
        {
            question.text = "Number of corners of the following shape :";
        }
        correct.text = "";
        arrows[a - 1].SetActive(false);
        arrows[a].SetActive(true);
        b1.text = "2";
        b2.text = "3";
        b3.text = "4";
        b4.text = "5";
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
