using UnityEngine;

public class WeedSpray : Collectable
{

    public override void ColletingCallback()
    {
        GameState.instance.GameOver();
        Destroy(gameObject);
    }
}