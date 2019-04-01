using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow: MonoBehaviour
{
    public GameObject follow;

    void LateUpdate()
    {
        float myX = transform.position.x;
        float followX = follow.transform.position.x;

        transform.position = new Vector3(
            Mathf.Clamp(myX, followX + 1, followX + 3),
            transform.position.y,
            transform.position.z);
    }
}
