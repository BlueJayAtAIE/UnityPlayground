using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherWhy : MonoBehaviour
{

    public GameObject mother;
    BoxCollider bc;

    private void Start()
    {
        bc = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Mother")
        {
            Destroy(gameObject);
            Debug.Log("Cronch");
        }
    }
}
