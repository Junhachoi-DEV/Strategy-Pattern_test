using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float speed;

    float x;
    float y;

    Rigidbody2D rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");    
        y = Input.GetAxisRaw("Vertical");

        if(Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            transform.Translate(new Vector3(x, y, 0).normalized * speed * Time.deltaTime);
        }
    }
}
