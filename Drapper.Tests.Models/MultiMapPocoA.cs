using System;
using System.Collections;
using System.Collections.Generic;

namespace Drapper.Tests.Models
{
    public class MultiMapPocoA
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public PocoA PocoA { get; set; }        
    }
}



namespace Drapper.Tests.Models.Music
{
    public class Track
    {

        public string Title { get; }
        public TimeSpan Duration { get; }
    }
    

    public class FooFighters
    {
        public TheColourAndTheShape TheColourAndTheShape { get; }
    }

    public class TheColourAndTheShape : Album
    {
        public TheColourAndTheShape(string name, int released) : base(name, released)
        {
        }
    }

    public class Album
    {
        public string Name { get; }
        public int Released { get; }

        public Album(string name, int released)
        {
            Name = name;
            Released = released;
        }
    }
}