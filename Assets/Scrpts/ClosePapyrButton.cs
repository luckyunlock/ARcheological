using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClosePapyrButton : MonoBehaviour{
    public GameObject papyrManager_gameObject;
    public PapyrManager papyrManager;
    public Button button;


    // Use this for initialization
    void Start()
    {
        papyrManager = (PapyrManager)papyrManager_gameObject.GetComponent(typeof(PapyrManager));
        if (papyrManager == null) Debug.Log("Error retriving PapyrManager for ClosePapyrButton ");
        button.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick() { papyrManager.closePapyr(); }
}