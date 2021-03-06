using System;
using System.Collections;
using System.Collections.Generic;
using Networking;
using UnityEngine;

public class NetworkEventHandler : MonoBehaviour
{
    [SerializeField] private NetworkEventContainer container;

    private void Start()
    {
        NetworkClient.Instance.Events.onGameStart.AddListener(container.onGameStart.Invoke);
        NetworkClient.Instance.Events.onGameEnd.AddListener(container.onGameEnd.Invoke);
        NetworkClient.Instance.Events.onStonePlace.AddListener(container.onStonePlace.Invoke);
        NetworkClient.Instance.Events.onTurnSwitch.AddListener(container.onTurnSwitch.Invoke);
        NetworkClient.Instance.Events.onOpponentLeave.AddListener(container.onOpponentLeave.Invoke);
        NetworkClient.Instance.Events.onGameFound.AddListener(container.onGameFound.Invoke);
        NetworkClient.Instance.Events.onJoinLobby.AddListener(container.onJoinLobby.Invoke);
    }

    private void OnDisable()
    {
        NetworkClient.Instance.Events.onGameStart.RemoveListener(container.onGameStart.Invoke);
        NetworkClient.Instance.Events.onGameEnd.RemoveListener(container.onGameEnd.Invoke);
        NetworkClient.Instance.Events.onStonePlace.RemoveListener(container.onStonePlace.Invoke);
        NetworkClient.Instance.Events.onTurnSwitch.RemoveListener(container.onTurnSwitch.Invoke);
        NetworkClient.Instance.Events.onOpponentLeave.RemoveListener(container.onOpponentLeave.Invoke);
        NetworkClient.Instance.Events.onGameFound.RemoveListener(container.onGameFound.Invoke);
        NetworkClient.Instance.Events.onJoinLobby.RemoveListener(container.onJoinLobby.Invoke);
    }
}