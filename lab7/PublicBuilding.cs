using System;
namespace lab7
{
    public abstract class PublicBuilding : IBuilding
    {

        public bool IsOpen { get; set; }
        protected string Address { get; }
        protected string Name { get; }

        protected PublicBuilding(string name, string address, bool isOpen)
        {
            Name = name;
            Address = address;
            IsOpen = isOpen;
        }

        public abstract void OpenBuilding();

        public abstract void CloseBuilding();
    }
}
