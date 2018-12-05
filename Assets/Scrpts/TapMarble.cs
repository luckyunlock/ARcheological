using UnityEngine;
using System.Collections;

public class TapMarble : MonoBehaviour{
    public GameObject marble;

    void OnMouseDown(){
        // this object was clicked - do something
        marble.SetActive(true);
    }

}
