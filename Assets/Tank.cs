using UnityEngine;
using System.Collections;

public class Tank : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        float speed = 1;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            transform.position += transform.forward * speed;
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
            transform.position += transform.forward * speed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles = new Vector3(0, 270, 0);
            transform.position += transform.forward * speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.eulerAngles = new Vector3(0, 90, 0);
            transform.position += transform.forward * speed;
        }

    }
}
