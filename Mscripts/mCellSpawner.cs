using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class mCellSpawner : MonoBehaviour
{
    public GameObject mCellPrefab;
    public Vector2 spawnPoint;
    private Camera cam;

    // List of GameObjects which will contain cells
    public static List<GameObject> mCellList = new List<GameObject>();

    // Number of cells to be spawned
    private int numOfCells;
    private float dist;
    

    // Variables
    GameObject newCell;


    void Start() {
        numOfCells = StaticVar.mNum;
        cam = FindObjectOfType<Camera>();
        float randomXPos;
        float randomYPos;
        float xV;
        float yV;
        
        for (int i = 0; i < numOfCells; ++i) { // repeats for however many cells need to be spawned
            randomXPos = Random.Range(-cam.orthographicSize, cam.orthographicSize);
            randomYPos = Random.Range(-cam.orthographicSize, cam.orthographicSize);
            dist = Mathf.Sqrt(randomXPos * randomXPos + randomYPos * randomYPos);
            xV = Random.Range(-4, 4);
            yV = Random.Range(-4, 4);

            spawnPoint = new Vector2(randomXPos, randomYPos); // uses the random x and y coordinates to generate a spawn vector

            newCell = Instantiate(mCellPrefab);
            newCell.transform.position = spawnPoint;

            var rb = newCell.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(xV, yV);
            mCellList.Add(newCell);
        }
    }
}
