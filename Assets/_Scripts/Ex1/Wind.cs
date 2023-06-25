using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public float wind;
    private float WindForce;
    static float t = 0f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        t += wind * Time.deltaTime;
        WindForce = t;
        Debug.Log(WindForce);
    }

    public float GetWindForce()
    {
        return WindForce;
    }
}
