using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject bulletPrefab;
    private Quaternion rotation = Quaternion.Euler(0f, 0f, 90f); // Set rotation to 90 degrees in z-axis

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position, rotation);
        }
    }
}
