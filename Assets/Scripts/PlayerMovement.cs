using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private InputManager inputManager;
    [SerializeField] private Rigidbody playerRigidbody;
    [SerializeField] private float forwardForce = 5f;
    [SerializeField] private float playerForce = 3f;
    

    private void Awake() {
        inputManager = InputManager.Instance;
    }

    void FixedUpdate() {
        Movement();
    }

    private void Movement() {
        playerRigidbody.AddForce(0, 0, forwardForce * Time.deltaTime);
        Vector2 playerInput = inputManager.GetPlayerMovement();
        // Debug.Log("input: " + playerInput.x);
        if (playerInput.x == -1) {
            playerRigidbody.AddForce(-playerForce * Time.deltaTime, 0, 0);
        }
        else if (playerInput.x == 1) {
            playerRigidbody.AddForce(playerForce * Time.deltaTime, 0, 0);
        }
    }

}
