using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionhandler : MonoBehaviour {
    public GameObject plusone;
	void Explode()
    {
        
        Instantiate(plusone, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);

    }
}
