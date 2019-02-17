using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWidCamera : MonoBehaviour
{
    public bool zombieIsThere;
    float timer;
    int timeBetweenAttack;
    private GameControllerScript gameController;
    AudioSource attackSound;
    // Use this for initialization
    void Start()
    {
        timeBetweenAttack = 2;

        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if(gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameControllerScript>();
        }

        AudioSource[] audios = GetComponents <AudioSource>();
        attackSound = audios[0];
    }

    // Update is called once per frame
    void Update()
    {

        timer = timer + Time.deltaTime;

        if (zombieIsThere && timer >= timeBetweenAttack)
        {
            Attack();
        }

    }

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "MainCamera")
        {
            zombieIsThere = true;
            Debug.Log("enter");
        }
    }

    void OnCollisionExit (Collision col)
    {
        if (col.gameObject.tag == "MainCamera")
        {
            zombieIsThere = false;
            Debug.Log("exit");
        }
    }

    void Attack()
    {
        timer = 0f;
        GetComponent<Animator>().Play("attack");
        gameController.zombieAtttack(zombieIsThere);
        attackSound.Play();
    }
}