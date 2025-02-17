using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class OptionsState : State
{
    public EventSystem eventSystem;
    bool shouldExit = false;
    public GameObject menuUI;
    private PlayerInput playerInput;

    protected override void Awake()
    {
        base.Awake();
        stateMachine.RegisterState("Option", this);
        playerInput = FindObjectOfType<PlayerInput>();
    }

    public override void Enter()
    {
        base.Enter();
        Time.timeScale = 0f;
        menuUI.SetActive(true);
        eventSystem = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<EventSystem>();
        eventSystem.SetSelectedGameObject(GameObject.FindGameObjectWithTag("DefaultOption"));
        eventSystem.firstSelectedGameObject = GameObject.FindGameObjectWithTag("DefaultOption");
        playerInput.SwitchCurrentActionMap("UI");
    }
    public override void Exit()
    {
        base.Exit();
        menuUI.SetActive(false);
    }

    public override void HandleInput()
    {
        shouldExit = Input.GetButtonDown("Cancel");
    }
    public override void HandleShouldChangeState()
    {
        if (shouldExit)
        {
            stateMachine.RemoveState();
        }
    }
    public override void LogicUpdate()
    {
    }
    public override void PhysicsUpdate()
    {
    }
}