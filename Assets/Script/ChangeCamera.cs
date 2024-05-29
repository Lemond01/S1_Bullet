using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    [SerializeField] GameObject mainCamera;

    [SerializeField] GameObject sideCamera;

    [SerializeField] MovementControl movementControl;

    void Start()
    {
        movementControl = FindFirstObjectByType<MovementControl>();
        mainCamera.gameObject.SetActive(true);
        sideCamera.gameObject.SetActive(false);
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        SwitchCamera();
        movementControl.SwitchControls();
    }

    public void SwitchCamera()
    {
        bool isCamera1Active = mainCamera.gameObject.activeSelf;

        mainCamera.gameObject.SetActive(!isCamera1Active);
        sideCamera.gameObject.SetActive(isCamera1Active);
    }
}
