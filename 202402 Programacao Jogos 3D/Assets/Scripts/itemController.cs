using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemController : MonoBehaviour
{
    [SerializeField] private Vector3 giro;
    [SerializeField] private cenarioController cenario;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(giro);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "bolinha")
        {
            //cenario.qtdItem = cenario.qtdItem + 1;
            cenario.qtdItem++;
            Destroy(gameObject);
        }
    }
}
