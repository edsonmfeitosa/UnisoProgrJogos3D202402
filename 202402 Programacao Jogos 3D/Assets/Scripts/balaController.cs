using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaController : MonoBehaviour
{
    [SerializeField] private float velocidade;
    private Rigidbody forca;
    void Start()
    {
        forca = GetComponent<Rigidbody>();
        forca.AddForce(transform.forward * velocidade, ForceMode.Impulse);
    }

    void Update()
    {
        
    }
}
