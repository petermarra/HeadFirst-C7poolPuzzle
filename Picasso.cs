using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace poolPuzzle
{
    abstract class Picasso:Nose
    {
        public virtual int Ear()
        {
            return 7;
        }

        public Picasso(string face)
        {
            this.face = face;
        }
        public virtual string Face
        {
            get
            {
                return face;
            }
        }
        string face;
    }
}
