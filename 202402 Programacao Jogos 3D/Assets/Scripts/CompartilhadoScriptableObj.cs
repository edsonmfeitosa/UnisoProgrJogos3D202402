using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Jogador", menuName = "Player/Dados")]
public class CompartilhadoScriptableObj : ScriptableObject
{
    public int item;
    public float tempo;
    public Vector3 posicao;
}
