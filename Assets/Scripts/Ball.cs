using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float movementSpeed = 5f;
    public AudioSource audioSource;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        float x = Random.Range(0, 2) == 0 ? 1 : -1;
        float y = Random.Range(0, 2) == 0 ? 1 : -1;
        _rigidbody.velocity = new Vector2(x * movementSpeed, y * movementSpeed);

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            _rigidbody.velocity *= 1.05f;
        }
        audioSource.Play();
    }
}
