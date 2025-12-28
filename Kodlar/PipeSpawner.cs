using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public GameObject pipe;
    public float timerMax = 2f; 
    private float timer = 0f;
    public float heightOffSet = 10f; 


    // Start is called before the first frame update
    void Start()
    {
        timer = timerMax;
        SpawnPipe(); 

    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;

 

        if(timer <= 0)
        {
            SpawnPipe(); 
            timer = timerMax;
        }

    }

    private void SpawnPipe()
    {

        float lowestPoint = transform.position.y - heightOffSet;
        float highestPoint = transform.position.y + heightOffSet;



        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

    }

}
