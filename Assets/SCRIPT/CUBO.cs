using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUBO : MonoBehaviour
{
    public Vector3 direccion;

    public float velocidad;

    private void Update()
    {
        transform.Rotate(Time.deltaTime * velocidad * direccion);
    }
}
