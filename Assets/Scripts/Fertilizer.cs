using UnityEngine;

public class Fertilizer : Collectable
{
    public override void ColletingCallback()
    {
        GameState.instance.Score += 100;
        Destroy(gameObject);
    }
}
