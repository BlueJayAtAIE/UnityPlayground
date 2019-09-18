using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAround : MonoBehaviour
{

    float movementSpeed = 12f;
    float horizontalSpeed = 2f;
    float verticalSpeed = 2f;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float translationX = Input.GetAxis("Horizontal") * movementSpeed;
        float translationZ = Input.GetAxis("Vertical") * movementSpeed;
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");

        rb.velocity = transform.forward * translationZ;
        transform.Rotate(v, h, 0);
    }
}
