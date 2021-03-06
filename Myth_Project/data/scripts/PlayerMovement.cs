﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rb;

    [SerializeField]
    private float _initialMoveSpeed;

    private float _moveSpeed;


    void Start()
    {
        _moveSpeed = _initialMoveSpeed;
    }

    void Move(float x, float y)
    {
        _rb.velocity = new Vector2(x, y).normalized * _moveSpeed * Time.deltaTime;
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Move(x, y);
    }

}