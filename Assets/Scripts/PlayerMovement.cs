using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speedShip = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w")){
            gameObject.transform.position = gameObject.transform.position + new Vector3(0, speedShip, 0) * Time.deltaTime;
        }
        if(Input.GetKey("s")){
            gameObject.transform.position = gameObject.transform.position + new Vector3(0, -speedShip, 0) * Time.deltaTime;
        }
    }
}
