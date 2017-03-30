namespace HeroesArena
{
    // Represents coordinates on the grid in game logic.
    public class Coordinates
    {
        public readonly int X, Y;

        public Coordinates(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            // If obj can not be cast to Coordinates.
            Coordinates coords = obj as Coordinates;
            if (coords == null)
            {
                return false;
            }

            return (X == coords.X) && (Y == coords.Y);
        }

        // For performance.
        public bool Equals(Coordinates coords)
        {
            if (coords == null)
            {
                return false;
            }

            return (X == coords.X) && (Y == coords.Y);
        }

        // For Equals.
        public override int GetHashCode()
        {
            return X ^ Y;
        }

        // TODO
    }
}
