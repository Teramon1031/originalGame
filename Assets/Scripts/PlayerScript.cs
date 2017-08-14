using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

	public Camera camera;
	public static int playerHP = 5;
	private float _interval;
	private float _jump;
	private bool _playerLife = true;
	private bool _clear;
	private Animator _animator;
	private Slider _slider;

	void Awake () {
		_animator = GetComponent<Animator> ();
		_slider = GameObject.Find("Slider").GetComponent<Slider>();
	}

	void Start () {
		Screen.lockCursor = true;
	}

	void Update () {
		_interval += 1 * Time.deltaTime;
		if (playerHP <= 0 && _playerLife) {
			_playerLife = false;
			_animator.SetBool ("Death", true);
			Invoke ("LoadSceneGameOver", 2.0f);
			playerHP = 5;
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
			SceneManager.LoadScene ("Title");
	}

	void LoadSceneGameOver () {
		SceneManager.LoadScene ("GameOver");
	}
}