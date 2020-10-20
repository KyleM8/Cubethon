using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody playerRigidbody;
    private int playerSpeed = 2000;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Movement();
    }

    private void Movement() {
        playerRigidbody.AddForce(0, 0, playerSpeed * Time.deltaTime);
    }


}
