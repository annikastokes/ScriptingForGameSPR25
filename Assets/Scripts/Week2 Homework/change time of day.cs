using UnityEngine;

public class changetimeofday : MonoBehaviour
{

    public Material dawn;
    public Material dusk;
    public Material night;
    public Material rainy;
    public Material noon;
    public Material nightrainy;

    public GameObject rain;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("the time of day has changed");

        if (Input.GetKeyDown(KeyCode.A))
        {
            RenderSettings.skybox = dawn;

            if (rain.activeSelf)
            {
                RenderSettings.skybox = rainy;
            }
        }

        if (Input.GetKeyDown(KeyCode.B))
            {
                RenderSettings.skybox = dusk;

                if(rain.activeSelf)
                {
                    RenderSettings.skybox = nightrainy;
                }
            }

        if (Input.GetKeyDown(KeyCode.C))
            {
                RenderSettings.skybox = noon;

                if (rain.activeSelf)
                {
                    RenderSettings.skybox = rainy;
                }
            }

        if (Input.GetKeyDown(KeyCode.D))
        {
            RenderSettings.skybox = night;

            if (rain.activeSelf)
            {
                RenderSettings.skybox = nightrainy;
            }
        }
            
      
    }
}