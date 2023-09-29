using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class Navegacion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Play()
    {
        Debug.Log("Preiono play");
        //MMSceneLoadingManager.LoadScene("KoalaDungeon");
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
}


