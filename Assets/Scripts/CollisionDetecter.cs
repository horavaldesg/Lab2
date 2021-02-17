using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetecter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {

            HealthBarEnemy.enemyHit(0.1f);
            Debug.Log("Enemy Hit");
            
        }

        if (other.gameObject.CompareTag("Player"))
        {
            HealthBar.PlayerHit(0.1f);
            Debug.Log("Player Hit");
        }
    }

}
