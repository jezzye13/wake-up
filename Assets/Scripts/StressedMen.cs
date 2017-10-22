using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StressedMen : MonoBehaviour {

    [SerializeField] private float _multiplyer;
    [SerializeField] private GameObject[] _inventory;

    private void Start()
    {
        _inventory = new GameObject[5];
    }

    // Update is called once per frame
    void FixedUpdate () {
        Vector2 direction = Vector2.zero;

		if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            direction = new Vector2(0, 1);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            direction = new Vector2(0, -1);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            direction = new Vector2(-1, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            direction = new Vector2(1, 0);
        }

        transform.Translate((direction * _multiplyer) * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if(collider2D.tag.Equals("Item"))
        {
            Debug.Log("You picked up " + collider2D.name);
        }
        else if (collider2D.tag.Equals("NPC"))
        {
            //show text dialog
        }
    }
}
