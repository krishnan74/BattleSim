using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    private bool isInstance = false; // Flag to check if the object is instantiated

    // Start is called before the first frame update
    void Start()
    {
        isInstance = true; // Set the flag to true when instantiated
    }

    // Update is called once per frame
    void Update()
    {
        if (isInstance)
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime * 5f;
        }
    }
}
