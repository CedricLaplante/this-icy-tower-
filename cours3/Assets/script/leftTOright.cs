using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftTOright : MonoBehaviour
{
    //variable complexe de rigidbody, le liens est fait dans l'editeur sur le player
    public Rigidbody m_RigidBody;
    Vector3 m_Velocity = new Vector3();
   
    void Start()
    {
        
    }

    // Update is called once per frame 
    void Update()
    {
        m_Velocity = m_RigidBody.velocity;


        if (Input.GetKey(KeyCode.A))
        {
            m_Velocity.x = -5f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
             m_Velocity.x = 5f;
        }
        else
        {
            m_Velocity.x = 0f;
        }
    }
    private void FixedUpdate()
    {
        m_RigidBody.velocity = m_Velocity;
    }
}
