using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public int score = 100;
    public Text scoreText;
    public float speed = 100f;
    public float distance = 5000f;
    private bool ismovefwrd = true;
    public Vector3 inpos;
    public Rigidbody rb;

    void Start()
    {
        scoreText = GameObject.Find("scoretext").GetComponent<Text>();
        inpos = transform.position;
    }

    
    void Update()
    {
        scoreText.text = " " + score.ToString();

        if(ismovefwrd)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        else
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        
        
        if(Vector3.Distance(inpos, transform.position) >= distance)
        {
            ismovefwrd = !ismovefwrd;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("obj"))
        {
            score--;

            //Vector3 reflection = Vector3.Reflect(rb.velocity.normalized, col.contacts[0].normal);
            //rb.velocity = reflection * rb.velocity.magnitude;
        }


    }
}
