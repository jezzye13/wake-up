using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleScreen : MonoBehaviour {

    [SerializeField]
    private Dialoog _dialoog;
    private Camera _camera;
    private Rect _default;
    private const float _small = 0.25f;

    // Use this for initialization
    void Start () {
        _dialoog.OnDialoogBoxShow += Scale;
        _dialoog.OnDialoogBoxExit += BackScale;
        _camera = GetComponent<Camera>();
        _default = new Rect(0f, 0f, 1f, 1f);
    }

    private void Scale()
    {
        _camera.rect = new Rect(_default.x, _small, _default.width, _default.height);
    }

    private void BackScale()
    {
        _camera.rect = _default;
    }
}
