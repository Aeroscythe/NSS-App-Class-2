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

    public Text finalnum;
    public Text remark;
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
        finalnum.text = UnityEngine.Random.Range(0,100).ToString();
        num1.text = "";
        num2.text = "";
    }

    public void OnEnter()
    {
        if((Int32.Parse(num1.text)+Int32.Parse(num2.text))==Int32.Parse(finalnum.text))
        {
            remark.text = "Correct!";
            reinstantiate();
        }
        else
        {
            remark.text = "Incorrect!";
            num1.text = "";
            num2.text = "";
        }
    }
}
