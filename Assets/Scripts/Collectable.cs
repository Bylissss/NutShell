using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public virtual void ColletingCallback() { Destroy(gameObject); }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ColletingCallback();
    }
}
