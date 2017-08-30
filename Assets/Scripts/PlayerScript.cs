using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

	public static int playerHP;
	public GameObject goText;
	public GameObject goButA;
	public GameObject goButB;
	public GameObject gcText;
	public GameObject gcButA;
	public GameObject gcButB;
	public GameObject textE;
	private float _interval;
	private float _jump;
	public static bool playerLife = true;
	private bool _clear;
	private Animator _animator;
	private Slider _slider;

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

	void Start () {
		playerHP = 10;
	}
		
	void Update () {
		Ray ();
		_interval += 1 * Time.deltaTime;
		if (playerHP <= 0 && playerLife) {
			GameOver ();
		}
		if (_interval >= 10) {
			if (playerHP < 5 && playerLife) {
				playerHP++;
			}
			_interval = 0;
		}
		if (playerHP <= 0) {
			playerHP = 0;
		}
		_slider.value = playerHP;
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "clearBlock" && !BossScript.bossLife) {
			gcText.SetActive (true);
			gcButA.SetActive (true);
			gcButB.SetActive (true);
			ClearHanteiScript.SavedCleared (1);
		}
		if (col.gameObject.tag == "gameOverBlock") {
			GameOver ();
			Debug.Log ("死んだ");
		}
		if (col.gameObject.tag == "gameclear") {
			gcText.SetActive (true);
			gcButA.SetActive (true);
			gcButB.SetActive (true);
		}
//		ClearHanteiScript.SetBool (DataKey, true);
	}

	void GameOver () {
		goText.SetActive (true);
		goButA.SetActive (true);
		goButB.SetActive (true);

		_animator.SetBool ("Death", true);
		float time = 0.0f;
		time += Time.deltaTime;

		playerLife = false;
		playerHP = 5;
	}

	void Ray (){
		Ray ray = new Ray(transform.position, transform.forward);
		RaycastHit hit;
//		Debug.Log (ray);
		if (Physics.Raycast (ray, out hit, 2f)) {
			if (hit.collider.gameObject.tag == "chalk") {
				textE.SetActive (true);
				if (Input.GetKeyDown (KeyCode.E)) {
					Destroy (hit.collider.gameObject);
					muzzleScript.chalkNo++;
				}
			} else if (hit.collider.gameObject.tag == "eraser") {
				textE.SetActive (true);
				if (Input.GetKeyDown (KeyCode.E)) {
					Destroy (hit.collider.gameObject);
					BossBattleMuzzleScript.bbEraserNo++;
				}
			}
		} else {
			textE.SetActive (false);
			
		}
	}
}