using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossBattleMuzzleScript : MonoBehaviour {

	public GameObject bbEraser;
	public Text bbEraserNoText;
	public static int bbEraserNo;


	void Start () {
		bbEraserNo = 0;
	}

	void Update () {
		if (bbEraserNo > 0) {
			if (Input.GetKeyDown (KeyCode.Alpha3)) {
				Instantiate (bbEraser, this.transform.position, this.transform.rotation);
				bbEraserNo--;
			}
		}

		if (bbEraserNo < 2) {
			bbEraserNoText.text = "黒板消し：\t" + "<color=#aa2222>" + bbEraserNo.ToString () + "</color>";
		} else {
			bbEraserNoText.text = "黒板消し：\t" + "<color=#000000>" + bbEraserNo.ToString () + "</color>";
		}
	}
}
