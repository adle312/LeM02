using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gate : MonoBehaviour
{

    public GameObject Tothegate;
    //public GameObject BacktoGate;
    public GameObject characterx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "character")
        {
            StartCoroutine(Moving());
            //StartCoroutine(Goback());
        }
    }

    IEnumerator Moving()
    {
        yield return new WaitForSeconds(0.5f);
        characterx.transform.position = new Vector2(Tothegate.transform.position.x + 2.0f, Tothegate.transform.position.y);

    }

    
}
