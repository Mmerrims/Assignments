/*****************************************************************************
// File Name : Spawner.cs
// Author : Quinn Merrims
// Creation Date : February 4, 2024
// Brief Description : This script spawns boxes by pressing spacebar
//and destroys them by pressing escape
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{
    /// <summary>
    /// Creates a list of boxes
    /// </summary>
    [SerializeField] GameObject Box;
    List<GameObject> BoxesInScene = new List<GameObject>();
    private Boxes InputMap;
    /// <summary>
    /// Awake enables the New InputSystem InputMap
    /// </summary>
    
    void Awake()
    {
        InputMap = new Boxes();
        InputMap.Enable();
        InputMap.BoxMap.SpawnBox.performed += SpawnBox_performed;
        InputMap.BoxMap.DestroyGameObjects.performed += DestroyGameObjects_performed;
    }

    /// <summary>
    /// This destroyes all boxes that have been spawned and empties
    /// out their list when escape is pressed
    /// </summary>
    private void DestroyGameObjects_performed(InputAction.CallbackContext obj)
    {
        for(int i = 0; i < BoxesInScene.Count; i++)
        {
            Destroy(BoxesInScene[i]);
        }
        BoxesInScene.Clear();
    }

    /// <summary>
    /// This spawns boxes when spacebar is pressed
    /// </summary>
    private void SpawnBox_performed(InputAction.CallbackContext obj)
    {
        GameObject SpawnedBox;
        SpawnedBox = Instantiate(Box);
        BoxesInScene.Add(SpawnedBox);
    }

    /// <summary>
    /// This deactivate the InputMap when the scene is unloaded
    /// </summary>
    private void OnDestroy()
    {
        InputMap.BoxMap.SpawnBox.performed -= SpawnBox_performed;
        InputMap.BoxMap.DestroyGameObjects.performed -= DestroyGameObjects_performed;
        InputMap.Disable();
    }
}
