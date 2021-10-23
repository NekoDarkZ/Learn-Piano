using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesController : MonoBehaviour
{
    [SerializeField] GameObject[] notes;
    public void EnableNotes() 
    {
        for (int i = 0; i < notes.Length; i++) 
        {
            notes[i].SetActive(true);
        }
    }

    public void DisableNotes()
    {
        for (int i = 0; i < notes.Length; i++)
        {
            notes[i].SetActive(false);
        }
    }
}
