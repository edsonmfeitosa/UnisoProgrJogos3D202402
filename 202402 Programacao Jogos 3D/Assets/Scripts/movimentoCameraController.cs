using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoCameraController : MonoBehaviour
{
    [SerializeField] GameObject bolinha;
    private Vector3 posicaoInicial;
    private Vector3 posicaoAtual;
    void Start()
    {
        posicaoInicial = bolinha.transform.position;
    }


    void Update()
    {
        posicaoAtual = bolinha.transform.position;
        transform.position = transform.position + 
            (posicaoAtual - posicaoInicial);
        posicaoInicial = bolinha.transform.position;
    }
}
