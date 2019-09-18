using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{

    float speed = 0.08f;

    void Update()
    {
        gameObject.transform.Rotate(new Vector3(1, 0, 0), speed);
    }
}
