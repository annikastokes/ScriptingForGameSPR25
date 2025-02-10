using UnityEngine;

public class harmonicamusic : MonoBehaviour
{
    public AudioSource source;
    public AudioClip harmonicamusi;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            source.Play();
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            source.Stop();
        }
    }
}
