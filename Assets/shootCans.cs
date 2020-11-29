// Code is from CS 426 class by Liz Marai

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootCans : MonoBehaviour
{
    public float speed = 1.0f;
    public float rotationSpeed = 90;
    public float force = 20f;
    public GameObject cannon;
    public GameObject bullet;

    Rigidbody rb;
    Transform t;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    public void shootcan()
    {
        GameObject newBullet = GameObject.Instantiate(bullet, cannon.transform.position, cannon.transform.rotation) as GameObject;
        newBullet.GetComponent<Rigidbody>().velocity += Vector3.up * 10;
        newBullet.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * 1500);
    }
}