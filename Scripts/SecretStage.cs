using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;





public class SecretStage : MonoBehaviour
{
    AudioManager audioManager;
    private void Awake()
{
    audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
}
 
    // Level move zoned enter, if collider is a player
    // Move game to another scene
    private void OnTriggerEnter2D(Collider2D other) {
        print("Trigger Entered");
        SceneManager.LoadScene("SecretStage");

    }
}


