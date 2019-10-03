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
        //Time.DeltaTime = durée entre le frame présent et le dernier frame
        // donc 60 fps, time.DeltaTime = 1 / 60 = 0.016666666666;
        transform.Translate(m_Direction * Time.deltaTime); // bouger dans la direction à tout les secondes.
    }
}
