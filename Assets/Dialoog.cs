using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Dialoog : MonoBehaviour {

    [SerializeField] private ScaleScreen _scaleScreen;
    public event Action OnDialoogBoxShow;
    private void ShowBox()
    {
        if (OnDialoogBoxShow != null)
            OnDialoogBoxShow();

        if (!_box.activeInHierarchy)
        {
            _box.SetActive(true);
        }
    }

    public event Action OnDialoogBoxExit;
    private void ExitBox()
    {
        if (OnDialoogBoxExit != null)
            OnDialoogBoxExit();

        if (_box.activeInHierarchy)
        {
            _box.SetActive(false);
        }
    }
    private Text _text;
    private GameObject _box;

    // Use this for initialization
    void Start () {
        _box = transform.GetChild(0).gameObject;
        _text = _box.transform.GetChild(0).GetComponent<Text>();
    }

    public void ShowDialoogBox(string message)
    {
        ShowBox();
        _text.text = message;
    }
}
