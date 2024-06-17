using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class escena : MonoBehaviour
{
    public string escenita;
    public void cambioescena()
    {
        SceneManager.LoadScene(escenita);
    }
}
