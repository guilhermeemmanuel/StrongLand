using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;

    public int defense;

    public int life;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void move(float direction) {
        if (direction == 0) {
            GetComponent<Animator>().SetBool("walk", false);
        }
        else {
            GetComponent<Animator>().SetBool("walk", true);
            GetComponent<Transform>().eulerAngles = Vector2.up * 180 * Mathf.Ceil(Mathf.Clamp01(-direction));
            GetComponent<Transform>().Translate(Vector2.right * Time.deltaTime);
        }
    }
}
