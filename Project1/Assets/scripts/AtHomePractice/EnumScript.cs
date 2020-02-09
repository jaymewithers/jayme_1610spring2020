using UnityEngine;

namespace AtHomePractice
{
    public class EnumScript : MonoBehaviour
    {
        enum Direction {North, East, South, West};

        void Start()
        {
            Direction myDirection;

            myDirection = Direction.North;
            
            myDirection -= ReverseDirection(Direction.North);
        }

        Direction ReverseDirection (Direction dir)
        {
            if (dir == Direction.North)
                dir = Direction.South;
            else if (dir == Direction.South)
                dir = Direction.North;
            else if (dir == Direction.East)
                dir = Direction.West;
            else if (dir == Direction.West)
                dir = Direction.East;

            return dir;
        }
    }
}

// unity tutorial - enumerations