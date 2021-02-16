using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    public Vector3 direction;
    
    public float speed;
    private Rigidbody rb;

    private float intensity;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola crayola");
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Meve 1 unidad de distancia por cada frame
        //transform.Translate(direction * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.P))
        {
            rb.AddForce(direction * speed, ForceMode.Force);
        }

        Vector3 velocity = rb.velocity;
        Vector3 angularVelocity = rb.angularVelocity;
        intensity = 2 * Mathf.PI;
        Vector3 magnus = Vector3.Cross(velocity, angularVelocity * intensity);
        rb.AddForce(magnus, ForceMode.Force);
    }
}
