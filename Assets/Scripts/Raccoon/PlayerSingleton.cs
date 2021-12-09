using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSingleton : MonoBehaviour
{
    public static PlayerSingleton player;

    public void Awake()
    {
        if (!player)
        {
            DontDestroyOnLoad(gameObject);
            player = this;
        }
        else
        {
            if (player != this)
            {
            Destroy(gameObject);

            }
        }
    }
}
