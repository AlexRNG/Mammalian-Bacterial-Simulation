using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loadNext(string level)
    {
        Application.LoadLevel(level);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
