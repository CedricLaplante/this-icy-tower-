using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody rb;
    public float JumpForce = 7f;
    public SphereCollider col;
    public LayerMask groundLayer;

    void Start()
    {
       col = GetComponent<SphereCollider>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
             rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse); 
        }
    }
    
   
}
