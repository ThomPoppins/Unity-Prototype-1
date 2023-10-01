using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    private bool firstPerson = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // LateUpdate is called after Update() has been called once per frame
    void LateUpdate()
    {
        // Switch offset if c button is pressed
        if (Input.GetKeyDown(KeyCode.C))
        {
            firstPerson = !firstPerson;
        }

        if (firstPerson)
        {
            // Set camera to player's position
            offset = new Vector3(0, 1.76f, 1.33f);
            // Rotate camera to player's rotation
            transform.rotation = player.transform.rotation;
        }
        else
        {
            // Offset the camera behind the player by adding to the player's position
            offset = new Vector3(0, 5, -7);
            // Stop rotating camera to player's rotation
            transform.rotation = Quaternion.Euler(30, 0, 0);
        };

        // Offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;
    }
}
