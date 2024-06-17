using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crearaliens : MonoBehaviour
{
    public GameObject alien;
    public puntos puntitos;
    float x;
    private void Start()
    {
        Tiempo();
    }
    private void Update()
    {
        x = Random.Range(-8.41f, 8.41f);
        transform.position = new Vector2(x,transform.position.y);
    }
    void Tiempo()
    {
        Invoke("Tiempo",3);
       GameObject Alien= Instantiate(alien, transform.position, transform.rotation);
        Alien.GetComponent<avanzar>().Ratoncito(puntitos);
    }

}
