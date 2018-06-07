using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public float distance = 15;
    public float rot = 0;

    private float roll = 30f * Mathf.PI * 2 / 360;
    private GameObject target;

	// Use this for initialization
	void Start ()
    {
        target = GameObject.Find("tank");
	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        if (target == null)
            return;
        if (Camera.main == null)
            return;

        Vector3 targetPos = target.transform.position;
        Vector3 cameraPos;

        float d = distance * Mathf.Cos(roll);
        float height = distance * Mathf.Sin(roll);

        cameraPos.x = targetPos.x + d * Mathf.Cos(rot * Mathf.PI * 2 / 360);
        cameraPos.z = targetPos.z + d * Mathf.Sin(rot * Mathf.PI * 2 / 360);
        cameraPos.y = targetPos.y + height;
        Camera.main.transform.position = cameraPos;
        Camera.main.transform.LookAt(target.transform);
	}
}
