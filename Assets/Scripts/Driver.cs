using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour {
    public void Awake() {
		Debug.Log("Driver::Awake");
    }

    protected bool HandleInput() {
        Debug.Log("Driver::HandleInput");
		return false;
    }

    public void Update() {
		Debug.Log("Driver::Update");
    }
}
