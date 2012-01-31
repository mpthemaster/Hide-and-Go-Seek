//A location outside without a hiding place.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HideAndGoSeek
{
    class Outside : Location
    {
        /// <summary>
        /// Sets whether the outside location is hot or not.
        /// </summary>
        /// <param name="name">The name of the location outside.</param>
        /// <param name="decoration">A unique decoration that is seen.</param>
        /// <param name="hot">Whether or not it is hot.</param>
        public Outside(string name, string decoration, bool hot)
            : base(name)
        {
            this.hot = hot;
            this.decoration = decoration;
        }

        private string decoration;
        private bool hot;

        //Adds the decoration and bool to the description of the outside location.
        public override string Description
        {
            get
            {
                string description = "You see " + decoration + " And you feel ";

                if (hot)
                    description += "hot and sweaty.";
                else
                    description += "cool and refreshed.";

                return description + " " + base.Description;
            }
        }
    }
}
