using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    public GameObject brute;
    public GameObject maria;
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
        Debug.Log("Character Selected" );
    }

    public void MariaSelected()
    {

        PlayerSpawner.player = maria;
        Debug.Log("Character Selected");
    }
}
