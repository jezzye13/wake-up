using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialoog : MonoBehaviour {

    [SerializeField] private bool _isShowing;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        if(gameObject.activeInHierarchy && !_isShowing)
        {
            gameObject.SetActive(false);
        }
        else if (!gameObject.activeInHierarchy && _isShowing)
        {
            gameObject.SetActive(true);
        }
    }
}
