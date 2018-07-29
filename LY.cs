using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LY : MonoBehaviour {

    int counterposition;
    float colorcheck;
    bool coloreff;

    Renderer rend;

    // Use this for initialization
    void Start()
    {
        counterposition = 0;
        rend = GetComponent<Renderer>();
        rend.material.SetColor("_Color", Color.yellow);

    }

    // Update is called once per frame
    void Update()
    {
        colorcheck -= 0.5f;
        if (counterposition != 0)
        {
            //transform.Translate(Vector3.up * Time.deltaTime * counterposition*0.5f, Space.World);
            //rend.material.SetColor("_Color", Color.yellow);
            transform.localPosition += Vector3.up * 0.15f * counterposition*-1;
            counterposition = 0;
            Debug.Log(transform.position.y);
        }
        if (colorcheck < 0 && coloreff == true)
        {
            rend.material.SetColor("_Color", Color.yellow);
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "deloncont")
        {
            Destroy(collision.gameObject);
            counterposition += 1 ;
            rend.material.color = new Color(0, 0, 0, 0);
            colorcheck = 2;
            coloreff = true;

        }
        if (collision.gameObject.tag == "remun")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "doco")
        {
            Destroy(collision.gameObject);
            counterposition -= 1;
            rend.material.color = new Color(0, 0, 0, 0);
            colorcheck = 2;
            coloreff = true;

        }
    }
}

