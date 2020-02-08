using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGenerator : MonoBehaviour
{

    public Planet GeneratePlanet(int seed = 0)
    {
        return new Planet();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
}
