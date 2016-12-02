using UnityEngine;
using System.Collections;

public class AmmoController : MonoBehaviour {

    public GameObject ammo;

    public float shootPower;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void shoot() {
        
        Vector3 positionToInstantiate = new Vector3(transform.position.x + 0.5f * Mathf.Sign(GetComponent<EnemyController>().direction), transform.position.y + 0.2f, transform.position.z);
        GameObject fire = Instantiate(ammo, positionToInstantiate, transform.rotation) as GameObject;
        fire.GetComponent<Rigidbody2D>().AddForce(Vector2.right * shootPower * Mathf.Sign(GetComponent<EnemyController>().direction));
    }
}
