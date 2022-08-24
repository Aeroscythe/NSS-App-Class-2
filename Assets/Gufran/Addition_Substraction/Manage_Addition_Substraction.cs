using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Manage_Addition_Substraction : MonoBehaviour
{
    // Start is called before the first frame update
    public Text num1;
    public Text num2;
    public Text sign;

    public Text answer;
    public Text remark;

    int numberoftries = 0;

    void Start()
    {
        reinstantiate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void reinstantiate()
    {
        numberoftries = 0;

        num1.text = UnityEngine.Random.Range(0,100).ToString();
        num2.text = UnityEngine.Random.Range(0,100).ToString();
        answer.text = "";

        if(UnityEngine.Random.Range(0,2)==1)
        {
            sign.text="+";
        }
        else
        {
            sign.text="-";

            while(Int32.Parse(num1.text)<Int32.Parse(num2.text))
            {
                num1.text = UnityEngine.Random.Range(0,100).ToString();
            }
        }
    }

    public void OnEnter()
    {
        int result = 0;

        if (sign.text=="+")
        {
            result = Int32.Parse(num1.text) + Int32.Parse(num2.text);
        }
        else
        {
            result = Int32.Parse(num1.text) - Int32.Parse(num2.text);
        }
        if(result==Int32.Parse(answer.text))
        {
            remark.text="Correct, Try Next!";
            reinstantiate();
        }
        else
        {
            remark.text="Incorrect, Try again!";
            answer.text = "";
            numberoftries += 1;
        }

        if (numberoftries >= 3)
        {
            remark.text = "Correct answer is: " + result.ToString();
            Invoke("reinstantiate", 1);
        }

    }
}
