using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DifficultySlider : MonoBehaviour
{
    Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        float value = slider.value;
        DifficultySelector.WhichScene(value, DifficultySelector.imgColor.GetComponent<Image>(), DifficultySelector.difficultyText.GetComponent<TextMeshProUGUI>());
    }
}
