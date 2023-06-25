using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangerZone : MonoBehaviour
{
    private ColorChanger objetos;
    public GameObject Ramp;

    void Start()
    {
        objetos = GetComponent<ColorChanger>();

    }
    private void OnTriggerEnter(Collider other)
    {
        Ramp.GetComponent<Renderer>().material.color = other.GetComponent<ColorChanger>().coliflor;
    }

    private void OnTriggerExit(Collider other)
    {
        Ramp.GetComponent<Renderer>().material.color = Color.white;
    }
}