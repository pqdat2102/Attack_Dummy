using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DropdownScrips : MonoBehaviour
{
    [SerializeField] private ActionBasedSnapTurnProvider snapturn;
    
    [SerializeField] private ActionBasedContinuousTurnProvider continuousTurn;  

    public void TrunProviderSelect(int index)
    {
        if (index  == 0)
        {
            snapturn.enabled = true;
            continuousTurn.enabled = false;
        }

        if (index == 1)
        {
            snapturn.enabled = false;
            continuousTurn.enabled = true;
        }
    }

    public void Exit()
    {
        Application.Quit(); 
    }
}
