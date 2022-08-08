using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dupeFix : MonoBehaviour
{
    private bool hasSpawned;
    private bool hasSurvived;
    private int dupeNum;
    private GameObject newCell;
    public GameObject bCellPrefab;
    // Start is called before the first frame update
    void Start()
    {
        hasSpawned = false;
        dupeNum = StaticVar.dupeNum;
    }

    // Update is called once per frame
    void Update()
    {
        var childCount = gameObject.transform.childCount;
        var refVector = gameObject.GetComponent<Rigidbody2D>().velocity; 
        if (gameObject.GetComponent<Rigidbody2D>().simulated == false) {
            if (childCount > 1 && hasSpawned == false) {
                for (int i = 0; i < dupeNum; ++i) {
                    newCell = Instantiate(bCellPrefab);
                    newCell.transform.position = gameObject.transform.position;
                    var rb = newCell.GetComponent<Rigidbody2D>();
                    newCell.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                    newCell.GetComponent<Collider2D>().enabled = true;
                    rb.velocity = refVector; 
                    rb.isKinematic = false;  
                 }
                 hasSpawned = true;
            }
        }
        if (hasSpawned == false && gameObject.transform.childCount >= 1) {
            StaticVar.infectionCount += 1;
            hasSpawned = true;
        }

    }
}