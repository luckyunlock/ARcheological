using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.UI;

public class PapyrManager : MonoBehaviour
{
    public GameObject duringQuestions;
    public GameObject afterQuestions;
    public GameObject questionManager_gameObject;
    public Text resultText;
    public QuestionManager questionManager;

    // Use this for initialization
    void Awake(){

        questionManager = (QuestionManager)questionManager_gameObject.GetComponent(typeof(QuestionManager));
        if (questionManager == null) Debug.LogError("Error retriving questionManager for PapyrManager");
    }

    public void openPapyr(){
        this.gameObject.SetActive(true);
        duringQuestions.SetActive(true);
        afterQuestions.SetActive(false);
        questionManager.startCountDown();
    }
    public void displayResult(){
        resultText.text = "Your result is:\n" + questionManager.question_set.getCurrentScore();
        this.gameObject.SetActive(true);
        duringQuestions.SetActive(false);
        afterQuestions.SetActive(true);

    }
    public void closePapyr(){
        this.gameObject.SetActive(false);
        duringQuestions.SetActive(false);
        afterQuestions.SetActive(false);
        questionManager.stopCountDown();
    }



}
