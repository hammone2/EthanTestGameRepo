using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;


public class Player : MonoBehaviour
{

    // declare variables
    public float move_speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // forward
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * move_speed;
        }

        // back
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * move_speed;
        }

        // left
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * move_speed;
        }

        // right
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * move_speed;
        }

        //fly
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * move_speed;
        }

        //fall
        if ((Input.GetKey(KeyCode.LeftShift)) || (Input.GetKey(KeyCode.RightShift)))
        {
            transform.position += Vector3.down * move_speed;
        }
    }
}
