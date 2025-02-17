using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ListTest : MonoBehaviour
{

    public Cannonball cannonball;

    public GameObject cannonballPrefab;

    public List<Cannonball> cannonballs = new List<Cannonball>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //finds all objects in the scene with the Cannonball script on it, and turns it into a list
        //to be used by the cannonballs variable, which is a list of Cannonball scripts
        cannonballs = FindObjectsByType<Cannonball>(FindObjectsSortMode.None).ToList();

        //finds all gameobjects in th scene with the specified tag; returns it as an array of gameobject that you can convert to a List
        //GameObject.FindGameObjectsWithTag("Cannonball").ToList();

        GameObject go = Instantiate(cannonballPrefab);
        //you can add an object directly to a list by calling the list variable's name,Add();
        //it must be the same type as the list. if youhave a list of GameObjects, make sure you give it a GameObject.
        //in this case, we have a Cannonball script that we want to add to the list of Cannonball scripts.

        go.GetComponent<Cannonball>();
        cannonballs.Add(go.GetComponent<Cannonball>());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            //a foreach loop will o through each object in a loop, and allow you to do the same action for every instance in that list.
            foreach(Cannonball ball in cannonballs)
            {
                ball.AddRandomForce();
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            int randomBall = Random.Range(0, cannonballs.Count);

            cannonballs[randomBall].AddRandomForce();
        }
    }

}
