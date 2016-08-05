﻿using System;
using System.Collections.Generic;

namespace CartoMobileSample
{  
	public class Samples
	{
		public const string IntentName = "INTENTNAME";

		// List of demo activities
		public static List<Type> List = new List<Type>(new Type[] {
			typeof (CartoVisJSONActivity),
			typeof (ClusteredGeoJSONCapitals),
			typeof (GpsLocationMap),
			typeof (Overlays2DActivity),
			typeof (OfflineVectorMapActivity),
			typeof (OfflineRouting),
			typeof (PinMapActivity),
			typeof (PackageManagerActivity),
			typeof (RasterOverlayActivity)
		});

		public static string[] AsStringArray {
			get {
				return List.ToStringArray();
			}
		}

		public static Type FromPosition(int position) 
		{
			return List[position];
		}
	}
}
