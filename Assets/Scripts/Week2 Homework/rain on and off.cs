using UnityEngine;
using System.Collections;

public class rainonandoff : MonoBehaviour
{
        
    public GameObject rain;

    public Material rainy;

    public Material midnight;

    public Material dusk;


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
        if (rain.activeSelf)
        {
            RenderSettings.skybox = rainy;
        }

        DynamicGI.UpdateEnvironment();

        Debug.Log("the rain has been toggled");
     }
}