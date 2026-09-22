using System;
using System.Collections.Generic;
using System.Text;

namespace OOP__01_Assign_
{
    internal struct Shipment
    {
        private string _TrackingCode;
        private string _Description;
        private double _Weight;
        private double _DeliveryFee;

        public DeliveryAddress Destination { get; set; }

        public Shipment(string trackingCode) 
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight =  1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress();
        }

        public Shipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination) 
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public string TrackingCode
        {
            get { return _TrackingCode; }

            private set 
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    _TrackingCode = value;
                }
            }
        }


        public string Description
        {
            get { return _Description; }

            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    _Description = value;
                }
            }
        }


        public double Weight
        {
            get { return _Weight; }
            set 
            { 
                if(value > 0)
                {
                    _Weight = value;
                }
            }
        }

       
        public double DeliveryFee
        {
            get { return _DeliveryFee; }

            private set
            {
                if (value > 0)
                {
                    _DeliveryFee = value;
                }
            }
        }


        public double EstimatedCost
        {
            get { return _DeliveryFee + (_Weight * 5); }
        }

        public void UpdateDeliveryFee(double newFee)
        {
            if(newFee > 0)
            {
                _DeliveryFee = newFee;
            }

        }

        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code ; {_TrackingCode}");
            Console.WriteLine($"Description : {_Description}");
            Console.WriteLine($"Weight ; {_Weight}");
            Console.WriteLine($"Delivery fee : {_DeliveryFee} ");
            Console.WriteLine($"Destination : {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost : {EstimatedCost}");
        }


    }
}
