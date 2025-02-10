using UnityEngine;

public class folkmusic : MonoBehaviour
{
    public AudioSource source;
    public AudioClip folkmusi;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.W))
            {
                source.Play();
            }

            if (Input.GetKeyUp(KeyCode.W))
            {
                source.Stop();
            }
    }
}
