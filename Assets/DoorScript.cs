using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

	public GameObject DoorOpenText;
	public GameObject DoorCloseText;
	public GameObject Player;
	public GameObject Door;
	private bool DoorOpenFlg = false;

	void Start () {
		DoorOpenText.SetActive (false);
		DoorCloseText.SetActive (true);
	}

	void Update () {
		Vector3 playerPos = Player.transform.position;
		Vector3 doorPos = this.transform.position;
		float dis = Vector3.Distance (playerPos, doorPos);
		Door.transform.position = (new Vector3 (0.1f, -0.1f, Mathf.Clamp (Door.transform.position.z, 2.05f, 3.65f)));

		if (dis < 3) {
			PlayerApproach ();
		} else {
			DoorOpenText.SetActive (false);
			DoorCloseText.SetActive (false);
		}
		if (DoorOpenText) {
			if (Input.GetKeyDown (KeyCode.LeftShift)) {
				Door.transform.position += new Vector3 (0, 0, -1) * Time.deltaTime;
			}
		}
		if (DoorCloseText) {
			if (Input.GetKey (KeyCode.RightShift)) {
				Door.transform.position += new Vector3 (0, 0, 1) * Time.deltaTime;
			}
		}
	}

	void PlayerApproach () {
		if (DoorOpenFlg == false) {
			DoorOpenText.SetActive (true);
		} else {
			DoorCloseText.SetActive (true);
		}
	}
}
