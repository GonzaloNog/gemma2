using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Color coliflor;

    void Start()
    {
        coliflor = GetComponent<Renderer>().material.color;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Ramp")
        {
            print("hi");
            print(coliflor);
        }
    }

}