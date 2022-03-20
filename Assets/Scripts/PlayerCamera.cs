using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Camera camera;
    public Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        this.camera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerControl();
    }

    void PlayerControl()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 forward = this.transform.forward;
            this.rigidBody.velocity = this.transform.forward * 5.0f;
        }
        else
        {
            this.rigidBody.velocity = Vector3.zero;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidBody.angularVelocity = new Vector3(0.0f, -3.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidBody.angularVelocity = new Vector3(0.0f, 3.0f, 0.0f);
        }
        else
        {
            rigidBody.angularVelocity = Vector3.zero;
        }
    }
}
