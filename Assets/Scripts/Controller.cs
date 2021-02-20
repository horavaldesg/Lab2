using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Controller : MonoBehaviour
{
    Animator anim;
    public static float speed = 0;
    public GameObject BlockShield;
    public GameObject swordPlayer;
    [SerializeField] private float givenSpeed;
    public static bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        isAlive = true;

        BlockShield.SetActive(false);
        //swordPlayer.SetActive(false);
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0,0);
        if (!isAlive)
        {
            StartCoroutine(DeathSequence());
        }
        if(!EnemyController.enemyIsAlive && isAlive)
        {
            StartCoroutine(Winner());
        }
       

    }
    public void Walk()
    {
        anim.SetBool("Walk", true);
        speed = givenSpeed;
        EnemyController.PlayerMoveRight = true;
        //EnemyController.move();

    }
    public void StopWalk()
    {
        anim.SetBool("Walk", false);
        speed = 0;
        EnemyController.PlayerMoveRight = false;
    }

    public void WalkBack()
    {
        anim.SetBool("WalkBack", true);
        speed = -givenSpeed;
        EnemyController.PlayerMoveRight = true;
    }
    public void StopWalkBack()
    {
        anim.SetBool("WalkBack", false);
        speed = 0;
        EnemyController.PlayerMoveRight = false;
    }

    public void Block()
    {
        BlockShield.SetActive(true);
        anim.SetBool("Block", true);
        EnemyController.PlayerBlock = true;
        
    }
    public void StopBlock()
    {
        anim.SetBool("Block", false);
        BlockShield.SetActive(false);
        EnemyController.PlayerBlock = false;
    }

    public void Slash()
    {
        anim.SetBool("Slash", true);
        EnemyController.PlayerSlash = true;
       
        
        //swordPlayer.SetActive(true);
        
        



    }
    public void StopSlash()
    {

        EnemyController.PlayerSlash = false;
        anim.SetBool("Slash", false);
        



    }
    IEnumerator DeathSequence()
    {
        anim.Play("Death");
        PlayerName.whoWon = "Paladin";
        yield return new WaitForSeconds(3);
        isAlive = true;
        SceneManager.LoadScene("End");
    }

    IEnumerator Winner()
    {
        yield return new WaitForSeconds(0.1f);
        anim.Play("PowerUP");
        yield return new WaitForSeconds(2);
    }


}
