using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputComponent : MonoBehaviour
{
    private MovementComponent _MovementComponent;
    // Start is called before the first frame update
    void Start()
    {
        _MovementComponent = GetComponent<MovementComponent>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = new Vector2(Input.GetAxis("Horizontal"), 0);
        if (move != null)
        {
            _MovementComponent.Walk(move);
        }
    }
}
