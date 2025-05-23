using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColisiones : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        Debug.Log("Contacto");
        Destroy(col.gameObject);
    }
}
