using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [Header("References")]
    [SerializeField] TextMeshProUGUI currencyUI;
    [SerializeField] Animator anim;

    private bool isMenuOpen = true;


    public void ToggleMenu()
    {
        isMenuOpen = !isMenuOpen;
        anim.SetBool("Menu", isMenuOpen);
    }

    private void OnUGUI()   
    {
        currencyUI.text = LevelManager.main.currency.ToString();
    }

    public void SetSelected()
    {
        
    }


}
