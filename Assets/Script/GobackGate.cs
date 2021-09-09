using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GobackGate : MonoBehaviour
{

    public GameObject returnMainA;
    public GameObject maincharacter2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D (Collider2D gobackA)
    {
        if (gobackA.gameObject.tag == "character")
        {
            StartCoroutine(BackA());
        }
    }

    IEnumerator BackA()
    {
        yield return new WaitForSeconds(0.5f);
        maincharacter2.transform.position = new Vector2(returnMainA.transform.position.x, returnMainA.transform.position.y - 2.0f); 
    }
}
