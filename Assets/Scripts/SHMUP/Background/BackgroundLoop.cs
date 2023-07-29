using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{


    public float loopSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += new Vector3(loopSpeed * Time.deltaTime, 0f);

        if (transform.position.x < -19.1f)
        {
            transform.position = new Vector3(19.1f, 0f);
        }
    }
}
