using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody2D bala;
    public float velocidad;
    private void Awake()
    {
        bala = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        bala.velocity = new Vector2(0, velocidad);
    }
}
