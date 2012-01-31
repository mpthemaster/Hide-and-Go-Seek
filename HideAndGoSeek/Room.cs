//A room without a hiding place.
namespace HideAndGoSeek
{
    class Room : Location
    {
        /// <summary>
        /// Sets what the unique decoration is.
        /// </summary>
        /// <param name="name">The name of the room.</param>
        /// <param name="decoration">A unique decoration in the room.</param>
        public Room(string name, string decoration)
            : base(name)
        {
            this.decoration = decoration;
        }

        private string decoration;

        //Adds the decoration to the description.
        public override string Description
        {
            get { return "You see " + decoration + " " + base.Description; }
        }
    }
}
