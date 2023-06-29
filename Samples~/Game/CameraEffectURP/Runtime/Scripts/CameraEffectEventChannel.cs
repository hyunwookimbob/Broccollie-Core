using System;
using UnityEngine;

namespace Broccollie.Game.CameraEffect
{
    [CreateAssetMenu(fileName = "EventChannel_CameraEffect", menuName = "Broccollie/Event Channels/Camera Effect")]
    public class CameraEffectEventChannel : ScriptableObject
    {
        #region Events
        public event Action<CameraEffectPreset> OnPlayCameraEffectRequest = null;

        #endregion

        #region Publishers
        public void RaisePlayCameraEffectEvent(CameraEffectPreset effect)
        {
            if (effect == null) return;

            OnPlayCameraEffectRequest?.Invoke(effect);
        }

        #endregion
    }
}