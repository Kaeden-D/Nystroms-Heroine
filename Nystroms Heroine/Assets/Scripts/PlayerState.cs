using UnityEngine;

namespace Chapter.State
{

    public interface PlayerState
    {
        void Handle(PlayerController controller);
    }

}