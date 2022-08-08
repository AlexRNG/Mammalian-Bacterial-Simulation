using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bCellSpawn : MonoBehaviour
{
    public GameObject bCellPrefab;
    private Vector2 spawnPoint;
    private Camera cam;

    public List<GameObject> cellList = new List<GameObject>();

    // Number of cells to be spawned
    private int numOfBCells;
    

    // Variables
    GameObject newCell;


    void Start() {
        numOfBCells = StaticVar.bNum;
        cam = FindObjectOfType<Camera>();
        float randomXPos;
        float randomYPos;
        float xV;
        float yV;
        
        for (int i = 0; i < numOfBCells; ++i) { // repeats for however many cells need to be spawned

            randomXPos = Random.Range(-cam.orthographicSize, cam.orthographicSize);
            randomYPos = Random.Range(-cam.orthographicSize, cam.orthographicSize);
            xV = Random.Range(-5, 5);
            yV = Random.Range(-5, 5);

            
            spawnPoint = new Vector2(randomXPos, randomYPos); // uses the random x and y coordinates to generate a spawn vector

            newCell = Instantiate(bCellPrefab);
            newCell.transform.position = spawnPoint;
            var rb = newCell.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(xV, yV);
        }
    }
}
