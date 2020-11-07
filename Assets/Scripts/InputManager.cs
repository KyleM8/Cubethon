using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public PlayerControls playerControls;

    private static InputManager _instance;
    public static InputManager Instance {
        get {
            return _instance;
        }
    }

    private void Awake() {
        if (_instance != null && _instance != this) {
            Destroy(this.gameObject);
        }
        else {
            _instance = this;
        }

        playerControls = new PlayerControls();
    }

    private void OnEnable() {
        playerControls.Enable();
        Debug.Log("player controls enabled");
    }

    private void OnDisable() {
        playerControls.Disable();
        Debug.Log("player controls disabled");
    }

    public Vector2 GetPlayerMovement() {
        Vector2 playerMovement = playerControls.Map.Movement.ReadValue<Vector2>();
        return playerMovement;
    }
}
