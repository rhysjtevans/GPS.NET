﻿using Ghostware.GPS.NET.Enums;
using Ghostware.GPS.NET.GpsClients.Interfaces;
using Ghostware.GPS.NET.Models.ConnectionData.Interfaces;

namespace Ghostware.GPS.NET.GpsClients
{
    public class GpsdGpsClient : IBaseGpsClient
    {
        public GpsType GpsType => GpsType.Gpsd;

        public void Connect(IGpsData connectionData)
        {
            throw new System.NotImplementedException();
        }

        public void Disconnect()
        {
            throw new System.NotImplementedException();
        }
    }
}