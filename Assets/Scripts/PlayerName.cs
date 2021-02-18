using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerName : MonoBehaviour
{
    public static string playerName;
    TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        text.SetText(playerName);
        Debug.Log(playerName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
