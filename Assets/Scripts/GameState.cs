using UnityEngine;

public class GameState : MonoBehaviour
{
    public static GameState instance;
    public int Score;

    public State gs = State.MAINMENU;

    public enum State
    {
        RUNNING,
        MAINMENU,
        BEGIN,
        OVER
    }

    public void GameOver()
    {

    }
    public void GameBegin()
    {

    }

    public void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

}
