using UnityEngine;

public class ominousmusic : MonoBehaviour
{
    public AudioSource source;
    public AudioClip ominousmusi;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            source.Play();
        }

        if(Input.GetKeyUp(KeyCode.Q))
                {
            source.Stop();
        }

    }
}
