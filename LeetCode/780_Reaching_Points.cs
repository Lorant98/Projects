namespace LeetCode_780
{
    class Solution
    {
        public bool ReachingPoints(int sx, int sy, int tx, int ty)
        {
            while (true)
            {
                if (sx > tx || sy > ty)
                    return false;

                if (sx == tx)
                    return (ty - sy) % sx == 0;

                if (sy == ty)
                    return (tx - sx) % sy == 0;

                if (tx >= ty)
                    tx %= ty;
                else
                    ty %= tx;
            }
        }
    }
}
