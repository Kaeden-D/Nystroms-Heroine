using UnityEngine;

namespace Chapter.State
{

    public class ClientState : MonoBehaviour
    {

        private PlayerController _playerController;

        void Start()
        {
            _playerController = (PlayerController)FindFirstObjectByType(typeof(PlayerController));
        }

        private void OnGUI()
        {

            if (GUILayout.Button("Stand"))
                _playerController.Stand();

            if (GUILayout.Button("Duck"))
                _playerController.Duck();

            if (GUILayout.Button("Jump"))
                _playerController.Jump();

            if (GUILayout.Button("Dive"))
                _playerController.Dive();

            if (GUILayout.Button("Double Jump"))
                _playerController.DoubleJump();

            if (GUILayout.Button("Leap"))
                _playerController.Leap();

            if (GUILayout.Button("Walk"))
                _playerController.Walk();

        }

    }

}