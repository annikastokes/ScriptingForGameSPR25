using UnityEngine;

public class TimerTest : MonoBehaviour
{
    public float timerCountingUp = 0f;

    public bool hasFinishedTimer = false;

    public float timerMaxDuration = 3f;

    public GameObject cyobe;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //invokes movecyoberight AFTER 3 SECONDS as defined by timermaxduration
    void Start()
    {
        //when using random.range, if you put F after the numbers in the function, it will return
        //a decimal number between those two numbers. otherwise, if no F, it'll return a whole number from the first number from the last
        //NOT including the last number. example: random.range(1, 4); will only return values 1, 2, or 3, but not 4.
        timerMaxDuration = Random.Range(1, 5);
        
        
        Invoke("MoveCyobeRight", timerMaxDuration);
     
    }

    //im this update, the timer counts up to 3seconds, but once it finally reaches its max duration, it'll move the cube to the right without time.delta.time
    //because we want it to move in one motion, not over time. also, we reset the timer counting up to 0; so that it can count back up to 3 and do it again.

    //moves cube to the right every 3 seconds
    /*void Update()
    {
       timerCountingUp += Time.deltaTime;

        if(timerCountingUp >= timerMaxDuration)
        {
            Debug.Log("reached the end of the timer!");
            cyobe.transform.position += Vector3.right;
            timerCountingUp = 0f;
        }
       
    }
    */

    void MoveCyobeRight()
    {
        cyobe.transform.position += Vector3.right;

        //invoke can only happen while the x coordinate is under 10
        if(cyobe.transform.position.x < 20)
        {
            Invoke("MoveCyobeRight", timerMaxDuration);

        }
    }
}
