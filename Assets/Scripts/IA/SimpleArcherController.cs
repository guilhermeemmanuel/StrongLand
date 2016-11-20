using UnityEngine;
using System.Collections;

public class SimpleArcherController : MonoBehaviour {

    private float passedTime;

    public float attackTime;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<EnemyController>().state == "battle") {
            passedTime += Time.deltaTime;
            if(passedTime > attackTime) {
                passedTime = 0;
                GetComponent<Animator>().SetTrigger("attack");
            }
        }

    }
}
