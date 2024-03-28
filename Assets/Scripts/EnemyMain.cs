using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMain : MonoBehaviour
{
    public float speedEnemy = 20f;

    void Update()
    {
        gameObject.transform.position = gameObject.transform.position + new Vector3(-speedEnemy, 0, 0) * Time.deltaTime;

        if(gameObject.transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerHealth>().CollisionWithEnemy();
            Destroy(gameObject);
        }
    }
}
