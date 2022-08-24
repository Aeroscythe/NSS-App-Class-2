using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class IdentifyMultiple : MonoBehaviour
{
    int selected;
    int numGenerated;
    int wrongCnt;
    int indexAdded;
    bool multipleAdded;
    int temp;

    public Button[] options;
    public Text qsn;
    void OnEnable()
    {
        UpdatePanel();
    }

    int rndNum(int upperLimit)
    {
        return UnityEngine.Random.Range(2,upperLimit);
    }
    void UpdatePanel()
    {
        wrongCnt = 0;
        multipleAdded = false;
        indexAdded = 5;

        numGenerated = rndNum(100);

        qsn.text = "Identify the multiple of " + numGenerated;
        qsn.color = Color.black;
        for (int i = 0; i < 4; i++)
        {
            if (!multipleAdded)
            {
                temp = rndNum(15) * numGenerated;
                indexAdded = UnityEngine.Random.Range(0, 4);
                options[indexAdded].GetComponentInChildren<Text>().text = temp.ToString();
                multipleAdded = true;
            }
            if (i != indexAdded)
                options[i].GetComponentInChildren<Text>().text = rndNum(500).ToString();
        }
    }

    public void ExtractText(GameObject obj)
    {
        selected = Int32.Parse(obj.GetComponentInChildren<Text>().text);
        Check();
    }

    IEnumerator Correct()
    {
        qsn.text = "CORRECT!";
        qsn.color = Color.green;
        yield return new WaitForSeconds(0.5f);
        UpdatePanel();
    }

    IEnumerator Wrong()
    {
        qsn.text = "WRONG, TRY AGAIN!";
        qsn.color = Color.red;
        yield return new WaitForSeconds(0.5f);
        qsn.text = "Identify the multiple of " + numGenerated;
        qsn.color = Color.black;
    }

    IEnumerator ShowCorrect()
    {
        options[indexAdded].image.color = Color.green;
        yield return new WaitForSeconds(1.5f);
        options[indexAdded].image.color = Color.white;
        UpdatePanel();
    }

    void Check()
    {
        if (selected%numGenerated==0)
        {
            StartCoroutine(Correct());
        }
        else if(wrongCnt<2)
        {
            StartCoroutine(Wrong());
            wrongCnt++;
        }
        else
        {
            StartCoroutine(ShowCorrect());
        }
    }

}
