using UnityEngine;

public class ScriptRefPractice : MonoBehaviour
{
    public TUlhari Controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Controller.scaleIncrease = 5f;
        Controller.RotateTulhari();
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
