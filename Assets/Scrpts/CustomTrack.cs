using UnityEngine;
using System.Collections;

public class CustomTrack : MonoBehaviour
{
    void OnMarkerFound(ARMarker marker)
    {
        Debug.Log("MARKER FOUND! WHEEEE!");
    }

    void OnMarkerLost(ARMarker marker)
    {
        Debug.Log("MARKER LOST! WHEEEE!");
    }

    void OnMarkerTracked(ARMarker marker)
    {
        Debug.Log("MARKER TRACKED! WHEEEE!");
    }
}