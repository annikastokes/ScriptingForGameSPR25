using System.Runtime.CompilerServices;
using UnityEngine;

public class LightChanger : MonoBehaviour
{
    public Light LightToChange;

    public Vector3 LightMoveDirection;

    public bool YesOrNo = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChangeLightColor(Color.green);
        //ChangeLightColor(Color.blue); whatever we pass into this function is what the function going to change the color to

        this.gameObject.SetActive(YesOrNo);
        //LightToChange.gameObject.SetActive(false);

        //Destroy(LightToChange.gameObject); this is how you destroy an object!!

    }

    // Update is called once per frame
    void Update()
    {
        //AdjustLight(); //the code in this function will be called at the start of each update, before moving on to the rest of the code in update()
        Debug.Log("Light object has been adjusted");

        if(Input.GetKeyDown(KeyCode.B))
        {
            ChangeLightColor(Color.blue);
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            ChangeLightColor(Color.green);
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            ChangeLightColor(Color.red);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            LightToChange.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            LightToChange.gameObject.SetActive(true);
        } 
            
    }

    private void AdjustLight()
    {
        LightToChange.transform.position += LightMoveDirection * Time.deltaTime;
        LightToChange.intensity += 100f * Time.deltaTime;
        LightToChange.innerSpotAngle += 10f * Time.deltaTime;

    }

    public void ChangeLightColor(Color cerulean)
    {

        LightToChange.color = cerulean;
    }
    private void OnEnable()
    {
        //when this object is set active again from inactive, it'll call the code in this function



    }

    private void OnDisable()
    {

    }
    //when turned off, run the code in here before it's disabled

    private void Awake()
    {
        //can be used to make things happen before start

    }

    //private void OnDestroy()
}