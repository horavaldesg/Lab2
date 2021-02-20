using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CharacterSelect : MonoBehaviour
{
    public GameObject brute;
    public GameObject maria;
    public TMP_InputField inp;
    public static string inpText;
    //public string playerName;
    // Start is called before the first frame update
    private void Awake()
    {
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BruteSelected()
    {

        PlayerSpawner.player = brute;
        PlayerName.playerName = inpText;
        Debug.Log("Character Selected" );
    }

    public void MariaSelected()
    {

        PlayerSpawner.player = maria;
        PlayerName.playerName = inpText;
        Debug.Log("Character Selected");
    }
    public void SaveInput()
    {
        inpText = inp.text;
    }
}
