using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class AIMove : MonoBehaviour
{

    public float AttackWait;

    private Animator animator2;
    private bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        animator2 = GetComponent<Animator>();
        StartCoroutine(AIRoutine());
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private IEnumerator AIRoutine()
    {
        while (true)
        {
            float Rand = UnityEngine.Random.Range(1, 10);
            if (Rand < 6)
            {
                animator2.SetBool("IsAttacking", true);

                yield return new WaitForSeconds(0.53f);

                animator2.SetBool("IsAttacking", false);
            }

            yield return new WaitForSeconds(AttackWait);
        }
    }
}
