using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoInicial: MonoBehaviour
{
    public VideoPlayer video;

    private void Awake()
    {
        video = GetComponent<VideoPlayer>();
        video.Play();
        video.loopPointReached += Fin;
    }

    private void Fin(VideoPlayer v)
    {
        gameObject.SetActive(false);
        SceneManager.LoadScene("Bienvenida");

    }
}
