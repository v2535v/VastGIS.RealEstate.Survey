namespace OSGeo.GDAL
{
    using System;

    public enum ResampleAlg
    {
        GRA_Average = 5,
        GRA_Bilinear = 1,
        GRA_Cubic = 2,
        GRA_CubicSpline = 3,
        GRA_Lanczos = 4,
        GRA_Max = 8,
        GRA_Med = 10,
        GRA_Min = 9,
        GRA_Mode = 6,
        GRA_NearestNeighbour = 0,
        GRA_Q1 = 11,
        GRA_Q3 = 12
    }
}

