using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aviaoController : MonoBehaviour
{
    [Header("Sistema da Elise")]
    [SerializeField] private GameObject elise;
    [SerializeField] private float velocidade;

    [Header("Input do avião")]
    [SerializeField] private KeyCode acelerar;
    [SerializeField] private KeyCode frear;
    [SerializeField] private KeyCode paraCima;
    [SerializeField] private KeyCode paraBaixo;
    [SerializeField] private KeyCode paraEsquerda;
    [SerializeField] private KeyCode paraDireita;
    private float velocidadeAviao = 0;
    [SerializeField] public bool estaLigado = false;
    void Start()
    {
        
    }

    void Update()
    {
        if (estaLigado)
        {
            giroElise();
            movimentoAviao();
        }
        
    }
    void movimentoAviao()
    {
        #region sistema de acelear e frear
        if (Input.GetKey(acelerar))
            velocidadeAviao += 0.1f;
        if (Input.GetKey(frear))
        {
            if(velocidadeAviao > 0.1f)
                velocidadeAviao -= 0.1f;
        }

        transform.Translate(Vector3.up * -velocidadeAviao);
        #endregion

        //sistema de movimentação do avião
        float movX = 0;
        float movY = 0;
        if (Input.GetKey(paraCima))
            movX -= 1;
        if (Input.GetKey(paraBaixo))
            movX += 1;
        if(Input.GetKey(paraEsquerda))
            movY -= 1;
        if(Input.GetKey(paraDireita))
            movY += 1;

        transform.Rotate(new Vector3(movX, movY, movY));
    }
    void giroElise()
    {
        elise.transform.Rotate(new Vector3(0, Time.deltaTime * velocidade, 0));
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "player")
        {
            estaLigado = true;
            //Destroy(collision.collider.gameObject);
            collision.collider.gameObject.SetActive(false);
        }
            

    }
}
