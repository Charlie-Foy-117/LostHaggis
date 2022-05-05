using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public float dampTime = 0.4f;
    public Vector3 cameraPos;
    public Vector3 velocity = Vector3.zero;

    void Update()
    {
        cameraPos = new Vector3(player.position.x, player.position.y, -10f);
        transform.position = Vector3.SmoothDamp(gameObject.transform.position, cameraPos, ref velocity, dampTime);
    
    }
}