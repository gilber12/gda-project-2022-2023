using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 6f;

    // Update is called once per frame
    void Update()
    {
        /*float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            controller.Move(direction * speed * Time.deltaTime);
        }*/

        //Vector3 forward = new Vector3(0f, 0f, 1f).normalized;
        //controller.Move(Vector3.forward * speed * Time.deltaTime);

        transform.position += ((Vector3.forward) * speed * Time.deltaTime);

        Vector3 laneChange = new Vector3(5.5f, 0, 0);

        if (Input.GetKeyDown(KeyCode.D) && transform.position.x != 5.5f)
        {
            transform.position += laneChange;
        }
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x != -5.5f)
        {
            transform.position -= laneChange;
        }
    }
}
