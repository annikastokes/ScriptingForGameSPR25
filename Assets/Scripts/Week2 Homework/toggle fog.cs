using UnityEngine;
using System.Collections;

public class togglefog : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleFog()
    {
    
       
       RenderSettings.fog = !RenderSettings.fog;
       
        DynamicGI.UpdateEnvironment();

        Debug.Log("The fog has been toggled!");
    }
        
}
