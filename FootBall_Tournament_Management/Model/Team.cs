﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Tournament_Management.NewFolder1
{
    internal class Team
    {
        private int teamID;
        private string teamName;
        private int coachID;
        private DateTime establishedDate;
        private string avatarPath;

        public Team(string teamName, int coachID, DateTime establishDate)
        {
            
            this.TeamName = teamName;
            this.CoachID = coachID;
            this.EstablishedDate = establishDate;
        }

        public Team(int teamID, string teamName, int coachID, DateTime establishedDate)
        {
            this.teamID = teamID;
            this.teamName = teamName;
            this.coachID = coachID;
            this.establishedDate = establishedDate;
        }
        
        public Team() { }

        public Team(string teamName, int coachID, DateTime establishedDate, string avatarPath)
        {
            this.teamName = teamName;
            this.coachID = coachID;
            this.establishedDate = establishedDate;
            this.avatarPath = avatarPath;
        }

        public Team(int teamID, string teamName, int coachID, DateTime establishedDate, string avatarPath)
        {
            this.teamID = teamID;
            this.teamName = teamName;
            this.coachID = coachID;
            this.establishedDate = establishedDate;
            this.avatarPath = avatarPath;
        }

        public int TeamID { get => teamID; set => teamID = value; }
        public string TeamName { get => teamName; set => teamName = value; }
        public int CoachID { get => coachID; set => coachID = value; }
        public DateTime EstablishedDate { get => establishedDate; set => establishedDate = value; }
        public string AvatarPath { get => avatarPath; set => avatarPath = value; }
    }
}