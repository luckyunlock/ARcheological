using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmitResponse : MonoBehaviour {
    public string opt;
    public GameObject question_set_gameObject;
    public QuesiteSet question_set;
    public Button button;

    // Use this for initialization
    void Start(){
        question_set = (QuesiteSet)question_set_gameObject.GetComponent(typeof(QuesiteSet));
        if (question_set == null) Debug.Log("Error in quesite set on SubmitResponde " + opt);

        button.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update(){}

    void TaskOnClick(){
        question_set.registerResponse(question_set.getCurrentID(), opt);
    }
}