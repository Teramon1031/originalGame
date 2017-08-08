/*敵の武器が飛んでいくようにする
 *プレイヤーに当たったらプレイヤーのHPを減らし武器は消滅
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponScript : MonoBehaviour {

	private Rigidbody _rigidbody;
	public Animator playerAnim;

	void Awake () {
		_rigidbody = this.GetComponent<Rigidbody> ();
	}

	void Start () {
		this._rigidbody.AddForce (Vector3.up * 150);
		this._rigidbody.AddRelativeForce (Vector3.forward * 250);
	}
		
	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "player") {
			PlayerScript.playerHP--;
			playerAnim.SetBool ("Damage", true);
			Invoke ("PlayerAnimSetBoolDamage", 1.2f);
		}
		Destroy (this.gameObject);
	}

	void PlayerAnimSetBoolDamage () {
		playerAnim.SetBool ("Damage", false);
	}
}
