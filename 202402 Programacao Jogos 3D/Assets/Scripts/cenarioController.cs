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
    [Header("Compartilhar informações")]
    [SerializeField] private CompartilhadoScriptableObj dadosJogador;
    [Header("Salvar e carregar informações")]
    [SerializeField] private GameObject saveLoad;
    private bool abreMenuSalvar = false;
    [SerializeField] private InputField txtNome;
    [SerializeField] private Text txtLoad;
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
        Compartilhado.itens = qtdItem;

        //forma de passar dados para o scriptable object
        dadosJogador.tempo = contTempo;
        dadosJogador.item = qtdItem;
        dadosJogador.posicao = GameObject.Find("bolinha").transform.position;

        menuSave();
        if (PlayerPrefs.HasKey("nome"))
        {
            txtLoad.text = PlayerPrefs.GetString("nome");
        }
    }
    void menuSave() {         
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            abreMenuSalvar = !abreMenuSalvar;
            saveLoad.SetActive(abreMenuSalvar);
            if(abreMenuSalvar )
                Time.timeScale = 1;
            else
                Time.timeScale = 0;
        }
    }
    public void salvar()
    {
        PlayerPrefs.SetInt("itens", qtdItem);
        PlayerPrefs.SetFloat("tempo", contTempo);
        PlayerPrefs.SetFloat("posX", GameObject.Find("bolinha").transform.position.x);
        PlayerPrefs.SetFloat("posY", GameObject.Find("bolinha").transform.position.y);
        PlayerPrefs.SetFloat("posZ", GameObject.Find("bolinha").transform.position.z);
        PlayerPrefs.SetString("nome", txtNome.text);
        txtLoad.text = txtNome.text;
    }
    public void carregar()
    {
        if (PlayerPrefs.HasKey("nome"))
        {
            qtdItem = PlayerPrefs.GetInt("itens");
            contTempo = PlayerPrefs.GetFloat("tempo");
            GameObject.Find("bolinha").transform.position =
                new Vector3(PlayerPrefs.GetFloat("posX"),
                            PlayerPrefs.GetFloat("posY"),
                            PlayerPrefs.GetFloat("posZ"));
        }
    }

    public void apagarSaves()
    {
        PlayerPrefs.DeleteAll();
        txtLoad.text = "";
    }
}
