using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexController : MonoBehaviour
{
    IncrementHexData[] dataIncrements;
    public float[] hexData;
    public void SetIncrementHexData(IncrementHexData[] newDataIncrements)
    {
        dataIncrements = newDataIncrements;
    }
    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("awake");
        hexData = new float[5]; //Planet hex  number
    }


    void PrintHexData()
    {
        for (int i = 0; i < hexData.Length; i++)
        {
            Debug.Log(i);
            Debug.Log(hexData[i]);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void tick()
    {
        Debug.Log("hex tick ");
        Debug.Log(dataIncrements.Length);
        Debug.Log(hexData.Length);

        for(int i = 0; i < dataIncrements.Length; i++)
        {
            hexData[i] += dataIncrements[i].getSunIncrement();
        }
        PrintHexData();
    }
}
