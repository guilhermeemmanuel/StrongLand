using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        float direction = Input.GetAxis("Horizontal");

        player.GetComponent<PlayerController>().move(direction);
	}
}
