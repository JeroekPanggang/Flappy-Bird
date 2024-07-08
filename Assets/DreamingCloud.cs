using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamingCloud : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45; // zona pipa dihapus dari game
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe deleted");
            Destroy(gameObject);
        }
    }

}
