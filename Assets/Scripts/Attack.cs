using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScrip : MonoBehaviour
{
    public float speedBullet = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = gameObject.transform.position + new Vector3(speedBullet, 0, 0) * Time.deltaTime;

        if(gameObject.transform.position.x > 10)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
