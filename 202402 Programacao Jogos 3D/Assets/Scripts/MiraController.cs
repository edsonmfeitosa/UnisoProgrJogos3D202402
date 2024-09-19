using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiraController : MonoBehaviour
{
    [Header("Laser")]
    [SerializeField] private GameObject laser;
    [SerializeField] private LineRenderer line;
    [SerializeField] private float distancia;
    [SerializeField] private KeyCode habilitaLaser;
    private bool laserHabilitado = false;

    [Header("Lupa")]
    [SerializeField] GameObject cameraLupa;
    [SerializeField] KeyCode habilitaCameraLupa;
    private bool camHabilitada = false;

    void Start()
    {
        line = laser.GetComponent<LineRenderer>();
    }


    void Update()
    {
        #region laser
        line.SetPosition(0, laser.transform.position);
        line.SetPosition(1, transform.forward * distancia);

        if (Input.GetKeyDown(habilitaLaser))
            laserHabilitado = !laserHabilitado;

        if (laserHabilitado) 
            laser.SetActive(true);
        else 
            laser.SetActive(false);
        #endregion

        #region lupa
        if (Input.GetKeyDown(habilitaCameraLupa))
            camHabilitada = !camHabilitada;
        if (camHabilitada)
            cameraLupa.SetActive(true);
        else
            cameraLupa.SetActive(false);
        #endregion

    }
}
