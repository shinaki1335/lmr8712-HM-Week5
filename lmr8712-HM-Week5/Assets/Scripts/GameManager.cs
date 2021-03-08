using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Static variable to make object a singleton
    public static GameManager instance;

    private int currentLevel = 0;
    public bool blueKey;
    public bool greenKey;
    public bool redKey;
    public bool yellowKey;
    
    // Called when the script instance is being loaded
    private void Awake() {                      
        // Make a Singleton to prevent more than one instance of an object
        if (instance == null) {                 //if instance hasn't been set
            DontDestroyOnLoad(gameObject);      //don't destroy object when loading a new scene
            instance = this;                    //set instance to this object
        }
        else {                                  //if instance is set to an object
            Destroy(gameObject);                //destroy this object
        }
    }

}
