using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LeftPaddle()
    {
        transform.Rotate(0, 0, 30);
        returnPaddle();
    }
    public void RightPaddle()
    {
        transform.Rotate(0, 0, -30);
        returnPaddle();
    }
    IEnumerator returnPaddle()
    {
        yield return new WaitForSeconds(0.5f);
        transform.Rotate(0, 0, 0);
    }
}
