using UnityEngine;
using System.Collections;

public class MarkerManager : MonoBehaviour
{

    public GameObject ARToolKit;
    public ARMarker yes;
    public ARMarker no;


    // Use this for initialization
    void Start(){

        Component[] markers;

        markers = GetComponents(typeof(ARMarker));

        Debug.Log(markers.Length);
        foreach (ARMarker m in markers)
        {
            if (m.name == "hiro")
                Debug.Log("hiro found");
            else
                Debug.Log("hiro not found");
        }

        /*
        yes = (ARMarker)question_set_gameObject.GetComponent(typeof(ARMarker));
        if (yes == null) Debug.Log("Error in yes set on MarkerManager");
        question_set = (QuesiteSet)question_set_gameObject.GetComponent(typeof(QuesiteSet));
        if (question_set == null) Debug.Log("Error in quesite set on CountDownManager");
        question_set = (QuesiteSet)question_set_gameObject.GetComponent(typeof(QuesiteSet));
        if (question_set == null) Debug.Log("Error in quesite set on CountDownManager");*/
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void f(){

    }

   
}
