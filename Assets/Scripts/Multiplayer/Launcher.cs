using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Launcher : MonoBehaviourPunCallbacks
{
    public static Launcher Instance = null;

    [SerializeField] GameObject _LoadingScreen;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else if (Instance != this) Destroy(gameObject);
    }

    void Start()
    {
        ConnectToPhotonNetwork();
    }

    public void ConnectToPhotonNetwork()
    {
        PhotonNetwork.ConnectUsingSettings();
        _LoadingScreen.SetActive(true);

        Debug.Log("Connecting to servers...");
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
        Debug.Log("Joining loby...");
    }

    public override void OnJoinedLobby()
    {
        MenuManager.Instance.OpenMenu("main");
        _LoadingScreen.SetActive(false);

        Debug.Log("Joined lobby.");
    }
}
