using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Access Modifier / Type / Name / Operator / Value
    public float speed = 20.0f;
    public float turnSpeed = 50.0f;
    // Keyboard Input Values
    public float hInput;
    public float vInput;    

    // Update is called once per frame
    void Update()
    {
      // Collect keyboard inputs
      hInput = Input.GetAxis("Horizontal");
      vInput = Input.GetAxis("Vertical");
      //Make the player move
      transform.Translate(Vector3.forward * speed * Time.deltaTime * vInput); // Move forward and back
      transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * hInput); // Rotate left and right

    }
}
