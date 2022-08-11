using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DQuestionChanger : MonoBehaviour
{
    public GameObject q1;
    public GameObject q2;

    public void QChange()
    {
        q1.SetActive(false);
        q2.SetActive(true);
    }
}
