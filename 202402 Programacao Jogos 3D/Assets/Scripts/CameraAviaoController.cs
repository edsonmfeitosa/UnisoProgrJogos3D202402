using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAviaoController : MonoBehaviour
{
    [SerializeField] private aviaoController aviao;
    [SerializeField] private Camera camPrimeiraPessoa;
    [SerializeField] private Camera camTerceiraPessoa;
    [SerializeField] private Camera camRetrovisor;
    private bool primeiraPessoa = false;
    [SerializeField] private KeyCode mudarCamera;
    [SerializeField] private KeyCode Retrovisor;
    void Start()
    {
        
    }

    void Update()
    {
        if (aviao.estaLigado)
        {
            camPrimeiraPessoa.enabled = true;
            camTerceiraPessoa.enabled = true;
            camRetrovisor.enabled = false;
            mudarCameras();
        }
        else
        {
            camPrimeiraPessoa.enabled = false;
            camTerceiraPessoa.enabled = false;
            camRetrovisor.enabled = false;
        }
    }
    void mudarCameras()
    {
        if (Input.GetKeyDown(mudarCamera))
        {
            primeiraPessoa = !primeiraPessoa;
            if (primeiraPessoa)
            {
                camPrimeiraPessoa.depth = 2;
                camTerceiraPessoa.depth = 0;
                camRetrovisor.depth = 0;
            }
            else
            {
                camPrimeiraPessoa.depth = 0;
                camTerceiraPessoa.depth = 2;
                camRetrovisor.depth = 0;

            }
        }
        if (Input.GetKey(Retrovisor))
        {
            camRetrovisor.enabled = true;
        }
    }
}
