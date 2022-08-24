using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyScript : MonoBehaviour
{
    public Text question;
    int amount;
    public GameObject Ten;
    public GameObject Fifty;
    public GameObject Hundred;
    public GameObject One;
    public GameObject Two;
    public GameObject Five;

    public InputField FieldTen;
    public InputField FieldFifty;
    public InputField FieldHundred;
    public InputField FieldOne;
    public InputField FieldTwo;
    public InputField FieldFive;

    public GameObject remark;
    int wrongcnt=0;

    // Start is called before the first frame update
    void Start()
    {
        amount = UnityEngine.Random.Range(1 , 300);
        question.text = "How many notes and coins you will take to make "+amount+" rupees?";
    }

    public void submitButton()
    {
        Ten.GetComponent<Text>().text="";
        int cntTen = 0;
        Int32.TryParse(Ten.GetComponent<Text>().text ,out cntTen);
        int cntFifty = 0;
        Int32.TryParse(Fifty.GetComponent<Text>().text ,out cntFifty);
        int cntHundred = 0;
        Int32.TryParse(Hundred.GetComponent<Text>().text ,out cntHundred);
        int cntOne = 0;
        Int32.TryParse(One.GetComponent<Text>().text ,out cntOne);
        int cntTwo = 0;
        Int32.TryParse(Two.GetComponent<Text>().text ,out cntTwo );
        int cntFive = 0;
        Int32.TryParse(Five.GetComponent<Text>().text, out cntFive);

        int answer = cntFifty*50+cntFive*5+cntHundred*100+cntOne+cntTen*10+cntTwo*2;
        FieldFifty.text = "";
        FieldFive.text = "";
        FieldHundred.text = "";
        FieldOne.text = "";
        FieldTen.text = "";
        FieldTwo.text = "";

        if(answer==amount)
        {
            amount = UnityEngine.Random.Range(1 , 300);
            question.text = "How many notes and coins you will take to make "+amount+" rupees?";
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

            FieldFifty.text = b.ToString();
            FieldFive.text = d.ToString();
            FieldHundred.text = a.ToString();
            FieldOne.text = f.ToString();
            FieldTen.text = c.ToString();
            FieldTwo.text = e.ToString();
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
