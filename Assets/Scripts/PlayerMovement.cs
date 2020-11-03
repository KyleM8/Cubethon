using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private InputManager inputManager;
    [SerializeField] private Rigidbody playerRigidbody;
    [SerializeField] private float forwardForce = 2000f;
    [SerializeField] private float playerForce = 1500f;

    private void Awake()
    {
        inputManager = InputManager.Instance;
    }

    void FixedUpdate()
    {
        Movement();
    }

    private void Movement() {
        playerRigidbody.AddForce(0, 0, forwardForce * Time.deltaTime);
        Vector2 playerInput = inputManager.GetPlayerMovement();
        Debug.Log("input: " + playerInput.x);
        if (playerInput.x == -1) {
            playerRigidbody.AddForce(-playerForce, 0, 0 * Time.deltaTime);
        }
        else if (playerInput.x == 1) {
            playerRigidbody.AddForce(playerForce, 0, 0 * Time.deltaTime);
        }
    }

}
