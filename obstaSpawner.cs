using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaSpawner : MonoBehaviour {
    
   
    public GameObject YY;
    public GameObject BB;

    public GUIText scoreText;
    private int score;


    public float spawncheck,spawnlag;
	// Use this for initialization
	void Start () {
        spawncheck = 0;
        score= 0;



    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time > spawncheck)
        {
            
            for (float x= -2.8f; x < 2.9f; x+=0.7f)
            {
                int j = Random.Range(0, 2);
                while (j== 0)
                {
                    spawn(YY, x);
                    j = Random.Range(0, 2);
                }
                int k = Random.Range(0, 2);
                while (k == 0)
                {
                    spawn(BB, x);
                    k = Random.Range(0, 2);
                }
                   


                
            }
            spawncheck = Time.time + spawnlag;
        }
	}
    void spawn(GameObject body,float x)
    {
        Vector3 position = new Vector3(x,4, 0);
        Instantiate(body, position , Quaternion.identity);
    }
}
