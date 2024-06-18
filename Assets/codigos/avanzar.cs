using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avanzar : MonoBehaviour
{
    Rigidbody2D alien;
    Animator papita;
    float velocidad = 0.5f;
    puntos puntos;
    private void Awake()
    {
        alien = GetComponent<Rigidbody2D>();
        papita = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        alien.velocity = new Vector2(0, -velocidad);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Kevin")
        {
            Destroy(collision.gameObject);
            velocidad = 0;
            papita.SetTrigger("New Trigger");
            Destroy(gameObject, 1);
            puntos.Aumentar_puntos(1);
        }

    }
    public void Ratoncito(puntos puntitos)
    {
        puntos = puntitos;

    }

}
    

