using UnityEngine;
using System.Collections;

public class CustomTrack : MonoBehaviour
{
    public string value;
    public GameObject questionManager_gameObject;
    public QuestionManager questionManager;
    private bool isLocked = false;

    void Awake(){
        questionManager = (QuestionManager)questionManager_gameObject.GetComponent(typeof(QuestionManager));
        if (questionManager == null) Debug.LogError("Error retriving questionManager for CustomTrack");
    }
    /*
    void OnMarkerFound(ARMarker marker)
    {
        Debug.Log("MARKER FOUND! WHEEEE!");
    }


    void OnMarkerLost(ARMarker marker)
    {
        Debug.Log("MARKER LOST! WHEEEE!");
    }
    */

    private void unlock(){
        isLocked = false;
        CancelInvoke();
    }

    void OnMarkerTracked(ARMarker marker){
        if(isLocked != true){
            isLocked = true;
            questionManager.forwardResponse(value);
            InvokeRepeating("unlock", 3.0f, 1.0f);
        }


    }


}