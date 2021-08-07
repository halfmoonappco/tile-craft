using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_move1 : MonoBehaviour
{

    Vector3 moveVector = Vector3.zero;
    CharacterController characterController;

    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal") * moveSpeed;
        moveVector.z = Input.GetAxis("Vertical") * moveSpeed;

        characterController.SimpleMove(moveVector * Time.deltaTime);
        characterController.Move(moveVector * Time.deltaTime);
    }
}
