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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health = health - 10;

            textHealth.text = health.ToString();

            Debug.Log(gameObject.name + " : " + gameObject.name + " : " + Time.time);

        }
    }
}
