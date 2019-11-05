using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    private bool invinsible;

    private void FixedUpdate()
    {
        if (Input.GetKey("i") && invinsible == false)
        {
            invinsible = true;
            Debug.Log("Invinsible!");
        }
        if (Input.GetKey("o") && invinsible == true)
        {
            invinsible = false;
            Debug.Log("Not Invinsible!");
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle" && invinsible == false)
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
