using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCam : MonoBehaviour
{
    public GameObject cameraOn;
    public GameObject cameraOff;
    public bool camOn;
    public int cameraNumber;

    void Start()
    {
        cameraNumber = 1;

    }
     void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            cameraOn.SetActive(true);
            cameraOff.SetActive(false);

        }
    }

}
