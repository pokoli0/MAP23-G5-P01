using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementComponent : MonoBehaviour
{
    [SerializeField]
    private GameObject _myPlayer;
    [SerializeField]
    private CharacterController _characterController;
    [SerializeField]
    private float _speed;

    public void Walk(Vector2 move)     //Método para andar, se pasa como parámetro hacia donde moverse
    {            
        _characterController.Move(move * Time.deltaTime * _speed);
    }

}
