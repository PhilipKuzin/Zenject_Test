using System;
using UnityEngine;
using Zenject;

public class PlayerInstaller : MonoInstaller
{
    [SerializeField] Transform _playerSpawnTransform;
    [SerializeField] Player _playerPrefab;
    [SerializeField] PlayerConfigs _playerConfigs;

    public override void InstallBindings()
    {
        BingConfig();
        BindPlayer();
    }

    private void BingConfig()
    {
        Container.Bind<PlayerConfigs>().FromInstance(_playerConfigs).AsSingle();
    }

    private void BindPlayer()
    {
        Player player = Container.InstantiatePrefabForComponent<Player>(_playerPrefab, _playerSpawnTransform.position, Quaternion.identity, null);
        Container.BindInterfacesAndSelfTo<Player>().FromInstance(player).AsSingle();
    }


}
