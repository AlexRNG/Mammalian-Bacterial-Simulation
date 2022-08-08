using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StaticVar : MonoBehaviour
{

    public static int infectionPercentage;
    public static int bNum;
    public static int mNum;
    public static int dupeNum; 
    public static int infectionCount;
    public Slider _percentageInput;
    public Slider _mInput;
    public Slider _bInput;
    public Slider _dupeNumInput;
    

    // Update is called once per frame
    void Update()
    {
        bNum = (int)_bInput.value;
        mNum = (int)_mInput.value;
        infectionPercentage = (int)_percentageInput.value;
        dupeNum = (int)_dupeNumInput.value;
        
    }
}
