using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject bulletPrefab;
    private Quaternion rotation = Quaternion.Euler(0f, 0f, 90f); // Set rotation to 90 degrees in z-axis
    public float limitAttack = 0.5f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && limitAttack >= 0.5f)
        {
            Instantiate(bulletPrefab, transform.position, rotation);
            limitAttack = 0f;
        } else
        {
            limitAttack += Time.deltaTime;
        }
    }
}
