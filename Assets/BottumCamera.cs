using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottumCamera : MonoBehaviour {

    [SerializeField]
    private Dialoog _dialoog;

    // Use this for initialization
    void Start()
    {
        _dialoog.OnDialoogBoxShow += Enable;
        _dialoog.OnDialoogBoxExit += Diseble;
    }

    private void Enable()
    {
        gameObject.SetActive(true);
    }

    private void Diseble()
    {
        gameObject.SetActive(false);
    }
}
