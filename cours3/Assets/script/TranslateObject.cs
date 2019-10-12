using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateObject : MonoBehaviour
{   // camera
    public Vector3 m_Direction = new Vector3(0f, 1f, 0f);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(m_Direction * Time.deltaTime);  
    }
}
