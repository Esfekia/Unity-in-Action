using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
    // first set up the method that is called by the RayShooter script

    public void ReactToHit()
    {
        StartCoroutine(Die());
    }

    private IEnumerator Die()
    {
        // topple the enemy, wait 1.5 seconds, and then destroy the enemy.
        this.transform.Rotate(-75, 0, 0);

        yield return new WaitForSeconds(1.5f);

        // a script can destroy itself (just as it could a separate object)
        Destroy(this.gameObject);        
    }
}
