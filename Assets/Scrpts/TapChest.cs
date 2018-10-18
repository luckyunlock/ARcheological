using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapChest : MonoBehaviour {

    // Use this for initialization
    public GameObject chest_top;
    public GameObject papyr;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseDown(){
        // this object was clicked - do something
        chest_top.transform.Translate(new Vector3(0, (float)0.028, (float)-0.014));
        chest_top.transform.Rotate(-90, 0, 0);
        Destroy(this.gameObject);
        //yield return new WaitForSeconds(1);
        papyr.SetActive(true);
    }
}
