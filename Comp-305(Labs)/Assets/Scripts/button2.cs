using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button2 : MonoBehaviour {
    public GameObject Default;
    public Sprite show;
    public Sprite firstImage;
    public Sprite secondImage;
    public Sprite thirdImage;

    private Rigidbody2D rbody;
    private SpriteRenderer sRend;

    // Use this for initialization
    void Start () {
        rbody = Default.GetComponent<Rigidbody2D>();
        sRend = Default.GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        if (sRend.sprite == firstImage)
        { sRend.sprite = secondImage; }
        else { }
    }
}
