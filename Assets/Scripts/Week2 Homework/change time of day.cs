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

    public GameObject dawnlight;
    public GameObject noonlight;
    public GameObject biglight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("the time of day has changed");
    }

    public void Dawn()
    {
        RenderSettings.skybox = dawn;
        dawnlight.SetActive(!dawnlight.activeSelf);

        if (rain.activeSelf)
        {
            RenderSettings.skybox = rainy;
        }

        if (biglight.activeSelf == false)
        {
            biglight.SetActive(true);
        }

        if (noonlight.activeSelf)
        {
            noonlight.SetActive(false);
        }

    }

    public void Dusk()
    {
        RenderSettings.skybox = dusk;

        if (rain.activeSelf)
        {
            RenderSettings.skybox = nightrainy;
        }

        if (dawnlight.activeSelf)
        {
            dawnlight.SetActive(false);
        }

        if (noonlight.activeSelf)
        {
            noonlight.SetActive(false);
        }

        if (biglight.activeSelf == false)
        {
            biglight.SetActive(true);
        }



    }

    public void Night()
    {
        RenderSettings.skybox = night;
        biglight.SetActive(false);

        if (rain.activeSelf)
        {
            RenderSettings.skybox = nightrainy;

            if (dawnlight.activeSelf)
            {
                dawnlight.SetActive(false);
            }

            if (noonlight.activeSelf)
            {
                noonlight.SetActive(false);
            }

        }

    }

    public void Noon()
    {
        RenderSettings.skybox = noon;
        noonlight.SetActive(!noonlight.activeSelf);

        if (rain.activeSelf)
        {
            RenderSettings.skybox = rainy;
        }

        if (dawnlight.activeSelf)
        {
            dawnlight.SetActive(false);
        }

        if (biglight.activeSelf == false)
        {
            biglight.SetActive(true);
        }


    }
}
