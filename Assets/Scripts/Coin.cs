using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

    public static int coinsCount = 0;

	// Use this for initialization
	void Start () {
        Coin.coinsCount++;
		Debug.Log("coinsCount: " + coinsCount);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider collider) {
        if (collider.CompareTag("Player"))
        {
            //Debug.Log("entrada al trigger");
            GameObject.Destroy(gameObject);
        }
    }

    void OnDestroy() {
        Coin.coinsCount--;
		Debug.Log("Moneda recogida. " + "coinsCount: " + coinsCount);
		 
		//si recojo todas las monedas
        if (Coin.coinsCount <= 0)
        {
			Debug.Log("Ganaste!");

			//destruyo el timer
			GameObject timer = GameObject.Find ("GameTimer");
			GameObject.Destroy (timer);

			//activo los fuegos artificiales
			GameObject[] fuegos = GameObject.FindGameObjectsWithTag ("Finish");
			foreach (GameObject fuego in fuegos) {
				fuego.GetComponent<ParticleSystem>().Play ();
			}
        }       
    }
}
