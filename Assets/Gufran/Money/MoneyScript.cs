using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyScript : MonoBehaviour
{
    public Text question;
    int amount;
    public Text Ten;
    public Text Fifty;
    public Text Hundred;
    public Text One;
    public Text Two;
    public Text Five;


    public GameObject remark;
    int wrongcnt=0;

    // Start is called before the first frame update
    void Start()
    {
        amount = UnityEngine.Random.Range(1 , 300);
        question.text = "How many notes and coins you will take to make "+amount+" rupees?";
    }

    public void increaseTen()
    {
        int a = 0;
        
        Int32.TryParse(Ten.text ,out a);
        a = a+1;

        Ten.text = a.ToString();

    }

    public void decreaseTen()
    {
        int a = 0;
        Int32.TryParse(Ten.text ,out a);
        a = a-1;

        if(a<0)
        Ten.text = "0";
        else
        Ten.text = a.ToString();

    }

    public void increaseFifty()
    {
        int a = 0;
        Int32.TryParse(Fifty.text ,out a);
        a = a+1;
        
        Fifty.text = a.ToString();

    }

    public void decreaseFifty()
    {
        int a = 0;
        Int32.TryParse(Fifty.text ,out a);
        a = a-1;

        if(a<0)
        Fifty.text = "0";
        else
        Fifty.text = a.ToString();

    }

    public void increaseHundred()
    {
        int a = 0;
        Int32.TryParse(Hundred.text ,out a);
        a = a+1;

        Hundred.text = a.ToString();

    }

    public void decreaseHundred()
    {
        int a = 0;
        Int32.TryParse(Hundred.text ,out a);
        a = a-1;

        if(a<0)
        Hundred.text = "0";
        else
        Hundred.text = a.ToString();

    }

    public void increaseOne()
    {
        int a = 0;
        Int32.TryParse(One.text ,out a);
        a = a+1;

        One.text = a.ToString();

    }

    public void decreaseOne()
    {
        int a = 0;
        Int32.TryParse(One.text ,out a);
        a = a-1;

        if(a<0)
        One.text = "0";
        else
        One.text = a.ToString();

    }

    public void increaseTwo()
    {
        int a = 0;
        Int32.TryParse(Two.text ,out a);
        a = a+1;


        Two.text = a.ToString();

    }

    public void decreaseTwo()
    {
        int a = 0;
        Int32.TryParse(Two.text ,out a);
        a = a-1;

        if(a<0)
        Two.text = "0";
        else
        Two.text = a.ToString();

    }

    public void increaseFive()
    {
        int a = 0;
        Int32.TryParse(Five.text ,out a);
        a = a+1;

        Five.text = a.ToString();

    }

    public void decreaseFive()
    {
        int a = 0;
        Int32.TryParse(Five.text ,out a);
        a = a-1;

        if(a<0)
        Five.text = "0";
        else
        Five.text = a.ToString();

    }
    public void submitButton()
    {
        int cntTen = 0;
        Int32.TryParse(Ten.text ,out cntTen);
        int cntFifty = 0;
        Int32.TryParse(Fifty.text ,out cntFifty);
        int cntHundred = 0;
        Int32.TryParse(Hundred.text ,out cntHundred);
        int cntOne = 0;
        Int32.TryParse(One.text ,out cntOne);
        int cntTwo = 0;
        Int32.TryParse(Two.text ,out cntTwo );
        int cntFive = 0;
        Int32.TryParse(Five.text, out cntFive);

        int answer = cntFifty*50+cntFive*5+cntHundred*100+cntOne+cntTen*10+cntTwo*2;
        Ten.text = "0";
        Fifty.text = "0";
        Hundred.text = "0";
        One.text = "0";
        Two.text = "0";
        Five.text = "0";

        if(answer==amount)
        {
            amount = UnityEngine.Random.Range(1 , 300);
            question.text = "How many notes and coins you will take to make "+amount+" rupees?";
            wrongcnt = 0;
            StartCoroutine(ShowRemark(true));
        }
        else if(wrongcnt<2)
        {
            StartCoroutine(ShowRemark(false));
            wrongcnt++;
        }
        else
        {
            int a = amount/100;
            int b = (amount-a*100)/50;
            int c = (amount-a*100-b*50)/10;
            int d = (amount-a*100-b*50-c*10)/5;
            int e = (amount-a*100-b*50-c*10-d*5)/2;
            int f = (amount-a*100-b*50-c*10-d*5-e*2);

            Fifty.text = b.ToString();
            Five.text = d.ToString();
            Hundred.text = a.ToString();
            One.text = f.ToString();
            Ten.text = c.ToString();
            Two.text = e.ToString();
            wrongcnt = 0;
        }


    }
    IEnumerator ShowRemark(bool correct) {
        remark.SetActive(true);
        if(correct)
        {
            remark.GetComponent<Text>().text = "Correct, Try next!";
        }
        else
        {
            remark.GetComponent<Text>().text = "Wrong, Try again";
        }
        yield return new WaitForSeconds(2);
        remark.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
