using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEkor : MonoBehaviour
{
    public static MoveEkor Instance;
    public Animator animator;

    public void Awake()
    {
        Instance = this;
        animator = GetComponent<Animator>();
    }

    public void EkorGerak(string State)
    {
        Debug.Log("UP");
        animator.SetTrigger(State);
    }
}
