using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crearbalas : MonoBehaviour
{
    public GameObject crearbalitas;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(crearbalitas, transform.position, transform.rotation);
        }
    }
}
