using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour
{
    [SerializeField] PlayerMovement playerMovement;
//    [SerializeField] SideMovement sideMovement;

    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    //    sideMovement = GetComponent<SideMovement>();

        playerMovement.enabled = true;
  //      sideMovement.enabled = false;
    }


    public void SwitchControls()
    {
        if (playerMovement.enabled == true)
        {
            playerMovement.enabled = false;
    //        sideMovement.enabled = true;
        }

        else
        {
            playerMovement.enabled = true;
      //      sideMovement.enabled = false;
        }
    }
}
