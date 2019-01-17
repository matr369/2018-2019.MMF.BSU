using System;
namespace lab7
{
    public class Theater : PublicBuilding
    {
        private bool IsElectricityEnabled;
        private int Capacity { get; }
        public Theater(string name, string address, int capacity, bool isOpen) : base(name, address, isOpen)
        {
            IsElectricityEnabled = false;
            Capacity = capacity;
        }

        private void ToggleElectricity(bool state)
        {
            IsElectricityEnabled = state;
        }

        public override void OpenBuilding()
        {
            ToggleElectricity(true);
            IsOpen = true;
        }

        public override void CloseBuilding()
        {
            ToggleElectricity(false);
            IsOpen = false;
        }

        public override string ToString()
        {
            return Name + ", Address: " + Address + ", Capacity: " + Capacity + ", " + (IsOpen ? "Open!!!" : "Closed!!!");
        }
    }
}
