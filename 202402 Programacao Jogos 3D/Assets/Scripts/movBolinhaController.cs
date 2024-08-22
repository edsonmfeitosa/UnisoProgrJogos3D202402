using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movBolinhaController : MonoBehaviour
{
    [Header("Configuração")]
    private float x;
    private float z;
    public Vector3 entrada;
    [Header("Inputs")]
    [SerializeField] private float velocidade;
    [Tooltip("Tecla para frente")]
    [SerializeField] private KeyCode paraFrente;
    [SerializeField] private KeyCode paraTraz;
    [SerializeField] private KeyCode paraEsquerda;
    [SerializeField] private KeyCode paraDireita;
    [SerializeField] private KeyCode pulo;

    private Rigidbody forca;
    [SerializeField] private float velocidadePulo;
    private bool podePular = false;
    void Start()
    {
        forca = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        #region 1ª forma de input
        //x = Input.GetAxis("Horizontal");
        //z = Input.GetAxis("Vertical");
        //entrada = new Vector3(x, 0, z);
        #endregion

        #region 2ª forma de input
        x = 0;
        z = 0;
        if (Input.GetKey(paraFrente))
        {
            z = 1;
        }
        if (Input.GetKey(paraTraz))
        {
            z = -1;
        }
        if (Input.GetKey(paraDireita))
        {
            x = 1;
        }
        if (Input.GetKey(paraEsquerda))
        {
            x = -1;
        }
        entrada = new Vector3(x, 0, z);
        #endregion

        #region 1ª forma de movimentação da bolinha
        transform.Translate(entrada * Time.deltaTime * velocidade);
        #endregion

        #region 2ª forma de movimentação da bolinha
        //forca.AddForce(entrada * velocidade);
        #endregion

        #region 3ª forma de movimentação da bolinha
        //forca.velocity = entrada * velocidade   ;
        #endregion

        //pulo
        if(Input.GetKeyDown(pulo) && podePular)
        {
            forca.AddForce(new Vector3(0, 1, 0) * velocidadePulo, ForceMode.Impulse);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "chao")
        {
            podePular = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.name == "chao")
        {
            podePular = false;
        }
    }
}
