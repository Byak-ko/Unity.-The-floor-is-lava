using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRolling : MonoBehaviour
{
    public float speed = 0.5f;
    public float maxSpeed = 2f;
    private Rigidbody rigidBody;
    private bool isOnLava, isOnFinish;

    void Start()
    {
        isOnLava = false;
        isOnFinish = false;
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!isOnLava && !isOnFinish)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(-verticalInput, 0f, horizontalInput);
            rigidBody.AddForce(movement * speed);

            //speed limit
            rigidBody.velocity = new Vector3(
                Mathf.Clamp(rigidBody.velocity.x, -maxSpeed, maxSpeed),
                rigidBody.velocity.y,
                Mathf.Clamp(rigidBody.velocity.z, -maxSpeed, maxSpeed));
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lava"))
        {
            isOnLava = true;
        }
        if (other.CompareTag("Finish"))
        {
            isOnLava = true;
        }
    }

}