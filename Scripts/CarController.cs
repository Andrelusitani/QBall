using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class CarController : NetworkBehaviour {

    public float speed;
    private Rigidbody rb;
    public VirtualJoystick virtualJoystick;

    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame



    void FixedUpdate()
    {
        if (isLocalPlayer)
        {
            return;
        }

        Vector3 dir = PoolInput();
        float moveHorizontal = dir.x;
        float moveVertical = dir.z;
       

       Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
    private Vector3 PoolInput()
    {
        Vector3 dir = Vector3.zero;

        dir.x = virtualJoystick.Horizontal();
        dir.z = virtualJoystick.Vertical();

        if (dir.magnitude > 1)
            dir.Normalize();

        return dir;
    }

    public override void OnStartLocalPlayer()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
       
}

