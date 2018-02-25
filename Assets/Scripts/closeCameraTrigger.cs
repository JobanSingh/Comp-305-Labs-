using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeCameraTrigger : MonoBehaviour {
    public Camera mainCamera;
    public Camera cameraCloseUp;
    // Use this for initialization

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player3")
        {
            mainCamera.enabled = false;
            cameraCloseUp.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other
        )
    {
        if (other.gameObject.tag == "Player3")
        {
            mainCamera.enabled = true;
            cameraCloseUp.enabled = false;
        }

    }
}
