using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Board board;
    public GameObject targetObject;
    public GameObject clickedObject;
    public RayCaster rayCaster;
    void Start()
    {
        board.Setup();
        rayCaster = gameObject.AddComponent<RayCaster>();
    }

    void Update()
    {
        targetObject = rayCaster.MouseRaycast();
        if (Input.GetMouseButtonUp(0))
        {
            clickedObject = targetObject;
        }
    }
}
