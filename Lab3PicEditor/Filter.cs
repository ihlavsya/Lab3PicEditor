using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab3PicEditor
{
    public static class Filter
    {
        public static Bitmap FilterPic(string core, Bitmap origin)
        {
            double[,] Core = CreateCore(3, 3);
            switch (core)
            {
                case "Gaussian blur":
                    {
                        Core = FillCoreBlurring(Core);
                        break;
                    }
                case "Increase the clarity":
                    {
                        Core = FillCoreIncreaseClarity(Core);
                        break;
                    }
                case "Find edges":
                    {
                        Core = FillCoreFindEdges(Core);
                        break;
                    }
                case "Embossing":
                    {
                        Core = FillCoreEmbossing(Core);
                        break;
                    }
                case "Box's filter":
                    {
                        Core = FillCoreBoxFilter(Core);
                        break;
                    }
            }
            Bitmap filteredPic = FilterPic(Core, origin);
            return filteredPic;
        }

        private static int getMedian(int[,] array)
        {
            int med = 0;
            int[] tmp = new int[array.GetLength(0) * array.GetLength(1)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    tmp[i * array.GetLength(1) + j] = array[i, j];
                }
            }
            Array.Sort(tmp);
            med = tmp[tmp.GetLength(0) / 2];
            return med;
        }

        public static Bitmap ApplyMedian(int N, Bitmap input)
        {
            int countX = N;
            int countY = N;
            Bitmap newImg = new Bitmap(input.Width, input.Height);

            int width = input.Width;
            int height = input.Height;

            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {

                    int[,] patchR = new int[countX, countY];
                    int[,] patchG = new int[countX, countY];
                    int[,] patchB = new int[countX, countY];
                    for (int x = 0; x < countX; x++)
                        for (int y = 0; y < countY; y++)
                        {
                            int cX = Math.Max(0, i - x);
                            int cY = Math.Max(0, j - y);
                            patchR[x, y] = input.GetPixel(cX, cY).R;
                            patchG[x, y] = input.GetPixel(cX, cY).G;
                            patchB[x, y] = input.GetPixel(cX, cY).B;
                        }
                    int r = getMedian(patchR);
                    int g = getMedian(patchG);
                    int b = getMedian(patchB);
                    Color resColor = Color.FromArgb(r, g, b);

                    newImg.SetPixel(i, j, resColor);
                }
            return newImg;
        }

        private static Bitmap FilterPic(double[,] core, Bitmap origin)
        {
            Bitmap filteredPic = new Bitmap(origin.Width, origin.Height);
            for (int i = 0; i < filteredPic.Width; i++)
            {
                for (int j = 0; j < filteredPic.Height; j++)
                {
                    double redFilteredPic = 0;
                    double greenFilteredPic = 0;
                    double blueFilteredPic = 0;

                    int A = origin.GetPixel(i, j).A;
                    for (int k = 0; k < core.GetLength(0); k++)
                    {
                        for (int p = 0; p < core.GetLength(1); p++)
                        {
                            double redOrigin;
                            double greenOrigin;
                            double blueOrigin;

                            int firstIndex = i - k;
                            int secondIndex = j - p;
                            if ((i - k) < 0)
                            {
                                firstIndex = i;
                            }
                            if ((j - p) < 0)
                            {
                                secondIndex = j;
                            }
                            redOrigin = origin.GetPixel(firstIndex, secondIndex).R;
                            greenOrigin = origin.GetPixel(firstIndex, secondIndex).G;
                            blueOrigin = origin.GetPixel(firstIndex, secondIndex).B;

                            double redSyllable = redOrigin * core[k, p];
                            double greenSyllable = greenOrigin * core[k, p];
                            double blueSyllable = blueOrigin * core[k, p];

                            redFilteredPic += redSyllable;
                            greenFilteredPic += greenSyllable;
                            blueFilteredPic += blueSyllable;
                        }
                    }
                    redFilteredPic = Math.Abs(redFilteredPic);
                    greenFilteredPic = Math.Abs(greenFilteredPic);
                    blueFilteredPic = Math.Abs(blueFilteredPic);

                    redFilteredPic = Math.Min(255, redFilteredPic);
                    greenFilteredPic = Math.Min(255, greenFilteredPic);
                    blueFilteredPic = Math.Min(255, blueFilteredPic);
                    filteredPic.SetPixel(i, j, Color.FromArgb(A, (int)redFilteredPic, (int)greenFilteredPic, (int)blueFilteredPic));
                }
            }
            return filteredPic;
        }

        private static double[,] CreateCore(int Width, int Height)
        {
            double[,] core = new double[Width, Height];
            return core;
        }

        private static double[,] FillCoreBoxFilter(double[,] core)
        {
            core[0, 0] = 1 / 9.0;
            core[0, 1] = 1 / 9.0;
            core[0, 2] = 1 / 9.0;

            core[1, 0] = 1 / 9.0;
            core[1, 1] = 1 / 9.0;
            core[1, 2] = 1 / 9.0;

            core[2, 0] = 1 / 9.0;
            core[2, 1] = 1 / 9.0;
            core[2, 2] = 1 / 9.0;
            return core;
        }

        private static double[,] FillCoreBlurring(double[,] core)
        {
            core[0, 0] = 0.0625;
            core[0, 1] = 0.125;
            core[0, 2] = 0.0625;

            core[1, 0] = 0.125;
            core[1, 1] = 0.25;
            core[1, 2] = 0.125;

            core[2, 0] = 0.0625;
            core[2, 1] = 0.125;
            core[2, 2] = 0.0625;
            return core;
        }

        private static double[,] FillCoreIncreaseClarity(double[,] core)
        {
            core[0, 0] = -0.1;
            core[0, 1] = -0.2;
            core[0, 2] = -0.1;

            core[1, 0] = -0.2;
            core[1, 1] = 2.2;
            core[1, 2] = -0.2;

            core[2, 0] = -0.1;
            core[2, 1] = -0.2;
            core[2, 2] = -0.1;
            return core;
        }

        private static double[,] FillCoreFindEdges(double[,] core)
        {
            core[0, 0] = -1;
            core[0, 1] = 0;
            core[0, 2] = 1;

            core[1, 0] = -2;
            core[1, 1] = 0;
            core[1, 2] = 2;

            core[2, 0] = -1;
            core[2, 1] = 0;
            core[2, 2] = 1;
            return core;
        }

        private static double[,] FillCoreEmbossing(double[,] core)
        {
            core[0, 0] = 0;
            core[0, 1] = 1;
            core[0, 2] = 0;

            core[1, 0] = 1;
            core[1, 1] = 0;
            core[1, 2] = -1;

            core[2, 0] = 0;
            core[2, 1] = -1;
            core[2, 2] = 0;
            return core;
        }
    }
}
