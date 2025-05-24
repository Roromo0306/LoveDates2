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

    public void PasarViKVideo()
    {
        animator.SetTrigger("DialogoTerminado");
        StartCoroutine(VideoVik());
    }

    IEnumerator VideoVik()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Video Vik");
    }

    public void CitaVik()
    {
        animator.SetTrigger("DialogoTerminado");
        StartCoroutine(Vik());
    }

    IEnumerator Vik()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Cita Vik");
    }

    public void PasarMorganaVideo()
    {
        animator.SetTrigger("DialogoTerminado");
        StartCoroutine(VideoMorgana());
    }

    IEnumerator VideoMorgana()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Video Morgana");
    }

    public void CitaMorgana()
    {
        animator.SetTrigger("DialogoTerminado");
        StartCoroutine(Morgana());
    }

    IEnumerator Morgana()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Cita Morgana");
    }

    public void PasarZoeVideo()
    {
        animator.SetTrigger("DialogoTerminado");
        StartCoroutine(VideoZoe());
    }

    IEnumerator VideoZoe()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Video Zoe");
    }

    public void CitaZoe()
    {
        animator.SetTrigger("DialogoTerminado");
        StartCoroutine(Zoe());
    }

    IEnumerator Zoe()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Cita Zoe");
    }

    public void VolverMenu()
    {
        animator.SetTrigger("DialogoTerminado");
        StartCoroutine(Menu());
    }

    IEnumerator Menu()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("MainMenu");
    }
}
