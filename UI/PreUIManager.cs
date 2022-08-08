using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreUIManager : MonoBehaviour
{
    public Slider percentageSlider;
    public Slider mammalianSlider;
    public Slider bacterialSlider;
    public Slider dupeNumSlider;
    public Text percentageSlideText;
    public Text mammalianText;
    public Text bacterialText;
    public Text dupeNumText;


    // Update is called once per frame
    void Update()
    {
        percentageSlideText.text = "" + percentageSlider.value + "%";
        mammalianText.text = "" + mammalianSlider.value + " mammalian cells";
        bacterialText.text = "" + bacterialSlider.value + " bacterial cells";
        dupeNumText.text = "" + dupeNumSlider.value + " bacterial cells per infection";
    }

    public void LoadLevel(string level) {
        Application.LoadLevel(level);
    }
}
