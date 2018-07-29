using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movmentred : MonoBehaviour {
    float timecheck;
	// Use this for initialization
	void Start () {
        timecheck = Time.time;
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.down * Time.deltaTime*5, Space.World);
        if (Time.time > timecheck + 5f)
        {
            Destroy(gameObject);
        }
    }
  

}
