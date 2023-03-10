using UnityEngine;
using Zenject;

public class CommonInstaller : MonoInstaller
{
   public override void InstallBindings()
   {
      BindInputSystems();
   }

   private void BindInputSystems()
   {
      Container.BindInterfacesAndSelfTo<InputService>().AsSingle().NonLazy();
   }
}