using UnityEngine;

namespace Chapter.State
{

    public class PlayerStateContext
    {

        public PlayerState CurrentState
        {
            get; set;
        }

        private readonly PlayerController _playerController;

        public PlayerStateContext(PlayerController playerController)
        {
            _playerController = playerController;
        }

        public void Transition()
        {
            CurrentState.Handle(_playerController);
        }

        public void Transition(PlayerState state)
        {
            CurrentState = state;
            this.Transition();
        }

    }

}