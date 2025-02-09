using UnityEngine;
using System.Collections;

public class toggledagger : MonoBehaviour
{

    public GameObject cult;

    public Material horror;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.cult.SetActive(false);
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
        }

        DynamicGI.UpdateEnvironment();

        Debug.Log("Cult has been toggled");

    }
}
