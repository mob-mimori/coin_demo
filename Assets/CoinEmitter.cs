using UnityEngine;
using System.Collections;

public class CoinEmitter : MonoBehaviour {

	public GameObject medal;

	public int hasCoin = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButtonDown ("Fire1") && hasCoin > 0)
        {
        	Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast (ray, out hit, 100)){
            	Vector3 v = hit.point + new Vector3(0, 1, 0);
	            GameObject obj = Instantiate (medal, v, hit.transform.rotation) as GameObject;
	            Debug.Log(hasCoin);
	            hasCoin--;
                //obj.transform.parent    =   manager.transform;

            }
        }
	}
}
