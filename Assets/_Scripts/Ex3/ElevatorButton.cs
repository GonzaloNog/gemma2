using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorButton : MonoBehaviour
{
    public bool GoUp;
    public Animator ElevatorAnimator;
    bool puedesubir = true;
    // Start is called before the first frame update

    private void Start()
    {
        ElevatorAnimator.SetBool("Sube", false);
    }
    private void OnMouseDown()
    {
        if (transform.name == "UpButton")
        {
            ElevatorAnimator.SetBool("Sube", true);
            puedesubir = false;
        }

        if (transform.name == "DownButton")
        {
            ElevatorAnimator.SetBool("Sube", false);
            puedesubir = true;
        }
    }
}


