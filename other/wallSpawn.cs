using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallSpawn : MonoBehaviour
{
    public GameObject sideWallPrefab;
    public GameObject bottomWallPrefab;
    public Camera cam;
    public Vector2 spawnPoint;
    GameObject newWall;

    void Start()
    {
        cam = FindObjectOfType<Camera>();


        // top wall
        newWall = Instantiate(bottomWallPrefab);
        spawnPoint = (new Vector2(0, (1/2 + cam.orthographicSize)));
        newWall.transform.position = spawnPoint;
        newWall.tag = "wall";

        // bottom wall
        newWall = Instantiate(bottomWallPrefab);
        spawnPoint = (new Vector2(0, (-1/2-cam.orthographicSize)));
        newWall.transform.position = spawnPoint;
        newWall.tag = "wall";

        // right wall
        newWall = Instantiate(sideWallPrefab);
        spawnPoint = (new Vector2((1 / 2 + cam.orthographicSize), 0));
        newWall.transform.position = spawnPoint;
        newWall.tag = "wall";

        // top wall
        newWall = Instantiate(sideWallPrefab);
        spawnPoint = (new Vector2((-1 / 2 - cam.orthographicSize), 0));
        newWall.transform.position = spawnPoint;
        newWall.tag = "wall";
    }

}
