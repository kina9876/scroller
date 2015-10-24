using UnityEngine;
using System.Collections;

public class TouchScript : MonoBehaviour {
	public string UPPER_TAG = "upper";
	public string UNDER_TAG = "under";
	public float mMoveValue;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			Ray ray  = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit = new RaycastHit ();
			if (Physics.Raycast(ray,out hit)) {
				GameObject obj = hit.collider.gameObject;
				GameObject parent = obj.transform.parent.gameObject;
				Vector3 pos = parent.transform.position;
				if (obj.transform.tag == UPPER_TAG) {
					parent.transform.position = new Vector3 (pos.x, pos.y + mMoveValue * Time.deltaTime, pos.z);
				}else if (obj.transform.tag == UNDER_TAG) {
					parent.transform.position = new Vector3 (pos.x, pos.y - mMoveValue * Time.deltaTime, pos.z);
				}
			}
		}
	}
}
