using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DifficultySelector : MonoBehaviour
{
    public int color = 0;
    public static Image imgColor;
    // Start is called before the first frame update
    void Start()
    {
        imgColor = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void WhichScene(float slider, Image imgColor)
    {
        switch (slider)
        {
            case 1: imgColor.color = Color.green;
                break;
            case 2: imgColor.color = Color.yellow;
                break;
            case 3: imgColor.color = Color.red;
                break;
        }

    }

    public void SeneSelect()
    {
        if(imgColor.color == Color.green)
        {
            SceneManager.LoadScene("Easy");
        }
        else if (imgColor.color == Color.yellow)
        {
            SceneManager.LoadScene("Medium");
        }
        else if (imgColor.color == Color.red)
        {
            SceneManager.LoadScene("Hard");
        }
    }
}
