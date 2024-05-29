using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject player;

    [SerializeField] float positionX;

    [SerializeField] float positionY;

    [SerializeField] float positionZ;



    void Update()
    {
        gameObject.transform.position = new Vector3(player.transform.position.x - positionX, positionY, positionZ);
    }
}
