using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Device = Xamarin.Forms.Device;

namespace NMEA_connector
{
    public struct NMEA2000_Device
    {
        public string NMEA200DeviceUniqueNumber { get; set; } //unique_number
        public string NMEA200DeviceAddress { get; set; }// address // The device address displayed like: 3A (58)
        public string NMEA200DeviceManufacturer { get; set; } // manufacturer_code // The manufacturer of the device displayed like: Garmin E-12
        public string NMEA200DeviceDeviceInstance { get; set; } //device_instance
        public string NMEA200DeviceSystemInstance { get; set; }//system_instance
        public string NMEA200DeviceClass { get; set; } //class
        public string NMEA200DeviceFunction { get; set; } //function // Device function display like: Humidity outsode measurement
        public string NMEA200DeviceI{ get; set; }//self-configurable
        public string NMEA200DeviceDatabaseInformation { get; set; }//database_information
        public string NMEA200DeviceProductCode { get; set; }//product_code
        public string NMEA200DeviceModelVersion { get; set; }//model_version
        public string NMEA200DeviceModelId { get; set; }//model_id
        public string NMEA2000DeviceFirmware { get; set; }//software_version,// Device firmware like: 1.41 16/03/2018
        public string NMEA200DeviceSerial { get; set; }//serial // Device serial like: 00001657
        public string NMEA200DeviceCertification { get; set; } //certification
        public string NMEA200DeviceLen_mA { get; set; } //len_ma
        public string NMEA200DeviceHeartbeat { get; set; } //heartbeat
        public string NMEA200DeviceUpdated { get; set; } //updated
        public string NMEA200DeviceinstallationDesc1 { get; set; } //installation_desc1
        public string NMEA200DeviceInstallationDesc2 { get; set; } //installation_desc2
        public string NMEA200DeviceManufaturerInfo { get; set; } //manufaturer_info
    }


    public class DeviceList
    {
        public List<NMEA2000_Device> NMEADevices {get;set;}

        public void AddDevice(
            string deviceAddr, 
            string manufaturer, 
            string funtion,
            string serial,
            string firmware)
        {
            NMEA2000_Device addDevice = new NMEA2000_Device();

            addDevice.NMEA200DeviceAddress = deviceAddr;
            addDevice.NMEA200DeviceManufacturer = manufaturer;
            addDevice.NMEA200DeviceFunction = funtion;
            addDevice.NMEA200DeviceSerial = serial;
            addDevice.NMEA2000DeviceFirmware = firmware;

            this.NMEADevices.Add(addDevice);
        }

        static void PopulateDeviceList()
        {

        }
    }
}