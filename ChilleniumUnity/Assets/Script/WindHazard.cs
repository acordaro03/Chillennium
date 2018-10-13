using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindHazard : MonoBehaviour {
    GameObject Mc;
    public float windSheer = 1f;

    void Start()
    {
        GameObject Mc = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Mc_Movement mc_Movement = GetComponent<Mc_Movement>();
        mc_Movement.speed -= windSheer;
    }
}


