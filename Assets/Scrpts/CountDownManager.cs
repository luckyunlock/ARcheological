using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownManager : MonoBehaviour {

    int seconds_remained = 10;
    public Text countDown_text;
    public GameObject question_set_gameObject;
    public QuesiteSet question_set;

    // Use this for initialization
    void Start () {
        question_set = (QuesiteSet)question_set_gameObject.GetComponent(typeof(QuesiteSet));
        if (question_set == null) Debug.Log("Error in quesite set on CountDownManager");
        InvokeRepeating("decreaseCountDown", 1.0f, 1.0f);
    }


    void decreaseCountDown(){
        if (seconds_remained == -1){ //Notify who needs it
            question_set.registerAttempt();
            CancelInvoke();
        }else{
            countDown_text.text = ""+seconds_remained;
            seconds_remained--;
        }
    }

    // Update is called once per frame
    void Update () {}
}
