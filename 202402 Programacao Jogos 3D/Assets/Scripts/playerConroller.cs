using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerConroller : MonoBehaviour
{
    [SerializeField] private Animator anim;
    private float MovX;
    private float MovY;
    [SerializeField] private float velocidade;

    [SerializeField] private CompartilhadoScriptableObj dadosJogador;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        MovX = Input.GetAxis("Horizontal");
        MovY = Input.GetAxis("Vertical");
        if(MovX != 0 || MovY != 0)
            anim.SetBool("podeAndar", true);
        else
            anim.SetBool("podeAndar", false);
        transform.Translate(new Vector3(MovX, 0, MovY) * Time.deltaTime * velocidade);
        transform.rotation = Quaternion.LookRotation(new Vector3(MovX, 0, MovY));

        //informa��o compartilhada da tela da bolinha
        Debug.Log("Quantidade de itens que a bolinha pegou: " + Compartilhado.itens);
        //informa��o compartilhada do scriptable object
        Debug.Log("Quantidade de itens que o jogador pegou: " + dadosJogador.item);
        Debug.Log("Tempo que o jogador est� jogando: " + dadosJogador.tempo);
        Debug.Log("Posi��o da bolinha: " + dadosJogador.posicao);

    }
}
