using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody m_RigidBody;
    public Vector3 m_Force = new Vector3();

    void Start()
    {
       
    }

    private bool m_IsOnGround;
    
    // Update is called once per frame
    void Update()
    {
        if (m_IsOnGround && Input.GetKeyDown(KeyCode.Space))
        {
            m_RigidBody.AddForce(m_Force);
        }

        RaycastHit hit;
        // Vector3.up == new Vector3(of, 1f, 0f)
        // -Vector3.up == new Vector(0f, -1f, 0f)
        // si Mon raycast est vrai, mon raycast a toucher un collider, si mon raycast est faux, mon raycast n'a pas toucher de collider 

        // Vector3 v1 = new Vector3(0f, 1f, 0f);
        // Vector3 v2 = new Vector3(1f, 0f, 1f);
        // Vector3 v3 = v1 + v2; // v3.x = v1.x + v2.x // v3.y = v1.y + v2.y

        //On décale le raycast de 0.1f en y pour que le raycast soit lancer un peu plus haut que la collision de la plateforme
        Vector3 raycastOrigin = new Vector3(0.5f, 0f, 0f);
        
        if (Physics.Raycast(transform.position, -Vector3.up, out hit, 0.2f))            
        {
            // J'AI TOUCHER UN COLLIDER
            m_IsOnGround = true;
            Debug.Log("TOUCHE");
        }
        else
        {
            // J'AI PAS TOUCHER AU COLLIDER
            m_IsOnGround = false;
            Debug.Log("TOUHCE PAS");
        }

        Debug.DrawRay(transform.position + new Vector3(0f, 0.1f, 0f), -Vector3.up * 0.2f, Color.black);

    }
}
