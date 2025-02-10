using UnityEngine;
using System.Collections;

public class toggledagger : MonoBehaviour
{

    public GameObject cult;

    public Material horror;

    public GameObject biglight;

    public GameObject dawnlight;

    public GameObject noonlight;

    public AudioSource source;

    public ominousmusic AudioClip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void CultOnOff()
    {
        
        cult.SetActive(!cult.activeSelf);
        if (cult.activeSelf)
        {

            RenderSettings.skybox = horror;

            biglight.SetActive(false);

            RenderSettings.fog = (true);

            RenderSettings.fogColor = Color.red;

            if (cult.activeSelf == true)
            {
                source.Play();
                cult.SetActive(true);
            }
            else
            {
                source.Stop();
                cult.SetActive(false);
            }

            if (dawnlight.activeSelf)
            {
                dawnlight.SetActive(false);
            }

            if (noonlight.activeSelf)
            {
                noonlight.SetActive(false);
            }

        }

        DynamicGI.UpdateEnvironment();

        Debug.Log("Cult has been toggled");

        Debug.Log("Thank you for your help, Anthony!!");

    }
}