using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyController : MonoBehaviour
{
    
    public static bool enemyIsAlive = true;
    private static float speed = 0;
    static Animator anim;
    public static bool easy;
    public static bool medium;
    public static bool hard;
    public GameObject blockObject;
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
            
            StartCoroutine(DeathSequence());
        }
        if(anim.GetBool("Block") == true)
        {
            blockObject.SetActive(false);
            Debug.Log("Block");
        }
        else if(anim.GetBool("Block") == false)
        {
            blockObject.SetActive(true);
        }
        if (easy)
        {
            StartCoroutine(EasyMove());
        }
        else if (medium)
        {
            StartCoroutine(MediumMove());
        }
        else if (hard)
        {
            StartCoroutine(HardMove());
        }
       
    }
    IEnumerator DeathSequence()
    {
        anim.Play("Death");
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Title");
    }
   
    public static void EasyEnemy()
    {
        easy = true;
        medium = false;
        hard = false;
        Debug.Log("Easy");
       
    }

   
    public static void MediumEnemy()
    {
        easy = false;
        medium = true;
        hard = false;

        Debug.Log("Medium");
        
    }
    public static void HardEnemy()
    {
        easy = false;
        medium = false;
        hard = true;
        Debug.Log("Hard");
        
    }

    
    IEnumerator EasyMove()
    {


        anim.SetBool("Block", true);
        yield return new WaitForSeconds(3);
        anim.SetBool("Block", false);
        yield return new WaitForSeconds(1);
        anim.SetBool("Slash", false);

        anim.SetBool("Slash", true);
        yield return new WaitForSeconds(3);
        anim.SetBool("Slash", false);
        yield return new WaitForSeconds(5);


    }
    IEnumerator MediumMove()
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
    IEnumerator HardMove()
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
