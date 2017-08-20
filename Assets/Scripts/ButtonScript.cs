//Stage1ボタンを点滅させ、Stage1をクリアするまでBossBattleができないようにする
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

	[SerializeField] Graphic m_Graphics;
	[SerializeField] float m_AngularFrequency = 1.0f;
	[SerializeField] float m_DeltaTime = 0.0333f;
	Coroutine m_Coroutine;

	void Reset() {	
		m_Graphics = GetComponent<Graphic>();
	}

	void Awake() {
		StartFlash();
	}
		
	IEnumerator Flash() {
		float m_Time = 0.0f;

		while (true)
		{
			m_Time += m_AngularFrequency * m_DeltaTime;
			var color = m_Graphics.color;
			color.a = Mathf.Abs(Mathf.Sin (m_Time));
			m_Graphics.color = color;
			yield return new WaitForSeconds(m_DeltaTime);
		}
	}

	public void StartFlash() {
		m_Coroutine = StartCoroutine(Flash());
	}

	public void StopFlash()	{
		StopCoroutine(m_Coroutine);
	}

	void Update () {
//		//現在のAlpha値を取得
//		float toColor = stage1.GetComponent<Image> ().color.a;
//		//Alphaが 0 または 1 になったら増減値を反転
//		if (toColor < 0.5f || toColor > 1)
//		{
//			_alphaNo = _alphaNo * -1;
//		}
//		//Alpha値を増減させてリセット
//		stage1.GetComponent<Image> ().color = new Color (255, 255, 255, toColor + _alphaNo);
	}
}
