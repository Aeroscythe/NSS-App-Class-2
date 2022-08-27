using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelChanger : MonoBehaviour
{
    public GameObject q1;
    public GameObject q2;
    public GameObject q3;
    public GameObject q4;
    public GameObject q5;

    public GameObject coneCorrect;
    public GameObject cubeCorrect;
    public GameObject sphereCorrect;
    public GameObject cuboidCorrect;
    public GameObject cylinderCorrect;

    public GameObject correct;
    public GameObject wrong;

    public void ConeCorrect()
    {
        q1.SetActive(false);
        coneCorrect.SetActive(true);
    }
    public void CubeCorrect()
    {
        q2.SetActive(false);
        cubeCorrect.SetActive(true);
    }
    public void SphereCorrect()
    {
        q3.SetActive(false);
        sphereCorrect.SetActive(true);
    }
    public void CuboidCorrect()
    {
        q4.SetActive(false);
        cuboidCorrect.SetActive(true);
    }
    public void CylinderCorrect()
    {
        q5.SetActive(false);
        cylinderCorrect.SetActive(true);
    }

    public void Q1()
    {
        q1.SetActive(false);
        q2.SetActive(true);
        correct.SetActive(false);
        coneCorrect.SetActive(false);
    }
    public void Q2()
    {
        q2.SetActive(false);
        q3.SetActive(true);
        correct.SetActive(false);
        cubeCorrect.SetActive(false);
    }
    public void Q3()
    {
        q3.SetActive(false);
        q4.SetActive(true);
        correct.SetActive(false);
        sphereCorrect.SetActive(false);
    }
    public void Q4()
    {
        q4.SetActive(false);
        q5.SetActive(true);
        correct.SetActive(false);
        cuboidCorrect.SetActive(false);
    }
    /*public void Q5()
    {
        q5.SetActive(false);
        //q5.SetActive(true);
        correct.SetActive(false);
        cuboidCorrect.SetActive(false);
    }*/


    public void Correct()
    {
        correct.SetActive(true);
    }
    public void WrongActive()
    {
        wrong.SetActive(true);
    }
    public void WrongLazy()
    {
        wrong.SetActive(false);
    }
}
