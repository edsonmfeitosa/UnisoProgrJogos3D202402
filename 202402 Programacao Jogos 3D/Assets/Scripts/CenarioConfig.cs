using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenarioConfig : MonoBehaviour
{
    [SerializeField] private Color corAgua;
    [SerializeField] private float densidadeAgua;
    [SerializeField] private Transform cabecaPlayer;
    [SerializeField] private Transform agua;
    [SerializeField] private FogMode modoFog;
    void Start()
    {
        
    }

    void Update()
    {
        if (cabecaPlayer.position.y < agua.position.y)
        {
            //de baixo da água
            RenderSettings.fog = true;
            RenderSettings.fogColor = corAgua;
            RenderSettings.fogDensity = densidadeAgua;
            RenderSettings.fogMode = modoFog;
        }
        else
        {
            //de cima da água
            RenderSettings.fog = false;
        }
    }
}
