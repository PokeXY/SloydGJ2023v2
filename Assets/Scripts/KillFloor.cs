using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class KillFloor : MonoBehaviour
{
    // Familiarizing our killfloor with what's what
    //public GameObject respawner;
    //private Vector3 respawnLocation;
    //public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        // When starting the program, make sure our respawn location is equal to the respawners transform.
        // This works properly as it displays the correct position of our respawner in the log
        //respawnLocation = respawner.gameObject.transform.position;
        //Debug.Log("Respawn Vector: " + respawnLocation);
    }


    void OnTriggerEnter(Collider other)
    {

        // MAKE A SCRIPT TO GO ON KILLFLOOR, SEND PLAYER BACK TO RESPAWNLOCATION

        if (other.gameObject.CompareTag("Player"))
        {
            //other.gameObject.transform.position = respawner.gameObject.transform.position;
            //Debug.Log("Player Vector: " + other.gameObject.transform.position); // works, but doesn't actually activate?
            //Debug.Log("Respawner Vector: " + respawner.gameObject.transform.position);

            SceneManager.LoadScene("GameOver");
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
