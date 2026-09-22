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

       

        public string TrackingCode
        {
            get { return _TrackingCode; }

            private set 
            {
                if(!string.IsNullOrEmpty(value))
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
            get { return DeliveryFee + (Weight * 5); }
        }

        

    }
}
