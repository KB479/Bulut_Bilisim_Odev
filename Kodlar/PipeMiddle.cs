using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddle : MonoBehaviour
{
    public LogicManager logicManager;

    private void Start()
    {
        
        logicManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logicManager.addScore(1); 
        }

    }


}
