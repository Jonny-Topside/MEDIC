using UnityEngine;
using System.Collections;
using UnityEngine.VR;


public class VrModeOff : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown(KeyCode.V))
        {
            VRSettings.enabled = !VRSettings.enabled;
            Debug.Log("Changed VRsettings.enabled to: " + VRSettings.enabled);

        }
    }
}
