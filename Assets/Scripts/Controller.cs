using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Animator anim;
    private float speed = 0;
    public GameObject BlockShield;
    public GameObject swordPlayer;
    [SerializeField] private float givenSpeed;
    public static bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
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
            anim.Play("Death");
        }
       

    }
    public void Walk()
    {
        anim.SetBool("Walk", true);
        speed = givenSpeed;
        //EnemyController.move();

    }
    public void StopWalk()
    {
        anim.SetBool("Walk", false);
        speed = 0;
    }

    public void WalkBack()
    {
        anim.SetBool("WalkBack", true);
        speed = -givenSpeed;
    }
    public void StopWalkBack()
    {
        anim.SetBool("WalkBack", false);
        speed = 0;
    }

    public void Block()
    {
        BlockShield.SetActive(true);
        anim.SetBool("Block", true);
        
    }
    public void StopBlock()
    {
        anim.SetBool("Block", false);
        BlockShield.SetActive(false);
    }

    public void Slash()
    {
        anim.SetBool("Slash", true);
       
        
        //swordPlayer.SetActive(true);
        
        



    }
    public void StopSlash()
    {

        
        anim.SetBool("Slash", false);
        



    }
   

}
