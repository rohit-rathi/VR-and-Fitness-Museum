using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComponents : MonoBehaviour {

	public static void MakeItemAppear(GameObject item) {
		item.SetActive (true);
	}

	public static void MakeItemDisappear(GameObject item) {
		item.SetActive (false);
	}
}
