using UnityEngine;

public class ConditionalPractice : MonoBehaviour
{

    public GameObject go;
    public GameObject go2;

    public MeshRenderer gorenderer;

    public Color go2ElseColor;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ColorGameObjectByName();
        ColorGameObjectByTag();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ColorGameObjectByName()
    {
       Debug.Log("Go is named" + go.name);
       Debug.Log("Go2 is named" + go2.name);

        //be absolutely certain, when you use GetComponent, that the thing definitely does have that component

        MeshRenderer goMeshRenderer = go.GetComponent<MeshRenderer>(); 

        if (go.name == "Sphere")
        {
            goMeshRenderer.material.color = Color.cyan;
            //change color to cyan
        }

        else if (go.name == "Cube")
        {
            //change color to black
            goMeshRenderer.material.color = Color.black;
        }

        else if (go.name == "Cylinder")
        //change color to white
        {
            goMeshRenderer.material.color = Color.white;
        }
        else
        {
            //change color to magenta
            goMeshRenderer.material.color = new Color32(200, 100, 3, 255);
        }

        //for Go2

        MeshRenderer go2MeshRenderer = go2.GetComponent<MeshRenderer>();

        if (go2.name == "Sphere")
        {
            goMeshRenderer.material.color = Color.gray;
            //change color to gray
        }

        else if (go2.name == "Cube")
        {
            //change color to green
            goMeshRenderer.material.color = Color.green;
        }

        else if (go2.name == "Cylinder")
        //change color to red
        {
            goMeshRenderer.material.color = Color.red;
        }
        else
        {
            //change color to ?
            goMeshRenderer.material.color = go2ElseColor;
        
        }

    }
    void ColorGameObjectByTag()
    {
        MeshRenderer goMeshRenderer = go.GetComponent<MeshRenderer>();

        if (go.tag == "Yay")
        {

        }
    

        if (go.tag == "Fuck")
        {
            goMeshRenderer.material.color = Color.cyan;
            //change color to cyan
        }

        else if (go.tag == "Aww")
        {
            //change color to black
            goMeshRenderer.material.color = Color.black;
        }

        else if (go.name == "Fuck")
        //change color to white
        {
            goMeshRenderer.material.color = Color.white;
        }
        else
        {
            //change color to magenta
            goMeshRenderer.material.color = new Color32(200, 100, 3, 255);
        }

        //for Go2

        MeshRenderer go2MeshRenderer = go2.GetComponent<MeshRenderer>();

        if (go2.name == "Yay")
        {
            goMeshRenderer.material.color = Color.gray;
            //change color to gray
        }

        else if (go2.name == "Fuck")
        {
            //change color to green
            goMeshRenderer.material.color = Color.green;
        }

        else if (go2.name == "Aww")
        //change color to red
        {
            goMeshRenderer.material.color = Color.red;
        }
        else
        {
            //change color to ?
            goMeshRenderer.material.color = go2ElseColor;

        }
    }
}
