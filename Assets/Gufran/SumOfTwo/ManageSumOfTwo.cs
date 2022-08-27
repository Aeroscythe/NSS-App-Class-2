using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ManageSumOfTwo : MonoBehaviour
{
    // Start is called before the first frame update
    public Text num1;
    public Text num2;
    public Text Que;

    public Text finalnum;
    public Text remark;
    int wrongcnt = 0;
    void OnEnable()
    {
        reinstantiate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2.0f);
        reinstantiate();
    }
    IEnumerator wDelay()
    {
        yield return new WaitForSeconds(1.0f);
        remark.text = "";
        num1.text = "";
        num2.text = "";
        wrongcnt++;
    }

    void reinstantiate()
    {
        finalnum.text = UnityEngine.Random.Range(0,100).ToString();
        Que.text = "Represent " + Int32.Parse(finalnum.text) + " as a sum of any two numbers:";
        remark.text = "";
        num1.text = "";
        num2.text = "";
    }

    public void OnEnter()
    {
        if ((Int32.Parse(num1.text) + Int32.Parse(num2.text)) == Int32.Parse(finalnum.text))
        {
            remark.text = "Correct!";
            StartCoroutine(Delay());
            wrongcnt = 0;
        }
        else if (wrongcnt < 2)
        {
            remark.text = "Wrong, Try Again.";
            StartCoroutine(wDelay());

        }
        else 
        {
            int a = Int32.Parse(finalnum.text) / 2;
            int b = Int32.Parse(finalnum.text) - a;
            num1.text = a.ToString();
            num2.text = b.ToString();
            wrongcnt = 0;
            StartCoroutine(Delay());

        }
    }
}
