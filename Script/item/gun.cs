using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class gun : NetworkBehaviour {
	public Transform pistolet;
	public GunParam gunParam;
	public AmmoParam ammoParam;
	public GameObject pref;
	public Transform canon;
	void Update () {
		if (!isLocalPlayer)
			return;
		var a = Mathf.Atan2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal")) * 180.0f / Mathf.PI;
		pistolet.transform.eulerAngles = new Vector3(0.0f, 0.0f, a);
		if (Input.GetButtonDown("Fire2") && gunParam.ball > 0)
		{
			print("tire");
			var obj = Instantiate(pref, canon.position, canon.rotation);
			obj.gameObject.GetComponent<ball>().ammoParam = ammoParam;
			gunParam.ball--;
		}
	}
}
