using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CubeSequence : MonoBehaviour
{

    private void Start()
    {
        StartCoroutine(Escala());
        StartCoroutine(Color(1f));
    }

    IEnumerator Escala ()
    {
        yield return StartCoroutine(Escalando(2f, new Vector3 (transform.localScale.x * 2, transform.localScale.y * 2, transform.localScale.z * 2)));
    }
    IEnumerator Escalando(float duration, Vector3 size)
    {
        Vector3 Escalar = transform.localScale;
        Vector3 EscalaFinal = size;
        for (float time = 0; time <= duration; time += Time.deltaTime)
        {
            float x = Mathf.Clamp01(time / duration);
            transform.localScale = Vector3.Lerp(Escalar, EscalaFinal, x);

            yield return null;
        }
        transform.localScale = EscalaFinal;
    }

    IEnumerator Color (float duration)
    {
        yield return new WaitForSeconds (duration);
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
 

        yield return StartCoroutine(EscalaO(1.5f, new Vector3(transform.localScale.x - 1f, transform.localScale.y - 1f, transform.localScale.z - 1f)));
    }

    IEnumerator EscalaO(float duration, Vector3 size)
    {
        Vector3 Escalar = transform.localScale;
        Vector3 EscalaOriginal = size;

        for (float time = 0; time <= duration; time += Time.deltaTime)
        {
            float x = Mathf.Clamp01(time / duration);
            transform.localScale = Vector3.Lerp(Escalar, EscalaOriginal, x);

            yield return new WaitForSeconds (1.5f);
        }
        transform.localScale = EscalaOriginal;

    }

}

