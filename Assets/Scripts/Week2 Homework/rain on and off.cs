using UnityEngine;
using System.Collections;

public class rainonandoff : MonoBehaviour
{
        
    public GameObject rain;

    public Material rainy;

    public Material midnight;

    public Material dusk;

    public AudioSource source;

    public AudioClip rainsounds;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RenderSettings.skybox = rainy;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ToggleActiveState()
    {
        rain.SetActive(!rain.activeSelf);

        RenderSettings.skybox = rainy;

        source.clip = rainsounds;
        source.Play();
            
        if (rain.activeSelf == true)
        {
            source.Play();
            rain.SetActive(true);
        }
        else
        {
            source.Stop();  
            rain.SetActive(false);
        }

        DynamicGI.UpdateEnvironment();

        Debug.Log("the rain has been toggled");
    }
}

