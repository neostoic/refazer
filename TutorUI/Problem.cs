﻿using System.Collections;
using System.Collections.Generic;
using Tutor;

namespace TutorUI
{
    internal class Problem
    {
        internal string Id { get; }
        internal IEnumerable<Mistake> Mistakes { get; set; }

        internal IDictionary<int, IList<Mistake>> AttemptsPerStudent { get; set; }
        internal Dictionary<string, long> Tests { get; set; }

        internal Problem(string id, IEnumerable<Mistake> mistakes)
        {
            Id = id;
            Mistakes = mistakes;
        }

        public Problem(string id)
        {
            Id = id;
        }
    }
}