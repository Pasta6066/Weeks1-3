using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    public float speed = 5;
    public bool hasBeenFired = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasBeenFired == true)
        {
            BeamMovement();
        }
    }

    void BeamMovement()
    {
        transform.position += transform.up * speed * Time.deltaTime; 
    }
}
