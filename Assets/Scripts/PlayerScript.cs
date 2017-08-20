using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

	public static int playerHP = 5;
	public GameObject goText;
	public GameObject goButA;
	public GameObject goButB;
	public GameObject gcText;
	public GameObject gcButA;
	public GameObject gcButB;
	private float _interval;
	private float _jump;
	private bool _playerLife = true;
	private bool _clear;
	private Animator _animator;
	private Slider _slider;
	const string DataKey = "saveDataKey";

	void Awake () {
		_animator = GetComponent<Animator> ();
		_slider = GameObject.Find("Slider").GetComponent<Slider>();
		goText.SetActive (false);
		goButA.SetActive (false);
		goButB.SetActive (false);
		gcText.SetActive (false);
		gcButA.SetActive (false);
		gcButB.SetActive (false);
	}
		
	void Update () {
		_interval += 1 * Time.deltaTime;
		if (playerHP <= 0 && _playerLife) {
			GameOver ();
		}
		if (_interval >= 10) {
			if (playerHP < 5) {
				playerHP++;
			}
			_interval = 0;
		}
		if (playerHP <= 0) {
			playerHP = 0;
		}
		_slider.value = playerHP;
	}
	void OnTriggerEnter(Collider col){
		gcText.SetActive (true);
		gcButA.SetActive (true);
		gcButB.SetActive (true);
//		ClearHanteiScript.SetBool (DataKey, true);
	}

	void GameOver () {
		goText.SetActive (true);
		goButA.SetActive (true);
		goButB.SetActive (true);

		_animator.SetBool ("Death", true);
		float time = 0.0f;
		time += Time.deltaTime;

		_playerLife = false;
		playerHP = 5;
	}
}