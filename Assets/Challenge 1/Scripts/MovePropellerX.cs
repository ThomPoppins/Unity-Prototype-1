using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePropellerX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Make the propeller spin
        transform.Rotate(Vector3.forward * 500 * Time.deltaTime);
    }
}
