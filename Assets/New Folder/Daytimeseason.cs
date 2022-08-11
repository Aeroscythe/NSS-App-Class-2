using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daytimeseason : MonoBehaviour
{

    public GameObject days, months, seasons,main;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Days()
    {
        main.SetActive(false);
        days.SetActive(true);


    }public void Months()
    {
        main.SetActive(false);
        months.SetActive(true);


    }public void Seasons()
    {
        main.SetActive(false);
        seasons.SetActive(true);


    }public void Main()
    {
        main.SetActive(true);
        seasons.SetActive(false);
        days.SetActive(false);
        months.SetActive(false);


    }
}
