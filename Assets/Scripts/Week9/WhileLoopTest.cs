using System.Collections;
using UnityEngine;

public class WhileLoopTest : MonoBehaviour
{

    public float speed = 300f;
    Coroutine co;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        while (this.transform.position.x < 7f)
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }    
        */

        co = StartCoroutine(MoveRightAndChangeColor());
    }

    // Update is called once per frame
    void Update()
    {
     /*   while(this.transform.position.y < 10)
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }
     */

        if(Input.GetKeyDown(KeyCode.Space))
        {
            StopCoroutine(co);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            StopAllCoroutines();
              
        }
    }

    IEnumerator MoveRightAndChangeColor()
    {
        /*
        Debug.Log("frame 1 runs");
        yield return null; // yield return null will pause the code until the next frame
        Debug.Log("frame 2 runs");
        yield return new WaitForSeconds(2f); //this will wait 2 seconds before continuing code
        Debug.Log("Waited 2 seconds before posting this");
        */

        while (this.transform.position.x < 531f)
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
            yield return null;
        }

        yield return new WaitForSeconds(2f);

        this.GetComponent<MeshRenderer>().material.color = Color.blue;

        yield return new WaitForSeconds(2f);

        while (this.transform.position.x > -120f)
        {
            this.transform.position += Vector3.left * speed * Time.deltaTime;
            yield return null;
        }

        yield return new WaitForSeconds(2f);

        this.GetComponent<MeshRenderer>().material.color = Color.red;


    }
}
