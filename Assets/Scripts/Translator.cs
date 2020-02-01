﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translator : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float waterLevel = 4f;
    
    [SerializeField]
    private float floatHeight = 2f;

    [SerializeField]
    private float bounceDamp = 0.05f;

    [SerializeField]
    private Vector3 BuoyancyCenterOffset;

    [SerializeField]
    private float forceFactor;

    private Vector3 actionPoint;

    private Vector3 upLift;

    // Update is called once per frame

    Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        actionPoint = transform.position + transform.TransformDirection(BuoyancyCenterOffset);
        forceFactor = 1f - ((actionPoint.y - waterLevel) / floatHeight);
        transform.Translate(Vector3.back * speed);

        if(forceFactor > 0f)
        {
            upLift = -Physics.gravity * (forceFactor - rigidbody.velocity.y * bounceDamp);
            rigidbody.AddForceAtPosition(upLift, actionPoint);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }
}