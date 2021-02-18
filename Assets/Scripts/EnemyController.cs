using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    
    public static bool enemyIsAlive = true;
    private static float speed = 0;
    static Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        if (!enemyIsAlive)
        {
            anim.Play("Death");
        }
        StartCoroutine(EasyMove());
    }

   
    public static void EasyEnemy()
    {
        //while (enemyIsAlive)
        //{

        //move(3);
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

        
    }
    IEnumerator EasyMove()
    {
        
        anim.SetBool("Block", true);
        yield return new WaitForSeconds(3);
        anim.SetBool("Block", false);
        yield return new WaitForSeconds(1);
        anim.SetBool("Block", false);
        anim.SetBool("Slash", true);
        yield return new WaitForSeconds(3);
        anim.SetBool("Slash", false);

        
    }

    public static void moveRight(float givenSpeed)
    {
        speed = givenSpeed;
    }
}
