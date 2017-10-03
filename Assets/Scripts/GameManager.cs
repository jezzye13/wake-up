using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [SerializeField]
    private Dialoog _dialoog;
    [SerializeField]
    private bool b;

    void Start()
    {
        
    }

    public void Update()
    {
        if(b)
            _dialoog.ShowDialoogBox("Hello and welkomasd jkasgd fhbasd hbfhasd");
    }
}
