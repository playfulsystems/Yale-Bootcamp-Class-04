using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        // add horizontal movement to move Vector
        float hInput = Input.GetAxis("Horizontal");
        Vector3 move = Vector3.right * hInput * speed * Time.deltaTime;

        // add vertical movement to the move Vector
        float vInput = Input.GetAxis("Vertical");
        move += Vector3.forward * vInput * speed * Time.deltaTime;

        // rotate character to direction its moving based on the move vector
        transform.LookAt(transform.position + move);

        // move character
        transform.position += move;

        // update our Animator parameter curRunSpeed
        GetComponent<Animator>().SetFloat("curRunSpeed", move.magnitude);
    }
}
