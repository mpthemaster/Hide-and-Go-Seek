
namespace HideAndGoSeek
{
    class Room : Location
    {
        public Room(string name, string decoration)
            : base(name)
        {
            this.decoration = decoration;
        }

        private string decoration;

        public override string Description
        {
            get { return "You see " + decoration + " " + base.Description; }
        }
    }
}
