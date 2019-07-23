using DFDS.Models;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Web;

namespace DFDS.Common
{
    public static class DistanceUtil
    {
        /// <summary>
        /// Calculates the total distance traveled from a list of coordinates
        /// </summary>
        /// <param name="route"></param>
        /// <returns>The total distance in meters</returns>
        public static double GetTotalDistance(List<Coordinate> route)
        {
            if(route == null)
            {
                return 0;
            }

            double sum = 0;

            for(int i = 0; i < route.Count - 1; i++)
            {
                var from = route[i];
                var to = route[i+1];
                var distance = GetDistance(from, to);
                sum += distance;
            }

            return sum;
        }

        /// <summary>
        /// Gets the distance between two coordinates
        /// Using the GeoCoordinate library
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static double GetDistance(Coordinate start, Coordinate end)
        {
            var geoCoordinateStart = GetGeoCoordinate(start.Latitude, start.Longitude);
            var geoCoordinateEnd = GetGeoCoordinate(end.Latitude, end.Longitude);
            var distance = geoCoordinateStart.GetDistanceTo(geoCoordinateEnd);
            return distance;
        }

        /// <summary>
        /// Returns a GeoCoordinate from a latitude and longitude
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        public static GeoCoordinate GetGeoCoordinate(double latitude, double longitude)
        {
            return new GeoCoordinate(latitude, longitude);
        }
    }
}