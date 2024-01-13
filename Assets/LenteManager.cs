using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class LenteManager : MonoBehaviour
{
    public void SeleccionLentes(int numeroLente)
    {
        GameObject cara = FindObjectOfType<ARFace>().gameObject;

        //Encontrar lentes
        Transform lentesManager = cara.transform.GetChild(1).transform;

        //Desactivar todos los lentes
        for(int i = 0; i < lentesManager.childCount;i++)
        {
            //Activar el lente seleccionado
            lentesManager.GetChild(i).gameObject.SetActive(i == numeroLente);
        }
       
    }
}
