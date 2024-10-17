using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerConroller : MonoBehaviour
{
    [SerializeField] private Animator anim;
    private float MovX;
    private float MovY;
    [SerializeField] private float velocidade;
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

    }
}
