using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeOut : MonoBehaviour
{

    private float count;
    void Start()
    {
        count = 1;
    }
    void Update()
    {
        if (gameObject.GetComponent<Collider2D>().enabled == false)
        {  
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, count);
            count -= (Time.deltaTime * 2);
        }
    }
}
