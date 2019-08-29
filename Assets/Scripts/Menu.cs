using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField]
    AudioSource music;
    [SerializeField]
    public enum opciones {
        Play,
        Stop,
        Pause
    }
    [SerializeField]
    opciones Op;
    void onTriggerEnter(Collider other){
        switch(Op){
            case opciones.Play:
                music.Play();
            break;
            case opciones.Stop:
                music.Stop();
            break;
            case opciones.Pause:
                music.Pause();
            break;
        }
    }
}
