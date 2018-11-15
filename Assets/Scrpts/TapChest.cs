using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapChest : MonoBehaviour {

    // Use this for initialization
    public GameObject chest_top;
    public GameObject papyr;
    public PapyrManager papyrManager;

    public Vector3 initialPosition;
    public Quaternion initialRotation;

    void Start () {
        initialPosition = chest_top.transform.position;
        initialRotation = chest_top.transform.rotation;
        papyrManager = (PapyrManager) papyr.GetComponent(typeof(PapyrManager));
        if (papyrManager == null) Debug.Log("PapirManager on chest is broken!");
    }
	
    void OnMouseDown(){
        // this object was clicked - do something
        this.openChest();
        papyrManager.openPapyr(initialPosition,initialRotation);

    }

    public void openChest(){
        chest_top.transform.Translate(new Vector3(0, (float)0.028, (float)-0.014));
        chest_top.transform.Rotate(-90, 0, 0);
    }

    public void closeChest(){
        chest_top.transform.position = initialPosition;
        chest_top.transform.rotation = initialRotation;
    }
}
