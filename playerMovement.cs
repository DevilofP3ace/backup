using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
    Rigidbody2D player;
    public float speed;


	// Use this for initialization
	void Start () {
        player = GetComponent<Rigidbody2D>();
		
	}

    // Update is called once per frame
    private void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,-2.5f,2.5f), 0, 0);
    }
    void FixedUpdate () {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        player.velocity = new Vector3(h*speed, v*speed, 0);
    }
}
