using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmitResponse : MonoBehaviour {
    public string opt;
    public GameObject questionManager_gameObject;
    public QuestionManager questionManager;
    public Button button;


    // Use this for initialization
    void Start(){
        questionManager = (QuestionManager)questionManager_gameObject.GetComponent(typeof(QuestionManager));
        if (questionManager == null) Debug.Log("Error retriving questionManager for SubmitResponde " + opt);
        button.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick(){ questionManager.forwardResponse(opt); }
}