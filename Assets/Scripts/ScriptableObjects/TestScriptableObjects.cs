/*****************************************************************************
// File Name : TestScriptableObjects.cs
// Author : Quinn Merrims
// Creation Date : February 5, 2024
// Brief Description : This script is the class example for scriptable objects
//Scriptable Objects are used for storing data between plays or between scenes
//shorter load times. The values arent reset after runtime
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this creates the right click menu for scriptable objects without transforms
[CreateAssetMenu(fileName = "TestScriptableObjects", menuName = "Enemy Data")]
public class TestScriptableObjects : ScriptableObject
{
    [SerializeField] private string EnemyName;
    [SerializeField] private string EnemyDescription;
    [SerializeField] private int EnemyHealth;
    [SerializeField] private int EnemyDamage;
    [SerializeField] private float EnemySpeed;

    public string EnemyName1 { get => EnemyName; set => EnemyName = value; }
    public string EnemyDescription1 { get => EnemyDescription; set => EnemyDescription = value; }
    public int EnemyHealth1 { get => EnemyHealth; set => EnemyHealth = value; }
    public int EnemyDamage1 { get => EnemyDamage; set => EnemyDamage = value; }
    public float EnemySpeed1 { get => EnemySpeed; set => EnemySpeed = value; }

    public void Attacked(int damage)
    {
        EnemyHealth1 -= damage;

        Debug.Log(EnemyName + " has been hit! Health = " + EnemyHealth);
    }
}
