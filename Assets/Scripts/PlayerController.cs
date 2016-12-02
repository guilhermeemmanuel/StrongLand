using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;

    public int defense;

    public int life;

    public string[] actions;

    public GameController gameController;

    public GameObject shieldObject;

	// Use this for initialization
	void Start () {
        gameController.setLifeText(life);
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag.Equals("EnemyWeapon")) {
            int damageReceived = other.gameObject.GetComponent<DamageDealer>().damage;
            if(damageReceived > defense) {
                life -= damageReceived - defense;
                gameController.setLifeText(life);
                Destroy(other.gameObject);
            }
        }
    }

    public void move(float direction) {
        if (!GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsTag("Attack") &&
            !GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsTag("Shield") ) {
            if (direction == 0) {
                GetComponent<Animator>().SetBool("walk", false);
            }
            else {
                GetComponent<Animator>().SetBool("walk", true);
                GetComponent<Transform>().eulerAngles = Vector2.up * 180 * Mathf.Ceil(Mathf.Clamp01(-direction));
                GetComponent<Transform>().Translate(Vector2.right * Time.deltaTime);
            }
        }
        else {
            GetComponent<Animator>().SetBool("walk", false);
        }
    }

    public void action(int index) {
        Debug.Log("action " + index);
        Invoke(actions[index], 0f);
    }

    public void shield() {
        if (!GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsTag("Shield")) {
            GetComponent<Animator>().SetTrigger("shield");
        }
    }

    public void attack() {
        if (!GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsTag("Attack")) {
            GetComponent<Animator>().SetTrigger("attack");
        }
    }
}
