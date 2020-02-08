using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvController : MonoBehaviour
{
    IncrementHexData[] dataIncrements;
    public HexController hexController;

    public void CreateIncrementHexData(int hexCount)
    {
        dataIncrements = new IncrementHexData[hexCount];
        for(int i = 0; i  < dataIncrements.Length; i++)
        {
            dataIncrements[i] = new IncrementHexData(); 
        }
        hexController.SetIncrementHexData(dataIncrements);
    }

    public void setIncrement(float inc)
    {
        foreach(IncrementHexData data in dataIncrements)
             data.setSunIncrement(inc);
       // dataIncrements[0].setSunIncrement(inc);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void tick()
    {
        Debug.Log("env tick");
        this.setIncrement(1);
    }

}
