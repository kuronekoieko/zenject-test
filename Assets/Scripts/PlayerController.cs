using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerController : MonoBehaviour
{
    [Inject] GameManager gameManager;

    void Start()
    {
        gameManager.ShowLog();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
