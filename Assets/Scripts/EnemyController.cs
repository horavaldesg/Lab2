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

    public static bool PlayerSlash;
    public static bool PlayerBlock;

    public static bool PlayerMoveRight;
    public static bool PlayerMoveLeft;

    public GameObject blockObject;
    // Start is called before the first frame update
    void Start()
    {
        enemyIsAlive = true;
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
        if(!Controller.isAlive && enemyIsAlive)
        {
            StartCoroutine(Winner());
        }
       
        if (easy)
        {
            if (PlayerSlash)
            {

                StartCoroutine(Block());

            }

            if (PlayerMoveRight)
            {
                StartCoroutine(Slash());
            }
            if (Controller.speed == 0)
            {
                StartCoroutine(SlashRandom(10));
            }

        }
        else if (medium)
        {
            
            if (PlayerSlash)
            {

                StartCoroutine(Block());

            }
           
            if (PlayerMoveRight)
            {
                StartCoroutine(Slash());
            }
            if(Controller.speed == 0)
            {
                StartCoroutine(SlashRandom(7));
            }

        }
        else if (hard)
        {
            if (PlayerSlash)
            {

                StartCoroutine(Block());

            }

            if (PlayerMoveRight)
            {
                StartCoroutine(Slash());
            }
            if (Controller.speed == 0)
            {
                StartCoroutine(SlashRandom(4));
            }
        }

    }
    public int RandomNum(int i)
    {
        return Random.Range(0, i);

    }

    IEnumerator Winner()
    {
        yield return new WaitForSeconds(0.1f);
        anim.Play("PowerUP");
        yield return new WaitForSeconds(2);
    }
    IEnumerator DeathSequence()
    {
        PlayerName.whoWon = PlayerPrefs.GetString("PlayerName", "playerName");
        anim.Play("Death");
        yield return new WaitForSeconds(3);
        enemyIsAlive = true;
        SceneManager.LoadScene("End");
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

    

    IEnumerator Block()
    {
        blockObject.SetActive(false);
        anim.SetBool("Block", true);
        yield return new WaitForSeconds(2);
        blockObject.SetActive(true);
        anim.SetBool("Block", false);
    }

    IEnumerator Slash()
    {
        anim.SetBool("Slash", true);
        yield return new WaitForSeconds(2);
        anim.SetBool("Slash", false);
    }

    IEnumerator SlashRandom(int s)
    {
        anim.SetBool("Slash", false);
        yield return new WaitForSeconds(s);
        anim.SetBool("Slash", true);
        yield return new WaitForSeconds(2);
        anim.SetBool("Slash", false);
        yield return new WaitForSeconds(s);
    }
    IEnumerator EasyMove()
    {

        //anim.SetBool("Slash", true);
        //yield return new WaitForSeconds(3);
        //anim.SetBool("Slash", false);
        //yield return new WaitForSeconds(5);


        //anim.SetBool("Block", true);
        //yield return new WaitForSeconds(3);
        //anim.SetBool("Block", false);
        //yield return new WaitForSeconds(1);
       

        //yield return new WaitForSeconds(5);
        //speed = -3;
        //anim.SetBool("WalkBack", true);
        //yield return new WaitForSeconds(5);
        //speed = 0;
        //anim.SetBool("WalkBack", false);
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
