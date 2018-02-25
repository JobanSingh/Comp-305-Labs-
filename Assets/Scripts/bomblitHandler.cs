using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomblitHandler : MonoBehaviour
{
    public GameObject explosion;

    private void Start()
    {
        Invoke("Explode", 3.0f);

    }

    void Explode()
    {
        Instantiate(explosion, this.transform.position, this.transform.rotation);
    }
}
