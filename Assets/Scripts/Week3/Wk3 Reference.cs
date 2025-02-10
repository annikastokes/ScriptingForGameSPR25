using Unity.Android.Types;
using UnityEngine;
using UnityEngine.UIElements;

public class Wk3Reference : MonoBehaviour
{

    public Light LightToChange;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeLightColor(Color scarlet)
    {
        LightToChange.color = scarlet;

        if(LightToChange.color == Color.green)
        {
            LightToChange.intensity = 100f;
        }

        else if(LightToChange.color == Color.blue)
        {
            LightToChange.transform.position += Vector3.right * 3;
        }

        else if(LightToChange.color == Color.red)
        {
        }

        else //none of the above conditions were met, so do this if the light isn't green, red, or blue              
        {
            LightToChange.transform.position = Vector3.zero;
        }

        //conditionals

        //if it's green or red, this will run

        if (LightToChange.color == Color.green || LightToChange.color == Color.red)
                {

        }
       
        //if it's blue AND the intensity is greater than 50, it will run

        if (LightToChange.color == Color.blue && LightToChange.intensity > 50f)
        {

        }

        //if the light is white OR if the color is black and its intensity is greater than 34, this will run
       if(LightToChange.color == Color.white || (LightToChange.color == Color.black && LightToChange.intensity > 34f))
        {

        }
      


    }
}


  