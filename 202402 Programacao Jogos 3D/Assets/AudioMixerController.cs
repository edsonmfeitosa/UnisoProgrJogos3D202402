using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioMixerController : MonoBehaviour
{
    [SerializeField]AudioMixer audioMixer;
    [SerializeField]float volumeGeral = 0;
    [SerializeField] float delayDoRei = 0.5f;
    void Start()
    {
        
    }

    void Update()
    {
        audioMixer.SetFloat("volumeGeral", volumeGeral);
        audioMixer.SetFloat("delayRei", delayDoRei);
    }
}
