using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float movementSpeed = 5f;
    public KeyCode[] controls;
    private Vector3 movement;
    
    void Update()
    {
        if (Input.GetKey(controls[0])) movement = Vector3.up;
        else if (Input.GetKey(controls[1])) movement = Vector3.down;
        else movement = Vector3.zero;

        transform.position = transform.position + movement * (Time.deltaTime * movementSpeed);
    }
}
