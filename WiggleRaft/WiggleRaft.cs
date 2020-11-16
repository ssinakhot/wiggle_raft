using UnityEngine;

public class WiggleRaft : Mod
{
    public void Start()
    {
        Debug.Log("Mod WiggleRaft has been loaded!");
    }

    public void OnModUnload()
    {
        Debug.Log("Mod WiggleRaft has been unloaded!");
    }
}