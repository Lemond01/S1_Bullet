using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour
{
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] float time;
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
            StartCoroutine(delaySwitcvh());
        }

        else
        {
            playerMovement.enabled = true;
      //      sideMovement.enabled = false;
        }
    }

    IEnumerator delaySwitcvh()
    {
        yield return new WaitForSeconds(time);
        SwitchControls();
    }
}
