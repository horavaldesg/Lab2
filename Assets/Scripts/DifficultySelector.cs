using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class DifficultySelector : MonoBehaviour
{
    public int color = 0;
    public static Image imgColor;
    public static TextMeshProUGUI difficultyText;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        imgColor = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        difficultyText = text;
    }
    public static void WhichScene(float slider, Image imgColor, TextMeshProUGUI text)
    {
        switch (slider)
        {
            case 1: imgColor.color = Color.green;
                text.GetComponent<TextMeshProUGUI>().SetText("Easy");
                    
                break;
            case 2: imgColor.color = Color.yellow;
                text.GetComponent<TextMeshProUGUI>().SetText("Medium");
                break;
            case 3: imgColor.color = Color.red;
                text.GetComponent<TextMeshProUGUI>().SetText("Hard");
                break;
        }

    }

    public void SeneSelect()
    {
        if(imgColor.color == Color.green)
        {
            PlayerPrefs.SetString("PlayerName", CharacterSelect.inpText);
            EnemyController.EasyEnemy();
            SceneManager.LoadScene("Easy");
        }
        else if (imgColor.color == Color.yellow)
        {
            PlayerPrefs.SetString("PlayerName", CharacterSelect.inpText);
            EnemyController.MediumEnemy();
            SceneManager.LoadScene("Medium");
        }
        else if (imgColor.color == Color.red)
        {
            PlayerPrefs.SetString("PlayerName", CharacterSelect.inpText);
            EnemyController.HardEnemy();
            SceneManager.LoadScene("Hard");
        }
    }

    public void TitleScreen()
    {
        SceneManager.LoadScene("Title");
    }
}
