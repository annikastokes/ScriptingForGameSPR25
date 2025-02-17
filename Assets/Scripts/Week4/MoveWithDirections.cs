using UnityEngine;

public class MoveWithDirections : MonoBehaviour
{

    public GameObject Point1;

    public GameObject Point2;

    public float speed = 8f;

    public bool hasReachedDestination = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    /*void Update()
     {
         //this getsthe direction every frame - updating when point 1 moves
         //this causes the point 1 object to steadily creep towards point 2, slowing down as it approaches
         //because the direction is slowly getting smaller

     //this version normalizes the direction of the movement vector, so it travels
    //steadily toward pt2, multiplied by a speed variable so t can speed up.
    //Unfortunately, it jitters as it reaches the end because it always moves past the exact location of point2, so it goes back
    //and forth until it tries to reach the exact point.

         Vector3 direction;

         direction = Point2.transform.position - Point1.transform.position;

         Debug.Log(direction);

         Point1.transform.position += direction * Time.deltaTime;
     }
    */

    //in this version of update, we check the distance between point 1 and 2. if it's close enough (within .1 unit) it'll teleport point1 to point2
    //which is visually not noticeable. it will also stop trying to move point1 towards points 2, because it's already on top of it
    //however, it's still teleporting every single frame, but we don't want it to do this anymore after it reaches its target. check out the next update owo

    //this is all taxing to run, we don't want to run all this

    private void Update()
    {
        //this version of update will only run if point1 hasn't reached its destination
        //now, it'll stop running all code in update once it has reached its destination
        //because we have this hasReachedDestination bool variable that checks if it hasn't
        //but once it does reach it, we set that bool to true, preventing it from running
        //any code in update anymore!
        if(hasReachedDestination == false)
      {
            Vector3 direction;

            direction = Point2.transform.position - Point1.transform.position;

            direction = direction.normalized;

            Debug.Log(Vector3.Distance(Point1.transform.position, Point2.transform.position));

            if (Vector3.Distance(Point1.transform.position, Point2.transform.position) < .1f)
            {
                Point1.transform.position = Point2.transform.position;
                hasReachedDestination = true;
            }
            else
            {
                Point1.transform.position += direction * speed * Time.deltaTime;
            }
        }
    }
}
