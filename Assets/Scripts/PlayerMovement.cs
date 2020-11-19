using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private InputManager inputManager;
    [SerializeField] private Rigidbody playerRigidbody;
    [SerializeField] private float forwardForce = 0.001f;
    [SerializeField] private float playerForce = 0.0005f;
    

    private void Awake() {
        inputManager = InputManager.Instance;
        playerRigidbody.position = new Vector3(0f,0f,0f);
    }

    void FixedUpdate() {
        Movement();
    }

    private void Movement() {
        playerRigidbody.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.Acceleration);
        Vector2 playerInput = inputManager.GetPlayerMovement();
        // Debug.Log("input: " + playerInput.x);
        if (playerInput.x == -1) {
            playerRigidbody.AddForce(-playerForce * Time.deltaTime, 0, 0, ForceMode.Acceleration);
        }
        else if (playerInput.x == 1) {
            playerRigidbody.AddForce(playerForce * Time.deltaTime, 0, 0, ForceMode.Acceleration);
        }
    }

}
