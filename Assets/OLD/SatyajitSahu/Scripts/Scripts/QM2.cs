using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QM2 : MonoBehaviour
{
    public List<QnA2> QnA;
    public GameObject[] options;
    public int currentQuestion;

    int j = 0;

    public GameObject correctPanel;
    public GameObject wrongPanel;

    public GameObject qImage;

    public GameObject allDone;

    public GameObject button;
    public GameObject button1;

    public GameObject tick;
    public GameObject cross;

    public GameObject Quizpanel;
    public GameObject questionText;

    public Text QuestionTxt; //Change

    int totalQuestions = 0;

    private void Start()
    {
        /*totalQuestions = QnA.Count;
        generateQuestion();*/
    }

    private void OnEnable()
    {
        
        currentQuestion = 0;
        totalQuestions = QnA.Count;
        generateQuestion();

        button.SetActive(true);
        button1.SetActive(true);
        
        Quizpanel.SetActive(true);
        questionText.SetActive(true);
        qImage.SetActive(true);
    }

    private void OnDisable()
    {
        correctPanel.SetActive(false);
        wrongPanel.SetActive(false);

        qImage.SetActive(false);

        allDone.SetActive(false);

        button.SetActive(false);
        button1.SetActive(false);

        tick.SetActive(false);
        cross.SetActive(false);

        Quizpanel.SetActive(false);
        questionText.SetActive(false);

    }

    void GameOver()
    {
        Quizpanel.SetActive(false);
        questionText.SetActive(false);
        allDone.SetActive(true);
    }

    public void correct()
    {
        QnA.RemoveAt(currentQuestion);

        button.SetActive(false);
        button1.SetActive(false);

        tick.SetActive(false);
        cross.SetActive(false);

        StartCoroutine(waitForNext());
    }

    IEnumerator waitForNext()
    {
        yield return new WaitForSeconds(2);

        button.SetActive(true);
        button1.SetActive(true);

        tick.SetActive(true);
        cross.SetActive(true);

        correctPanel.SetActive(false);
        generateQuestion();

        qImage.SetActive(true);
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AS2>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Image>().sprite = QnA[currentQuestion].Answers[i]; //Change

            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AS2>().isCorrect = true;
                
                
            }
        }
    }

    void generateQuestion()
    {
        if (QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);

            QuestionTxt.GetComponent<Text>().text = QnA[currentQuestion].Question; //Change
            SetAnswers();
            j++;
        }
        else
        {
            Debug.Log("Out of Questions");
            GameOver();

            Destroy(qImage);
            Destroy(button);
            Destroy(button1);
        }


    }
}
