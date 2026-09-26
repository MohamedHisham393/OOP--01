using System;
using System.Collections.Generic;
using System.Text;

namespace OOP__01_Assign_
{
    internal struct DeliveryCenter
    {
        //private int _size = 10;

        private Shipment[] _shipments;
        public DeliveryCenter()
        {
            _shipments = new Shipment[10];
        }

        public Shipment this[int index]
        {
            get 
            {
                if(index < _shipments.Length && index >= 0)
                {
                    return _shipments[index];
                }
                else
                {
                    return default;
                }
            }
            
            set 
            { 
                if (index < _shipments.Length && index >= 0)
                {
                    _shipments[index] = value;
                }
            } 
        }

        public Shipment this[string trackingCode] 
        {    
            get 
            {
                for (int i = 0; i < _shipments.Length; i++)
                {
                    if (trackingCode == _shipments[i].TrackingCode)
                    {
                        return _shipments[i];
                    }
                }
                    return default;
            } 
        }

        public bool AddShipment(Shipment ship)
        {
            for(int i = 0; i < _shipments.Length ; i++)
            {
                if (_shipments[i].TrackingCode == null)
                {
                    _shipments[i] = ship;
                    return true;
                }
            }
            return false;
        }
    }
}
