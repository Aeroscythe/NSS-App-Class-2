using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class multiplication : MonoBehaviour
{
    int a, b, count, ans, rans;
    public Text v1, v2, corr, wron, alld;
    public Text answer;
    // Start is called before the first frame update
    void Start()
    {

        count = 1;
        a = Random.Range(0, 10);
        b = Random.Range(0, 10);
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
        rans = a * b;

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
            ans = 0;
            count = 1;
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

        count = 1;
        a = Random.Range(0, 10);
        b = Random.Range(0, 10);
    }


}
