using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class division : MonoBehaviour
{
    int a, b, count, ans, rans, x;
    public Text v1, v2, corr, alld;
    public Text answer;
    // Start is called before the first frame update
    void Start()
    {

        count = 1;
        a = 100;
        b = 10;
        x = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 1)
        {
            answer.text = "";
        }
        else
        {
            answer.text = "" + (ans);
        }
        v1.text = "" + (a);
        v2.text = "" + (b);
        rans = a / b;

        if (x == 3)
        {
            answer.text = "" + (rans);
            corr.text = "Solution";
            StartCoroutine(Solution());
            
        }

    }

    public void TextChangeTo1()
    {
        if (count == 1)
        {
            ans = 1;
            count++;
        }
        else if (count > 2)
        {

        }
        else
        {
            ans = (ans * 10) + 1;
            count++;

        }


    }
    public void TextChangeTo2()
    {
        if (count == 1)
        {
            ans = 2;
            count++;
        }
        else if (count > 2)
        {

        }
        else
        {
            ans = (ans * 10) + 2;
            count++;

        }
    }
    public void TextChangeTo3()
    {
        if (count == 1)
        {
            ans = 3;
            count++;
        }
        else if (count > 2)
        {

        }
        else
        {
            ans = (ans * 10) + 3;
            count++;

        }
    }
    public void TextChangeTo4()
    {
        if (count == 1)
        {
            ans = 4;
            count++;
        }
        else if (count > 2)
        {

        }
        else
        {
            ans = (ans * 10) + 4;
            count++;

        }
    }
    public void TextChangeTo5()
    {
        if (count == 1)
        {
            ans = 5;
            count++;
        }
        else if (count > 2)
        {

        }
        else
        {
            ans = (ans * 10) + 5;
            count++;

        }
    }
    public void TextChangeTo6()
    {
        if (count == 1)
        {
            ans = 6;
            count++;
        }
        else if (count > 2)
        {

        }
        else
        {
            ans = (ans * 10) + 6;
            count++;

        }
    }
    public void TextChangeTo7()
    {
        if (count == 1)
        {
            ans = 7;
            count++;
        }
        else if (count > 2)
        {

        }
        else
        {
            ans = (ans * 10) + 7;
            count++;

        }
    }
    public void TextChangeTo8()
    {
        if (count == 1)
        {
            ans = 8;
            count++;
        }
        else if (count > 2)
        {

        }
        else
        {
            ans = (ans * 10) + 8;
            count++;

        }
    }
    public void TextChangeTo9()
    {
        if (count == 1)
        {
            ans = 9;
            count++;
        }
        else if (count > 2)
        {

        }
        else
        {
            ans = (ans * 10) + 9;
            count++;

        }
    }

    public void TextChangeTo0()
    {
        if (count == 1)
        {
            ans = 0;
            count++;
        }
        else if (count > 2)
        {

        }
        else
        {
            ans = (ans * 10) + 0;
            count++;

        }
    }
    public void Enter()
    {


        if (ans == rans)
        {
            corr.text = "CORRECT";

            StartCoroutine(delay());

        }
        else
        {
            corr.text = "INCORRECT";
            StartCoroutine(Incorrectans());
        }
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(1);
        ans = 0;
        count = 1;
        corr.text = "";
        newques();
    }
    public void newques()
    {
        x = 0;
        count = 1;
        a = Random.Range(3, 100);
        b = 100;
        while (a%b>0)
        {

            a = Random.Range(3, 100);
            b = Random.Range(2, 100);
            
        }
       
    }
    IEnumerator Incorrectans()
    {
        yield return new WaitForSeconds(1);
        ans = 0;
        count = 1;
        corr.text = "";
        x++;

    }
    IEnumerator Solution()
    {
        yield return new WaitForSeconds(2);
        ans = 0;
        count = 1;
        corr.text = "";
        x = 0;
        newques();
    }

}
