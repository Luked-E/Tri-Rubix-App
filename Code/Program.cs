namespace TriRubix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        class TriCube
        {
            byte[,] topTurn =
            {
                {1,2 }, {2,3 }, {3,4 }, {4,1 },
            };
            byte[,] frontTurn =
            {
                {2,1 }, {1,5 }, {5,6 }, {6,2 },
            };
            byte[,] rightTurn =
            {
                { }, { }, { }, { },
            };
        }
        class TriCubelet
        {
            int posX = 0; int posY = 0; int posZ = 0;
            int rotX = 0; int rotY = 0; int rotZ = 0;
        }
    }
}
