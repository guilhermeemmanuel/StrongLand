using UnityEngine;
using System.Collections;

public class SentinelController : MonoBehaviour {

    public int direction = -1;

    private float passedTime;

    public float flipTime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(GetComponent<EnemyController>().state == "sentinel") {
            GetComponent<Animator>().SetBool("walk", true);
            passedTime += Time.deltaTime;
            if(passedTime >= flipTime) {
                passedTime = 0;
                direction = Mathf.Abs(direction) - 1;
                Debug.Log(direction);
            }
            GetComponent<Transform>().eulerAngles = Vector2.up * 180 * direction;
            GetComponent<Transform>().Translate(Vector2.right * Time.deltaTime);
        }
	}
}
