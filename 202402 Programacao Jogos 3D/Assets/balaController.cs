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
        forca.AddForce(Vector3.forward * velocidade, ForceMode.Impulse);
    }

    void Update()
    {
        
    }
}
