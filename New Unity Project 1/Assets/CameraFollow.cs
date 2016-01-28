using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float m_speed = 0.1f;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;
    Camera myCam;
	// Use this for initialization
	void Start () {
        myCam = GetComponent<Camera>();


	}
	
	// Update is called once per frame
	void Update () {
        myCam.orthographicSize = (Screen.height / 100f) / 4f;
        
        if (target)
        {
            transform.position = Vector3.SmoothDamp(transform.position, target.position, ref velocity, smoothTime) + new Vector3(0,0,-10);
        }
	}
}
