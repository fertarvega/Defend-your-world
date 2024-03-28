using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public TextMeshProUGUI textHealth;

    private void Start()
    {
        textHealth.text = health.ToString();
    }

    public void CollisionWithEnemy()
    {
        health = health - 10;

        textHealth.text = health.ToString();

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
