using UnityEngine;

public class Cannonball : MonoBehaviour
{

    public Cannonball cannonball;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    //when the ball collides with amother object, run this!
    //if ball has a rigidbody, and both the objects have colliders

    private void OnCollisionEnter(Collision otherObject)
    {
        //whenever the collision happens, this will say the name of that object
        Debug.Log(otherObject.gameObject.name);

        //if the collision object is tagged as a floor, do this!
        if(otherObject.gameObject.tag == "Floor")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.cyan;
            otherObject.gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
            otherObject.gameObject.GetComponent<FloorScript>().SayHello();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.tag == "up")
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 1500f);
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        }

        else if(other.gameObject.tag == "down")
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.down * 1500f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public void AddRandomForce()
    {
        Vector3 randomDirection = Vector3.zero;

        randomDirection.x = Random.Range(-1f, 1f);
        randomDirection.y = Random.Range(0f, 1f);
        randomDirection.z = Random.Range(-1f, 1f);

        float forceMultiplier = Random.Range(1000, 5000);

        this.gameObject.GetComponent<Rigidbody>().AddForce(randomDirection * forceMultiplier);
    }

}
