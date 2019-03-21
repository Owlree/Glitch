using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            GetComponent<Rigidbody2D>().velocity.y);

    }
}
