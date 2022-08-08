using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duplication : MonoBehaviour
{
    public GameObject bCellPrefab;
    private Vector2 refVector;
    private GameObject newCell;
    public bool haveSpawned;
    public static List<GameObject> bCellList = new List<GameObject>();
    

    

    // Start is called before the first frame update
    void Start()
    {
        haveSpawned = false;
    }

    // Update is called once per frame
    // if a mammalian cell instantaneously comes into contact with multiple bacterial cells then they all get turned into children of the mammalian cell
    //causing many bacteria to be spawned from the same co-ordinates which causes a lag spike and is not accurate to the model
    void Update()
    {
        if (haveSpawned == false) {
            if (gameObject.GetComponent<Collider2D>().enabled == false) {
                GameObject mammalianCell = gameObject.transform.parent.gameObject; 
                refVector = mammalianCell.GetComponent<Rigidbody2D>().velocity;
                int infectionCount = mammalianCell.transform.childCount;
                if (infectionCount == 1) {
                    if (mammalianCell.GetComponent<Rigidbody2D>().simulated == false && mammalianCell.tag != "UnaffectedMammalianCell") {  
                        mammalianCell.GetComponent<Collider2D>().enabled = false;
                        for (int i = 0; i < StaticVar.dupeNum; ++i) {
                            newCell = Instantiate(bCellPrefab);
                            newCell.transform.position = mammalianCell.transform.position;
                            var rb = newCell.GetComponent<Rigidbody2D>();
                            newCell.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                            newCell.GetComponent<Collider2D>().enabled = true;
                            rb.velocity = refVector; 
                            rb.isKinematic = false; 
                            bCellList.Add(newCell); 
                        }
                        haveSpawned = true;
                    }
                }
                
            }
        }
    }
}
