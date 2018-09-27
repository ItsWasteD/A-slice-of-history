using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameVolumeChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeGameSound(float value)
    {
        AudioListener.volume = value;
    }
}
