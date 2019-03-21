using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            GetComponent<Rigidbody2D>().velocity.y);

    }
}
