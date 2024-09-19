using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiroController : MonoBehaviour
{
    [SerializeField] private GameObject bala;
    [SerializeField] private GameObject cano;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var b = Instantiate(bala, cano.transform.position, cano.transform.rotation);
            Destroy(b, 3);
        }
    }
}
