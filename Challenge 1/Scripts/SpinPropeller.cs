using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
     private float propellerRotate = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate every frame from Z axis
        transform.Rotate(Vector3.forward,propellerRotate*Time.deltaTime );
    }
}
