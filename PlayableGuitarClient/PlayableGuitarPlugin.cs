using BepInEx;
using BepInEx.Logging;
using PrivateRyan.PlayableGuitar.Helpers;
using PrivateRyan.PlayableGuitar.Patches;

namespace PrivateRyan.PlayableGuitar
{
    [BepInPlugin("privateryan.playableguitar", "PlayableGuitar", "1.0.0")]
    [BepInDependency("com.SPT.core", "3.9.0")]
    public class PlayableGuitarPlugin : BaseUnityPlugin
    {
        internal static ManualLogSource PBLogger;
        private void Awake()
        {
            PBLogger = Logger;
            
            Settings.Init(Config);
            
            //See if plugin works without below patch
            //new FirearmsAnimatorPatch().Enable();
            new WeaponAnimSpeedControllerPatch().Enable();
            new PlayableGuitarPatch().Enable();
        }
    }
}