using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddles : MonoBehaviour
{
    bool move = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        returnPaddle(30);
    }
    public void LeftPaddle()
    {

        move = true;
    }
    public void RightPaddle()
    {
        
        returnPaddle(-30);
    }
    IEnumerator returnPaddle(int z)
    {
        transform.Rotate(0, 0, z);
        yield return new WaitForSeconds(1);
        transform.Rotate(0, 0, 0);
       
    }

}
