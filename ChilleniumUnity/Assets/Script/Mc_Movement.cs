using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mc_Movement : MonoBehaviour {

	public float Mc_speed;

    public Rigidbody2D Mc_rb;

    void Start()
    {
        Mc_rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float movementHori = Input.GetAxis("Horizontal");
        float movementVerti = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(movementHori, 0.0f, movementVerti);

        Mc_rb.AddForce(movement * Mc_speed);
    }
}
