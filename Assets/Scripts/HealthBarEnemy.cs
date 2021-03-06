﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HealthBarEnemy : MonoBehaviour
{
    public static RectTransform rect;
    
    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rect.localScale.x <= 0)
        {
            rect.localScale = new Vector3(0, 1, 1);
            EnemyController.enemyIsAlive = false;
            //SceneManager.LoadScene("Title");

        }
    }

    public static void enemyHit( float damage)
    {

        rect.localScale = new Vector3(rect.localScale.x - damage, 1, 1);
    }

}
