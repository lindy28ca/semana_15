using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nave : MonoBehaviour
{
    Rigidbody2D navecita;
    public float velocidad;
    float y;
    float x;
    private void Update()
    {
        y = Input.GetAxis("Vertical");
        x = Input.GetAxis("Horizontal");
    }
    private void Awake()
    {
        navecita = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        navecita.velocity = new Vector2(x * velocidad,y * velocidad);
    }

}
