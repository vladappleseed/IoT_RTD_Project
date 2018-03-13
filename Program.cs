﻿using Gtk;
using System;
using System.Net;
using System.IO;
using System.Text;
using ProtoBuf;
using transit_realtime;
using System.Collections.Generic;

/** Authors: Vlad Makarov, Mark Nilov **/
namespace RTD_UI_Application
{

    class Program
	{
        public static List<Stop.stop_t> allstops = new List<Stop.stop_t>();
        
		static void Main(string[] args)
        {
            //============ Code to initialize and open UI Window ============//

            Application.Init();
            MainWindow win = new MainWindow();
            win.Title = "RTD Trip Planner (v1.0.0)";
            //win.Resizable = false;
            win.Show();
            Application.Run();
        }

        // Returns all bus stops; gets called from MainWindow.cs
        public static List<Stop.stop_t> returnAllBusStops()
        {
			Uri myUri = new Uri("http://www.rtd-denver.com/google_sync/VehiclePosition.pb");
			WebRequest myWebRequest = HttpWebRequest.Create(myUri);

			HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;

			// This username and password is issued for the IWKS 4120 class. Please DO NOT redistribute.
			NetworkCredential myNetworkCredential = new NetworkCredential("RTDgtfsRT", "realT!m3Feed");    // insert credentials here

			CredentialCache myCredentialCache = new CredentialCache();
			myCredentialCache.Add(myUri, "Basic", myNetworkCredential);

			myHttpWebRequest.PreAuthenticate = true;
			myHttpWebRequest.Credentials = myCredentialCache;

            Stop stop_inst = new Stop();
			FeedMessage feed = Serializer.Deserialize<FeedMessage>(myWebRequest.GetResponse().GetResponseStream());

			foreach (FeedEntity entity in feed.entity)
            {
                if (entity.vehicle != null)
                {
                    if (entity.vehicle.trip != null)
                    {
                        if (entity.vehicle.trip.route_id != null)
                        {
                            Console.WriteLine("Vehicle ID = " + entity.vehicle.vehicle.id);
                            Console.WriteLine("Current Position Information:");
                            Console.WriteLine("Current Latitude = " + entity.vehicle.position.latitude);
                            Console.WriteLine("Current Longitude = " + entity.vehicle.position.longitude);
                            Console.WriteLine("Current Bearing = " + entity.vehicle.position.bearing);
                            Console.WriteLine("Current Status = " + entity.vehicle.current_status + " StopID: " + entity.vehicle.stop_id);
                            if (Stop.stops.ContainsKey(entity.vehicle.stop_id))
                            {
                                Console.WriteLine("The name of this StopID is \"" + Stop.stops[entity.vehicle.stop_id].stop_name + "\"");

                                var cd = new Stop.stop_t();                     //populates list with stops and their info
                                cd.stop_id = entity.vehicle.stop_id;
                                cd.stop_name = Stop.stops[entity.vehicle.stop_id].stop_name;
                                cd.stop_lat = Stop.stops[entity.vehicle.stop_id].stop_lat;
                                cd.stop_long = Stop.stops[entity.vehicle.stop_id].stop_long;
                                allstops.Add(cd);

                                Console.WriteLine("The Latitude of this StopID is \"" + Stop.stops[entity.vehicle.stop_id].stop_lat + "\"");
                                Console.WriteLine("The Longitude of this StopID is \"" + Stop.stops[entity.vehicle.stop_id].stop_long + "\"");
                                string wheelChairOK = "IS NOT";
                                if (Stop.stops[entity.vehicle.stop_id].wheelchair_access)
                                {
                                    wheelChairOK = "IS";
                                }
                                Console.WriteLine("This stop is " + wheelChairOK + " wheelchair accessible");
                            }

                            Console.WriteLine("Trip ID = " + entity.vehicle.trip.trip_id);
                            if (Trip.trips.ContainsKey(entity.vehicle.trip.trip_id))
                            {
                                if (entity.vehicle.current_status.ToString() == "IN_TRANSIT_TO")
                                {
                                    if (Stop.stops.ContainsKey(entity.vehicle.stop_id))
                                    {
                                        Console.WriteLine("Vehicle in transit to: " + Stop.stops[entity.vehicle.stop_id].stop_name);
                                        Trip.trip_t trip = Trip.trips[entity.vehicle.trip.trip_id];
                                        foreach (Trip.trip_stops_t stop in trip.tripStops)
                                        {
                                            // Console.WriteLine(stop.stop_id);      //should print whole trip with names of stops, only prints ID's
                                            foreach (Stop.stop_t s in allstops)
                                            {

                                                if (stop.stop_id == s.stop_id)      //dosent work correctly
                                                {
                                                    //      Console.WriteLine(s.stop_name);
                                                }

                                            }


                                            if (stop.stop_id == entity.vehicle.stop_id)
                                            {
                                                Console.WriteLine(".. and is scheduled to arrive there at " + stop.arrive_time);
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return allstops;
        }
    }
}


/* Denver RTD Data Formats



Sample of the Trip Updates Feed
-------------------------------
header {
    gtfs_realtime_version: "1.0"
    incrementality: FULL_DATASET
    timestamp: 1449176392
}
entity {
    id: "1449176392_109470943"
    trip_update {
        trip {
            trip_id: "109470943"
            schedule_relationship: SCHEDULED
            route_id: "0"
            direction_id: 0
        }
        stop_time_update {
            stop_sequence: 6
            arrival {
                time: 1449176381
            }
            departure {
               time: 1449176381
            }
            stop_id: "25676"
            schedule_relationship: SCHEDULED
        }
        stop_time_update {
            stop_sequence: 7
            arrival {
                time: 1449176479
            }
            departure {
                time: 1449176479
            }
            stop_id: "22454"
            schedule_relationship: SCHEDULED
        }
        stop_time_update {
            stop_sequence: 8
            arrival {
                time: 1449176585
            }
            departure {
                time: 1449176585
            }
            stop_id: "20378"
            schedule_relationship: SCHEDULED
        }
        vehicle {
            id: "6010"
            label: "6010"
        }
        timestamp: 1449042054
    }
}




Sample of the Vehicle Positions Feed
------------------------------------
header {
    gtfs_realtime_version: "1.0"
    incrementality: FULL_DATASET
    timestamp: 1449042263
}
entity {
    id: "1449042263_1505"
    vehicle {
        trip {
            trip_id: "109486700"
            schedule_relationship: SCHEDULED
            route_id: "AB"
            direction_id: 1
        }
        position {
            latitude: 39.8419
            longitude: -104.676231
            bearing: 161
        }
        current_status: IN_TRANSIT_TO
        timestamp: 1449042245
        stop_id: "22903"
        vehicle {
            id: "1505"
            label: "1505"
        }
    }
}
*/

