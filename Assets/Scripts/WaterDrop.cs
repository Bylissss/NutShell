using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class WaterDrop : Collectable
{
    public override void ColletingCallback()
    {
        GameState.instance.Score += 50;
        Destroy(gameObject);
    }
}
