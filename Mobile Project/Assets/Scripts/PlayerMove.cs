using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update

    Vector2 move;
    public float speed;
    private Animator animator1;

    private void Start()
    {
        animator1 = GetComponent<Animator>();
    }

    public void InputPlayer(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();

    }

    // Update is called once per frame
    private void Update()
    {
        
        Vector3 movement = new Vector3(0, 0, -move.x);
        movement.Normalize();

        animator1.SetBool("IsRunningF", move != Vector2.zero);
        
        transform.Translate(speed * movement * Time.deltaTime);
    }

    public void AttackButton()
    {
        StartCoroutine(AttackRoutine());
    }

    private IEnumerator AttackRoutine()
    {
        animator1.SetBool("IsAttacking", true);

        Handheld.Vibrate();

        yield return new WaitForSeconds(0.53f);

        animator1.SetBool("IsAttacking", false);
    }
}
