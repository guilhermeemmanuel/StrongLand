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

        
            if(Input.GetButtonDown("Action1") ) {
                player.GetComponent<PlayerController>().action(0);
            }
            if (Input.GetButtonDown("Action2")) {
                player.GetComponent<PlayerController>().action(1);
            }
            if (Input.GetButtonDown("Action3")) {
                player.GetComponent<PlayerController>().action(2);
            }
            if (Input.GetButtonDown("Action4")) {
                player.GetComponent<PlayerController>().action(3);
            }
        
	}
}
