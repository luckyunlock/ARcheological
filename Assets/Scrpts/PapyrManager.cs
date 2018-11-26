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

    public GameObject fail;
    public GameObject chestCollider;
    public GameObject chestTop;
    public TapChest tapChest;
    public bool isOpen= false;


    // Use this for initialization
    void Awake(){
        questionManager = (QuestionManager)questionManager_gameObject.GetComponent(typeof(QuestionManager));
        if (questionManager == null) Debug.LogError("Error retriving questionManager for PapyrManager");
        tapChest = (TapChest)chestCollider.GetComponent(typeof(TapChest));
        if (tapChest == null) Debug.LogError("Error retriving TapChest for PapyrManager");
    }

    public void openPapyr(){

        this.gameObject.SetActive(true);
        duringQuestions.SetActive(true);
        afterQuestions.SetActive(false);
        questionManager.startCountDown();

        questionManager.dispayQuestion();
        isOpen = true;
    }
    public void displayResult(){
        resultText.text = "Your result is:\n" + questionManager.question_set.getCurrentScore();
        this.gameObject.SetActive(true);
        duringQuestions.SetActive(false);
        afterQuestions.SetActive(true);
        questionManager.question_set.registerAttempt();

    }
    public void closePapyr(){
        isOpen = false;
        questionManager.resetSecondsRemained();
        questionManager.stopCountDown();
        this.gameObject.SetActive(false);
        duringQuestions.SetActive(false);
        afterQuestions.SetActive(false);

        fail.SetActive(false);

        if (questionManager.getStatus() == Status.Successed){
            Destroy(chestCollider);
        }
            
        if (questionManager.getStatus()==Status.Failed){
            fail.SetActive(true);
            Destroy(chestCollider);
            tapChest.closeChest();
        }

        if (questionManager.getStatus() == Status.Tried){
            tapChest.closeChest();
        }
    }


}
