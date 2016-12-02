using UnityEngine;
using System.Collections;

public class SentinelController : MonoBehaviour {

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
                GetComponent<EnemyController>().direction = Mathf.Abs(GetComponent<EnemyController>().direction) - 1;
            }
            GetComponent<Transform>().eulerAngles = Vector2.up * 180 * GetComponent<EnemyController>().direction;
            GetComponent<Transform>().Translate(Vector2.right * Time.deltaTime);
        }
	}
}
