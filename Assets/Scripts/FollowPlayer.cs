using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private Vector3 offset = new Vector3(0f, 1f, -5f);

    void Update()
    {
        transform.position = playerTransform.position + offset;
    }
}
