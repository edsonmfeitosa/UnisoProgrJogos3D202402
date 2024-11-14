using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portalController : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "bolinha")
        {
            //trocar de cena
            //Application.LoadLevel("cena2");
            SceneManager.LoadScene("AulaCamera");
        }
    }
}
