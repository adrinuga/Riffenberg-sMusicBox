﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleCompleted : InteractableObject {


    [SerializeField] private Outline m_objectOutline;
    [SerializeField] private AudioSource m_PuzzleSolvedAudioSource;
    [SerializeField] private GameManager.PuzzleType m_PuzzleType;


    // Use this for initialization
    void Start()
    {
        switch (m_PuzzleType)
        {
            case GameManager.PuzzleType.puzzleM:
                if(GameManager.m_instance.m_puzzleCompletedM)
                {
                    GameManager.m_instance.m_interactableObjects.Add(this);
                }
                break;
            case GameManager.PuzzleType.puzzleH:
                if (GameManager.m_instance.m_puzzleCompletedH)
                {
                    GameManager.m_instance.m_interactableObjects.Add(this);
                }
                break;
            case GameManager.PuzzleType.puzzleR:
                if (GameManager.m_instance.m_puzzleCompletedR)
                {
                    GameManager.m_instance.m_interactableObjects.Add(this);
                }
                break;

        }
    }



    // Update is called once per frame
    void Update()
    {
        m_objectOutline.enabled = false;
    }
    public override void OnClick()
    {
        if (!GameManager.m_instance.m_playerNav.m_BoxOn) //BUGGED??
        {
            if(!m_PuzzleSolvedAudioSource.isPlaying)
            {
                m_PuzzleSolvedAudioSource.Play();
            }

        }
        //TO CHANGE
        if (!m_PuzzleSolvedAudioSource.isPlaying)
        {
            m_PuzzleSolvedAudioSource.Play();
        }
    }
    public override void MouseOver()
    {
        if (!GameManager.m_instance.m_playerNav.m_BoxOn)
        {
            m_objectOutline.enabled = true;
        }

    }
    public override Transform ReturnObject()
    {
        return this.transform;
    }
}