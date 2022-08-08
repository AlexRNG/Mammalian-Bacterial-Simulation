using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUIManager : MonoBehaviour
{

    public void LoadLevel(string level) {
        Application.LoadLevel(level);
    }
    public void Quit() {
        Application.Quit();
    }
    public void LoadSettings(string level) {
        Application.LoadLevel(level);
    }
}
