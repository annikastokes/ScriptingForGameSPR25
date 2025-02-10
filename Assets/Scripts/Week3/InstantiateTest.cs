using UnityEngine;

public class InstantiateTest : MonoBehaviour
{

    public GameObject cannonBallPrefab;

    public GameObject cannonBallSpawnPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //spawns the cannonball prefab at the cannonballspawnposition's location, with the same rotation as in prefab

        GameObject go = Instantiate(cannonBallPrefab, cannonBallSpawnPosition.transform.position, cannonBallPrefab.transform.rotation);
        go.GetComponent<MeshRenderer>().material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        //if holding down E, instantiate
        if (Input.GetKey(KeyCode.E))
        {
            Instantiate(cannonBallPrefab, cannonBallSpawnPosition.transform.position, cannonBallPrefab.transform.rotation);

        }
    }
}
