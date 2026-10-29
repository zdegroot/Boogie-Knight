using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Animator Animator;
    public Rigidbody2D Rigidbody2D;
    private Vector2 moveDirection;
    
    public void OnMove(InputValue value)
    {
        moveDirection = value.Get<Vector2>();
        print(moveDirection.x +  "," + moveDirection.y);
    }

    public void FixedUpdate()
    {
        //FaceCorrectDirection();
        Animate();
        Move();
    }

    private void Animate()
    {
        Animator.SetFloat("horizontal", Mathf.Abs(moveDirection.x));
        Animator.SetFloat("vertical", Mathf.Abs(moveDirection.y));
    }

    private void Move()
    {
        Rigidbody2D.linearVelocity = moveDirection * GameParameters.PlayerSpeed;
    }

    private void FaceCorrectDirection()
    {
        
    }
}
