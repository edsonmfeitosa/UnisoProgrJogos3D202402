using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cenarioController : MonoBehaviour
{
    public int qtdItem = 0;
    private float contTempo = 0;
    [SerializeField] private Text tempo;
    [SerializeField] private Text quantidadeItens;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //contTempo += Time.deltaTime;
        contTempo = contTempo + Time.deltaTime;
        tempo.text = "Tempo: "+ contTempo;
        quantidadeItens.text = "Itens : "+qtdItem;
    }
}
