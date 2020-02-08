using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public LevelController instance;
    public EnvController envController;
    public HexController hexController;
    public PlanetGenerator planetGenerator;
    public Planet planet;
    bool run;

    private void Awake()
    {
        instance = this;
        planet = planetGenerator.GeneratePlanet();
        envController.CreateIncrementHexData(planet.GetHexCount());
    }

    void GameOver()
    {
        run = false;
    }

    void Start()
    {
        run = true;
    }

    void Update()
    {
        if (run)
        {
            envController.tick();
            hexController.tick();
        }
    }
}
