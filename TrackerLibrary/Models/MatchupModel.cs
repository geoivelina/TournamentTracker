﻿namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one match in the tournament
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// The set of teams that were involved int htis mathc
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Tehe winner of the match
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Which round this match is a part of
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
