﻿using RentalMovies.Domain.Records;
using System;
using System.Collections.Generic;

namespace RentalMovies.Domain
{
    public class IdentityMap //+Singleton
    {
        private static IdentityMap soleInstance;
        private Dictionary<string, Customer> CustomerMap;
        private Dictionary<string, DVD> DVDMap;
        private Dictionary<string, Movie> MovieMap;
        private Dictionary<string, Renting> RentingMap;
        private Dictionary<string, DVDTag> DVDTagMap;
        private Dictionary<string, User> UserMap;


        private static class MapTool<T> where T : AbstractActiveRecord
        {
            public static void Add(ref Dictionary<string, T> dict, ref T arg)
            {
                dict.Remove(arg.Id);
                dict.Add(arg.Id, arg);
            }
            public static T Get(ref Dictionary<string, T> dict, string key)
            {
                T value;
                dict.TryGetValue(key, out value);
                return value;
            }
        }

        private IdentityMap()
        {
            CustomerMap = new Dictionary<string, Customer>();
            DVDMap = new Dictionary<string, DVD>();
            MovieMap = new Dictionary<string, Movie>();
            RentingMap = new Dictionary<string, Renting>();
            DVDTagMap = new Dictionary<string, DVDTag>();
            UserMap = new Dictionary<string, User>();
        }

        public static IdentityMap SoleInstance
        {
            get
            {
                if (soleInstance == null)
                    soleInstance = new IdentityMap();
                return soleInstance;
            }
        }
        public void Add(AbstractActiveRecord arg)
        {
            switch (arg.DataObjectType)
            {
                case DataObjectType.Customer:
                    {
                        var x = (Customer) arg;
                        MapTool<Customer>.Add(ref soleInstance.CustomerMap, ref x); break;
                    }
                case DataObjectType.DVD:
                    {
                        var x = (DVD) arg;
                        MapTool<DVD>.Add(ref soleInstance.DVDMap, ref x); break;
                    }
                case DataObjectType.DVDTag:
                    {
                        var x = (DVDTag)arg;
                        MapTool<DVDTag>.Add(ref soleInstance.DVDTagMap, ref x); break;
                    }
                case DataObjectType.Movie:
                    {
                        var x = (Movie)arg;
                        MapTool<Movie>.Add(ref soleInstance.MovieMap, ref x); break;
                    }
                case DataObjectType.Renting:
                    {
                        var x = (Renting)arg;
                        MapTool<Renting>.Add(ref soleInstance.RentingMap, ref x); break;
                    }
                case DataObjectType.User:
                    {
                        var x = (User)arg;
                        MapTool<User>.Add(ref soleInstance.UserMap, ref x); break;
                    }
                default:
                    throw new NotImplementedException();
            }
        }

        public T Get<T>(DataObjectType dataType, string key) where T : AbstractActiveRecord
        {
            return (T)Convert.ChangeType(GetAbstract<T>(dataType, key), typeof(T));
        }

        private AbstractActiveRecord GetAbstract<T>(DataObjectType dataType, string key) where T : AbstractActiveRecord
        {
            switch (dataType)
            {
                case DataObjectType.Customer:
                    return MapTool<Customer>.Get(ref soleInstance.CustomerMap, key); 
                case DataObjectType.DVD:
                    return MapTool<DVD>.Get(ref soleInstance.DVDMap, key);
                case DataObjectType.DVDTag:
                    return MapTool<DVDTag>.Get(ref soleInstance.DVDTagMap, key);
                case DataObjectType.Movie:
                    return MapTool<Movie>.Get(ref soleInstance.MovieMap, key);
                case DataObjectType.Renting:
                    return MapTool<Renting>.Get(ref soleInstance.RentingMap, key);
                case DataObjectType.User:
                    return MapTool<User>.Get(ref soleInstance.UserMap, key);
                default:
                    throw new NotImplementedException();
            }
        }

        public bool Delete(AbstractActiveRecord record)
        {
            var dataType = record.DataObjectType;
            var key = record.Id;
            switch (dataType)
            {
                case DataObjectType.Customer:
                    return soleInstance.CustomerMap.Remove(key);
                case DataObjectType.DVD:
                    return soleInstance.DVDMap.Remove(key);
                case DataObjectType.DVDTag:
                    return soleInstance.DVDTagMap.Remove(key);
                case DataObjectType.Movie:
                    return soleInstance.MovieMap.Remove(key);
                case DataObjectType.Renting:
                    return soleInstance.RentingMap.Remove(key);
                case DataObjectType.User:
                    return soleInstance.UserMap.Remove(key);
                default:
                    throw new NotImplementedException();
            }
        }

    }
}
