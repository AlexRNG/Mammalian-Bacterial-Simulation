using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    private Scene currentScene; 
    private int infectedCellCount;
    private bool gameEnd;
    private string scene;
    private float count;
    
    // Start is called before the first frame update
    void Start()
    {
        StaticVar.infectionCount = 0;
        currentScene = SceneManager.GetActiveScene();
        infectedCellCount = 0;
        scene = currentScene.name;
        infectedCellCount = StaticVar.infectionCount;
        count = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        infectedCellCount = StaticVar.infectionCount;
        if (infectedCellCount == StaticVar.mNum) {
            count -= Time.deltaTime;
            if (count < 0) {
                Application.LoadLevel("EndScene");
            }
        }
    }
}
