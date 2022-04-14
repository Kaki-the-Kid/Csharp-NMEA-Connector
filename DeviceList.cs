using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Device = Xamarin.Forms.Device;

namespace NMEA_connector
{
    public struct NMEA2000_Device
    {
        public string NMEA2000DeviceUniqueNumber { get; set; } //unique_number
        public string NMEA2000DeviceAddress { get; set; }// address // The device address displayed like: 3A (58)
        public string NMEA2000DeviceManufacturer { get; set; } // manufacturer_code // The manufacturer of the device displayed like: Garmin E-12
        public string NMEA2000DeviceDeviceInstance { get; set; } //device_instance
        public string NMEA2000DeviceSystemInstance { get; set; }//system_instance
        public string NMEA2000DeviceClass { get; set; } //class
        public string NMEA2000DeviceFunction { get; set; } //function // Device function display like: Humidity outsode measurement
        public string NMEA2000DeviceI{ get; set; }//self-configurable
        public string NMEA2000DeviceDatabaseInformation { get; set; }//database_information
        public string NMEA2000DeviceProductCode { get; set; }//product_code
        public string NMEA2000DeviceModelVersion { get; set; }//model_version
        public string NMEA2000DeviceModelId { get; set; }//model_id
        public string NMEA2000DeviceFirmware { get; set; }//software_version,// Device firmware like: 1.41 16/03/2018
        public string NMEA2000DeviceStandard { get; set; }
        public string NMEA2000DeviceSerial { get; set; }//serial // Device serial like: 00001657
        public string NMEA2000DeviceCertification { get; set; } //certification
        public string NMEA2000DeviceLen_mA { get; set; } //len_ma
        public string NMEA2000DeviceHeartbeat { get; set; } //heartbeat
        public string NMEA2000DeviceUpdated { get; set; } //updated
        public string NMEA2000DeviceinstallationDesc1 { get; set; } //installation_desc1
        public string NMEA2000DeviceInstallationDesc2 { get; set; } //installation_desc2
        public string NMEA2000DeviceManufaturerInfo { get; set; } //manufaturer_info
    }

    /******************************************************************//*
     * Direct inserting of devide
     * [TBD] Connecting to database
     ********************************************************************/
    public class DeviceList
    {
        public List<NMEA2000_Device> NMEADevices {get;set;}

        /******************************************************************//*
         * Direct inserting of devide
         * [TBD] Connecting to database
         ********************************************************************/
        public void AddDevice(
            string deviceAddr, 
            string manufaturer, 
            string funtion,
            string serial,
            string firmware,
            string nmeaStandard = ""
            )
        {
            NMEA2000_Device addDevice = new NMEA2000_Device();

            addDevice.NMEA2000DeviceAddress = deviceAddr;
            addDevice.NMEA2000DeviceManufacturer = manufaturer;
            addDevice.NMEA2000DeviceFunction = funtion;
            addDevice.NMEA2000DeviceSerial = serial;
            addDevice.NMEA2000DeviceFirmware = firmware;
            addDevice.NMEA2000DeviceStandard = nmesStandard;

            this.NMEADevices.Add(addDevice);
        }

        static void PopulateDeviceList()
        {

        }
    }
}