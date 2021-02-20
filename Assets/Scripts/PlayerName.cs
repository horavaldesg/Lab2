using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class PlayerName : MonoBehaviour
{
    public static string playerName;
    public static string whoWon;
    TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        text.SetText(PlayerPrefs.GetString("PlayerName", "playerName"));
        Debug.Log(playerName);

        if(SceneManager.GetActiveScene().name == "End")
        {
            text.SetText(whoWon + " is the winner");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
