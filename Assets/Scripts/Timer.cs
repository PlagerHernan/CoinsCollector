using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public float maxTime = 20.0f;
	private float _countdown;

	// Use this for initialization
	void Start () {
		_countdown = maxTime;
	}
	
	// Update is called once per frame
	void Update () {
		_countdown -= Time.deltaTime;

		if (_countdown <= 0) {
			Coin.coinsCount = 0;
			Debug.Log("Tiempo finalizado. Perdiste!");
			Application.LoadLevel (Application.loadedLevel);

		}
	}
}
