using Zenject;

public class FirstSceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<MovementHandler>().AsSingle();
    }
}
