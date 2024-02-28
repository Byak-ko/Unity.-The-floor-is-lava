using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public float amplitude = 2.0f;
    public float frequency = 0.5f;

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        float horizontalMovement = amplitude * Mathf.Sin(frequency * Time.time);
        Vector3 newPosition = initialPosition + new Vector3(0, 0, horizontalMovement);

        transform.position = newPosition;
    }
}
