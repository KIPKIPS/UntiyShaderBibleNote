using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class USBReplacementController : MonoBehaviour {
    // replacement shader
    public Shader red;
    public Shader green;
    private Camera camera;
    private bool isRed = true;
    private void OnEnable() {
        camera = GetComponent<Camera>();
        isRed = true;
    }
    private void Update() {
        if (Input.anyKeyDown) {
            isRed = !isRed;
            camera.SetReplacementShader(isRed ? red : green, "RenderType");
        }
    }

    void OnDisable() {
        GetComponent<Camera>().ResetReplacementShader();
    }
}
