using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;





public class NextStage : MonoBehaviour
{
    AudioManager audioManager;
    private void Awake()
{
    audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
}
    public int sceneBuildIndex;
 
    // Level move zoned enter, if collider is a player
    // Move game to another scene
    private void OnTriggerEnter2D(Collider2D other) {
        print("Trigger Entered");
        
        // Could use other.GetComponent<Player>() to see if the game object has a Player component
        // Tags work too. Maybe some players have different script components?
        if(other.tag == "Player") {
            // Player entered, so move level
            audioManager.PlaySFX(audioManager.StageComplete);
            print("Switching Scene to " + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }
}

