﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Text scoreText;
    

    // Update is called once per frame
    void Update()
    {
        scoreText.text = playerTransform.position.z.ToString("0");
    }
}
