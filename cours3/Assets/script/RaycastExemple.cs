using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastExemple : MonoBehaviour
{
    RaycastHit hit;
    Vector3 m_Raycast = new Vector3(0f, -1f, 0f); 
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        Debug.DrawRay(transform.position, m_Raycast, Color.red);
        RaycastHit hit; 
        if (Physics.Raycast(transform.position, m_Raycast, out hit, 100f))
        {
            Debug.Log(hit.distance);
        }
        else
        {
            Debug.Log("nope");
        }
    }
}    

        
    
