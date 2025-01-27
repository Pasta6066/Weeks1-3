using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamSpawner : MonoBehaviour
{
    public GameObject WifiBeam;
    public Beam beam;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (beam == null)
        {
            Spawn();
        }

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Spawn()
    {
        GameObject spawnedBeam = Instantiate(WifiBeam);
        beam = spawnedBeam.GetComponent<Beam>();
    }
        
    void Fire()
    {
        beam.hasBeenFired = true;
        beam = null;
    }
}
    

