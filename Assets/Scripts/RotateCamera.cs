using UnityEngine;
using System.Collections;

public class RotateCamera : MonoBehaviour {

    public GameObject gameObject;
    private float speedMod = 0.1f;
    private Vector3 point;

	// Use this for initialization
	void Start () {
        //gameObject = GameObject.Find("ss");
        point = gameObject.transform.position;
        transform.LookAt(point);
	}
	
	// Update is called once per frame
	void Update () {
       
        
        float x = Input.acceleration.x;

        if (Mathf.Abs(x) > 0.15f)
        {
            if (x > 0)
                transform.RotateAround(point, new Vector3(0, 1.0f, 0), 20 * Time.deltaTime * (speedMod + Mathf.Abs(10 * x)));
            else
                transform.RotateAround(point, new Vector3(0, -1.0f, 0), 20 * Time.deltaTime * (speedMod + Mathf.Abs(10 * x)));
        }
        else
            transform.RotateAround(point, new Vector3(0.0f, -1.0f, 0.0f), 20 * Time.deltaTime * speedMod);

    }
}
