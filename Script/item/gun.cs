using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gun : MonoBehaviour {

	public GunParam gunParam;
	public AmmoParam ammoParam;
	public GameObject pref;
	public Transform canon;
	void Update () {
		var a = Mathf.Atan2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal")) * 180.0f / Mathf.PI;
		transform.eulerAngles = new Vector3(0.0f, 0.0f, a);
		if (Input.GetButtonDown("Fire2") && gunParam.ball > 0)
		{
			print("tire");
			var obj = Instantiate(pref, canon.position, canon.rotation);
			obj.gameObject.GetComponent<ball>().ammoParam = ammoParam;
			gunParam.ball--;
		}
	}
}
