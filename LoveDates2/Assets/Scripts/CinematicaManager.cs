using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CinematicaManager : MonoBehaviour
{
    public Animator animator;
   public void PasarCinematica()
    {
        animator.SetTrigger("DialogoTerminado");
        StartCoroutine(PasarVideo());
    }

    IEnumerator PasarVideo()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Bienvenida");
    }

    public void Comenzar()
    {
        animator.SetTrigger("DialogoTerminado");
        StartCoroutine(ComenzarJuego());
    }

    IEnumerator ComenzarJuego()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Video Marcos");
    }

    public void CitaMarcos()
    {
        animator.SetTrigger("DialogoTerminado");
        StartCoroutine(Marcos());
    }

    IEnumerator Marcos()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Cita Marcos");
    }
}
