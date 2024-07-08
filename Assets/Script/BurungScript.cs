using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurungScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript Logic;
    public PipeSpawnerScript Pipe;
    public SpawningCloud Cloud;
    public bool BurungisAlive = true;

    public string State = "Up";

    //public GameObject ekor;

    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && BurungisAlive == true)
        {
            
            myRigidbody.velocity = Vector2.up * flapStrength;

            
            MoveEkor.Instance.EkorGerak(State);
        }
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Logic.gameOver();
        Pipe.GameRunning = false;
        Cloud.GameRunning = false;
        BurungisAlive = false;

    }
}
