using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D characterx;
    public float charactersp = 4f;

    public GameObject toGateA;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        characterx.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * charactersp;
    }

   
}
