using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    // When the collider is triggered
    private void OnTriggerEnter2D(Collider2D other) {
        GameManager.instance.GetComponent<ASCIILevelLoader>().CurrentLevel++; //change the value of currentLevel
    }
}
