using UnityEngine;

public class TimerCountingDown : MonoBehaviour
{
    public float timerCountingDown = 3f;

    public float defaultTime;

    public GameObject gorb;

 //Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerCountingDown -= Time.deltaTime;

        if(timerCountingDown <= 0)
        {
            Debug.Log("countdown over");
            gorb.transform.position += Vector3.left;
            timerCountingDown = 3f;

        }
    }
}
