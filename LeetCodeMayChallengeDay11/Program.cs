using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMayChallengeDay11
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[][] 2dArray = new int[] { new int[] { 1, 1 } };
            //int[][] array2D = new int[][] { new int[] { 1, 1, 1 }, new int[] { 1, 1, 0 }, new int[] { 1, 0, 1 } };
            int[][] array2D = new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 1, 1 } };
            FloodFill(array2D, 1, 1, 2);
        }

        public static int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            if (image == null || image[sr][sc] == newColor)
            {
                return image;
            }
            fillScreen(image, sr, sc, image[sr][sc], newColor);
            return image;
        }

        public static void fillScreen(int[][] image, int x, int y, int prevColor, int newColor)
        {
            int xmax = (image.Length - 1);
            int ymax = image[0].Length - 1;

            if (x < 0 || y < 0 || x > xmax || y > ymax || image[x][y] != prevColor)
            {
                return;
            }

            image[x][y] = newColor;

            fillScreen(image, x + 1, y, prevColor, newColor);
            fillScreen(image, x - 1, y, prevColor, newColor);
            fillScreen(image, x, y - 1, prevColor, newColor);
            fillScreen(image, x, y + 1, prevColor, newColor);

        }
    }
}
