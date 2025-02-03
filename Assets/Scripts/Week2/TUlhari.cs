using UnityEngine;

public class TUlhari : MonoBehaviour
{
    public GameObject Tulhari;
    public float scaleIncrease = .5f;
    public GameObject death;

    public Vector3 rotationAmount;

    public Transform teleportTransform;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Tulhari.transform.localScale += Vector3.one * scaleIncrease * Time.deltaTime;

        if(Tulhari.transform.localScale.x > 100)
        {
            death.SetActive(true);

        }
    }

    public void ResetSize()
    {
        Tulhari.transform.localScale = Vector3.one;
        scaleIncrease += .5f;
        //147
    }

    public void RotateTulhari()
    {
        //the following will rotate image by -90 degrees in Z direction, by creating a new vector3 variable to be used once
        Tulhari.transform.Rotate(new Vector3(0f, 0f, -90f));

        //OR you can create a vector3 variable to pass into the rotate function, like this:
        //that way you can change the functionality in the inspector without having to change any code!
        Tulhari.transform.Rotate(rotationAmount);
    } 
    public void TeleportTulhari()
    {
        Tulhari.transform.position = teleportTransform.position;
    }

        //Tulhari.transform.position = 
}
