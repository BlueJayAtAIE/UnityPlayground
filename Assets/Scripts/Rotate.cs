using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float rotateSpeed;

    void Update()
    {
        gameObject.transform.Rotate(new Vector3(1, 2, 3), rotateSpeed);
    }
}
