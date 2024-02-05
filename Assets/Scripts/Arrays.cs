
/*****************************************************************************
// File Name : Arrays.cs
// Author : Quinn Merrims
// Creation Date : February 4, 2024
// Brief Description : This script creates and prints several 
//arrays according to IM 160's Assignment 1
*****************************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;
public class Arrays : MonoBehaviour
{
    /// <summary>
    /// Arrays are fixed containers for data. They have a fixed size
    /// The first data in the array is number 0. 
    /// ArrayOfInts and ArrayOfFloats are defined here. ArrayOfStrings is defined
    /// in AssignArrayOfStrings
    /// </summary>
    
    string[] ArrayOfStrings = new string[5];
    int[] ArrayOfInts = { 4, 5, 6, 7, 8 };
    float[] ArrayOfFloats = { 1.6f, 9.5f, 900.2f, 420.4f, 7.2f };

    /// <summary>
    /// Start executes all functions on start
    /// </summary>
    void Start()
    {
        AssignArrayOfFloats();
        AssignArrayOfInts();
        AssignArrayOfStrings();
    }

    /// <summary>
    /// AssignArrayOfStrings assigns and prints out an array of strings
    /// whose text has been reversed. 
    /// The second forloop splits each element into an array of chars 
    /// which are then reversed
    /// </summary>
    public void AssignArrayOfStrings()
    {
        ArrayOfStrings[0] = "hewwo";
        ArrayOfStrings[1] = "I forgot to";
        ArrayOfStrings[2] = "take my medication";
        ArrayOfStrings[3] = "for two days straight";
        ArrayOfStrings[4] = "so now I feel like crash bandicoot";

        string reversed = "";

        for(int i = 0; i < ArrayOfStrings.Length; i++)
        {
            char[] chars = ArrayOfStrings[i].ToCharArray();
            for (int j = chars.Length - 1; j >= 0; j--)
            {
                reversed += chars[j];
                //print("owweh, ot otgrof I, noitacidem ym ekat, thgiarts syad owt os, toocibnab hsarc ekile leef I won os");
            }
            if (i != ArrayOfStrings.Length -1)
            {
                reversed += ", ";
            }
            else
            {
                reversed += "";
            }
        }
        print(reversed);
        
    }

    /// <summary>
    /// AssignArrayOfInts adds the values of all 
    /// elements of the ArrayOfInts
    /// This function can be alternatively be
    /// completed with a shortcut: ArrayOfInts.Sum());
    /// </summary>
    public void AssignArrayOfInts()
    {
        //print(ArrayOfInts.Sum());
        int total = 0;
        for (int i = 0; i < ArrayOfInts.Length; i++)
        {
            total += ArrayOfInts[i];
        }
        print(total);
    }

    /// <summary>
    /// AssignArrayOfFloats prints all elements of ArrayOfFloats in reverse,
    /// Counting down from four until it is equal to or greater than 0
    /// </summary>
    public void AssignArrayOfFloats()
    {
        string backwards = "";
        for(int i = ArrayOfFloats.Length - 1; i >= 0;i--)
        {
            //print(7.2, 420.4, 900.2, 9.5, 1.6);
            if (i != 0) { backwards += ArrayOfFloats[i] + ", "; }
            else
            {
                backwards += ArrayOfFloats[i] + ". ";
            }
        }
        print(backwards);
    }
}
