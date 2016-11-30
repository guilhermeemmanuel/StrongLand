using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public UnityEngine.UI.Text lifeText;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void setLifeText(int life) {
        lifeText.text = "Life: " + life;
    }

}
