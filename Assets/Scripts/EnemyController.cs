using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public static bool enemyIsAlive = true;
    private static float speed = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }

   
    public static void EasyEnemy()
    {
        //while (enemyIsAlive)
        //{

        move(3);
            Debug.Log("Easy");
        //}
    }

   
    public static void MediumEnemy()
    {
        //while (enemyIsAlive)
        //{

        
        Debug.Log("Medium");
        //}
    }
    public static void HardEnemy()
    {
        
        Debug.Log("Hard");
        //}
    }

    public static void move(float givenSpeed)
    {
        speed = -givenSpeed;
    }

    public static void moveRight(float givenSpeed)
    {
        speed = givenSpeed;
    }
}
