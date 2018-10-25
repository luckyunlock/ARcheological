using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour {

    int seconds_remained = 10;
    public Text countDown_text;
    public Text question_text;
    public GameObject question_set_gameObject;
    public QuesiteSet question_set;
    public MyTriple currentQuestion;
    public GameObject papyrManager_gameObject;
    public PapyrManager papyrManager;

    // Use this for initialization
    void Start () {
        question_set = (QuesiteSet)question_set_gameObject.GetComponent(typeof(QuesiteSet));
        if (question_set == null) Debug.Log("Error in quesite set on CountDownManager");

        papyrManager = (PapyrManager)papyrManager_gameObject.GetComponent(typeof(PapyrManager));
        if (papyrManager == null) Debug.Log("Error retriving PapyrManager for questionManager");

        //Get the question and display it
        currentQuestion = question_set.getCurrentQuestion();
        dispayQuestion();

    }

    public void startCountDown(){ 
        seconds_remained = 10; 
        InvokeRepeating("decreaseCountDown", 1.0f, 1.0f);
    }
    public void stopCountDown(){ CancelInvoke(); }

    private void decreaseCountDown(){
        if (seconds_remained == -1){ //Notify who needs it
            papyrManager.displayResult();
            question_set.registerAttempt();
            CancelInvoke();
        }
        else{
            countDown_text.text = ""+seconds_remained;
            seconds_remained--;
        }
    }

    private void dispayQuestion(){
        question_text.text = currentQuestion.q;
    }

    public void forwardResponse(string opt){
        currentQuestion = question_set.registerResponse(opt);
        if (currentQuestion != null)
            dispayQuestion();
        else
            papyrManager.displayResult();
    }

}
