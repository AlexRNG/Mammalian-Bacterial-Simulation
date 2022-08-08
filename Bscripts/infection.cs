using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infection : MonoBehaviour
{
    private float redCount;
    private float greenCount;
    private float deathCount;
    private float fadeCount;
    private int infectionChance;
    private int random;
    private bool haveAdded;

    // Start is called before the first frame update
    void Start()
    {
        infectionChance = StaticVar.infectionPercentage;
        redCount = 1;
        greenCount = 1;
        deathCount = 2;
        fadeCount = 1;

    }
    void Awake()
    {
        random = Random.Range(1, 100);
    }

// Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<Collider2D>().enabled == false)
        {
                      
            if (random < infectionChance)
            {
                GameObject mammalianCell = gameObject.transform.parent.gameObject; 
                mammalianCell.tag = "InfectedMammalianCell";
                mammalianCell.GetComponent<SpriteRenderer>().color = new Color(1, redCount, redCount, 1);
                redCount -= Time.deltaTime;
                if (redCount < 0)
                {
                    redCount = 0;
                }
                // killing the Mammalian cell
                deathCount -= Time.deltaTime;
                if (redCount == 0)
                {
                    mammalianCell.GetComponent<SpriteRenderer>().color = new Color(1, redCount, redCount, fadeCount);
                    fadeCount -= Time.deltaTime;
                    if (fadeCount < 0)
                    {
                        mammalianCell.GetComponent<Rigidbody2D>().simulated = false;
                        mammalianCell.GetComponent<Collider2D>().enabled = false;
                    }
                }
            }
            else if (random > infectionChance)
            {
                
                GameObject mammalianCell = gameObject.transform.parent.gameObject;
                mammalianCell.tag = "UnaffectedMammalianCell";
                mammalianCell.GetComponent<SpriteRenderer>().color = new Color(greenCount, 1, greenCount, 1);
                greenCount -= Time.deltaTime;
                if (greenCount < 0)
                {
                    greenCount = 0;
                }
            }
        }
    }
}
