using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength = 5f;  
    public LogicManager logicManager;
    public bool isPlayerAlive;


    private void Start()
    {
        logicManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();

        isPlayerAlive = true;


    }



    private void Update()
    {

        //print(isPlayerAlive);


        if (Input.GetKeyDown(KeyCode.Space) && isPlayerAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;  
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("ÁARPTI"); 
        logicManager.gameOver();
        isPlayerAlive = false;

    }

}
