﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{

    private bool ignoreNextCollision;
    public Rigidbody rb;


    //Start is called before the first frame update
    void Start() 
    {
        
    }

    private void OnCollisionEnter(Collision collision) 
    {

        //Debug.Log("Ball touched something");

        rb.velocity = Vector3.zero;
        rb.AddForce(Vector3.up, ForceMode.Impulse);

        //GameManager.singleton.AddScore(1);
        //Debug.Log(GameManager.singleton.score);
    }

    //Update is called once per frame
    void Update()
    {

    }
}