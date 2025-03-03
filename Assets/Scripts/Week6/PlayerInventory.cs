using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public bool hasKey = false;

    public GameObject playerCamera;

    public bool hasBlueKey;
    public bool hasRedKey;
    public bool hasYellowKey;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            //are we looking atthe door?
            RaycastHit hitObject; //this variable contains the data of what will be hit by the raycast we're gonna make

            if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hitObject, 10f))
            {
                Debug.Log("looking at door");
                if (hitObject.collider.gameObject.tag == "door")
                {
                    Debug.Log("collided with door");
                    Door lookedAtDoor = hitObject.collider.gameObject.GetComponent<Door>();
                    if (lookedAtDoor.doorColor == KeyColor.Red && hasRedKey == true)
                    {
                        Debug.Log("red and red");
                        lookedAtDoor.OpenDoor();
                    }
                    else if (lookedAtDoor.doorColor == KeyColor.Blue && hasBlueKey == true)
                    {
                        Debug.Log("blue and blue");
                        lookedAtDoor.OpenDoor();
                    }
                    else if (lookedAtDoor.doorColor == KeyColor.Yellow && hasYellowKey == true)
                    {
                        Debug.Log("yellow and yellow");
                        lookedAtDoor.OpenDoor();
                    }
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "key")
        {
            KeyColor pickedUpKeyColor = other.gameObject.GetComponent<Key>().color;
           if(pickedUpKeyColor == KeyColor.Red)
            {
                hasRedKey = true;
            }
           else if(pickedUpKeyColor == KeyColor.Blue)
            {
                hasBlueKey = true;
            }
            else if(pickedUpKeyColor == KeyColor.Yellow)
            {
                hasYellowKey = true;
            }

            Destroy(other.gameObject);
        }
    }
}
