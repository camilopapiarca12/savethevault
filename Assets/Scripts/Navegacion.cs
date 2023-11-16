using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using UnityEngine.SceneManagement;
public class Navegacion : MonoBehaviour
{
    
    
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Instrucciones()
    {
        Debug.Log("Preiono instruccionesS");
    }

    public void Ajustes()
    {
        Debug.Log("Preiono Ajustes");
    }


    public void Creditos()
    {
        Debug.Log("Preiono Creditos");
    }

    public void Salir()
    {
        Debug.Log("Preiono Salir");
    }

    public void MenuIni()
    {
        SceneManager.LoadScene(0);
    }
}


