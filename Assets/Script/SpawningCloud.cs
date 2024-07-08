using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningCloud : MonoBehaviour
{
    public GameObject Cloud;
    public float SpawnRate = 2;
    private float timer = 0;
   


    public bool GameRunning = true;
    // Start is called before the first frame update
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {

        if (GameRunning == true)
        {
            if (timer < SpawnRate)
            {
                timer = timer + Time.deltaTime;
            }
            else
            {
                spawnCloud();
                spawnCloud();
                spawnCloud();
                timer = 0;
            }
        }



    }

    void spawnCloud()
    {

        Instantiate(Cloud, new Vector3(Random.Range(24, 41), Random.Range(-12, 12), 0), transform.rotation); // spawn pipe
    }
}
