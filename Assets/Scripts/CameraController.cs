using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;

    public float smoothX;

	// Use this for initialization
	void Start () {
        GetComponent<Transform>().position = new Vector3(player.transform.position.x, 
            player.transform.position.y, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
        float distance = player.transform.position.x - transform.position.x;
        if (Mathf.Abs(distance) > 2 ) {
            transform.Translate( Vector2.right * Time.deltaTime * distance * smoothX);
        }
	}
}
