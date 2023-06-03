using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UiPanel : MonoBehaviour
{
    public UnityEvent onOpen = new();
    public UnityEvent onClose = new();
    public UnityEvent<bool> toggle = new();

    [SerializeField] private bool _openOnStart = true;
    private void Awake()
    {
        if (_openOnStart)
        {
            Open();
        }
        else
        {
            Close();
        }
    }

    public void Open()
    {
        gameObject.SetActive(true);
        onOpen.Invoke();
        toggle.Invoke(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
        onClose.Invoke();
        toggle.Invoke(false);
    }
}
