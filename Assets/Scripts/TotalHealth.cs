using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TotalHealth : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI VidaUI;

    private int da�oEnemy = 10;
    private int vidaTotal = 100;
    public GameObject Finish;

    public void Update()
    {
        VidaUI.text = vidaTotal.ToString();
    }


    public void agregarDa�o()
    {
        vidaTotal -= da�oEnemy;

        vidaTotal = Mathf.Max(vidaTotal, 0);


        Debug.Log(VidaUI.text);

                if(vidaTotal == 0) 
                {
                    Finish.SetActive(true);
                }

    }

 

   
}

