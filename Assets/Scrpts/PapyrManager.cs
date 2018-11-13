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

    public GameObject success;
    public GameObject fail;
    public GameObject retriable;
    public GameObject chestCollider;
    public GameObject chestTop;

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
        questionManager.question_set.registerAttempt();

    }
    public void closePapyr(){
        questionManager.stopCountDown();
        this.gameObject.SetActive(false);
        duringQuestions.SetActive(false);
        afterQuestions.SetActive(false);

        success.SetActive(false);
        fail.SetActive(false);
        retriable.SetActive(false);
        Debug.Log("Lo stato è:\n");
        Debug.Log(questionManager.getStatus().ToString());
        if (questionManager.getStatus() == Status.Successed){
            success.SetActive(true);
            Destroy(chestCollider);
        }
            
        if (questionManager.getStatus()==Status.Failed){
            fail.SetActive(true);
            Destroy(chestCollider);
            chestTop.transform.position = new Vector3(0, 0, 0);
            //chestTop.transform.Translate(new Vector3(0, (float)-0.028, (float)0.014));
            chestTop.transform.Rotate(90, 0, 0);
        }

        if (questionManager.getStatus() == Status.Tried){
            retriable.SetActive(true);
            chestTop.transform.Translate(new Vector3(0, (float)-0.028, (float)0.014));
            chestTop.transform.Rotate(90, 0, 0);
        }
    }



}
