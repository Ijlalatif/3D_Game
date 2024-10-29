using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{

   private Renderer objRenderer; // Reference to the Renderer component

    void Start()
    {
        // Get the Renderer component from the object
        objRenderer = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object has collided with the player
        if (collision.gameObject.CompareTag("Player"))
        {
            // Change the object's color to red
            objRenderer.material.color = Color.red;

            // Quit the application (works in built application)
            Application.Quit();
            
            // If in the editor, stop playing the game
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #endif
        }
        }
}
