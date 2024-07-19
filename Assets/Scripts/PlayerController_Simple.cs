using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Simple : MonoBehaviour
{
    public float speed = 5f;
    public float forwardSpeed = 10f;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
       
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, vertical, 1f).normalized;


        if (direction.magnitude >= 0.1f)
        {
            Vector3 move = direction * speed * Time.deltaTime;
            move.z = forwardSpeed * Time.deltaTime;
            controller.Move(move);
        }
    }

}


