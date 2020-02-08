using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementHexData
{
    private float sunIncrement = 999.9f;
    private float waterIncrement;


    public void setSunIncrement(float inc)
    {
        sunIncrement = inc;
    }
    public float getSunIncrement()
    {
        return sunIncrement;
    }
}
