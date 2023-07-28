using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceButton : MonoBehaviour
{

    [SerializeField] NextScene ns;

    [SerializeField] public string stringlol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ns.btn_change_scene(stringlol);
            
        }
    }
}
