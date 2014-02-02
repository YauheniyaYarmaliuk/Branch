﻿namespace Branch.Models.Services.Branch
{
	public sealed class Halo4StatsEntity : BaseEntity
	{
		public static readonly string PartitionKeyString = "Halo4Stats";
		public static readonly string RowKeyString = "{0}";

		public Halo4StatsEntity() { }

		public Halo4StatsEntity(Enums.Halo4StatType statType)
		{
			Type = statType;
			SetKeys(PartitionKeyString, string.Format(RowKeyString, statType));
		}

		public int TypeInt { get; set; }
		public Enums.Halo4StatType Type
		{
			get { return (Enums.Halo4StatType) TypeInt; }
			set { TypeInt = (int) value; }
		}

		public int WarGamesKills { get; set; }

		public int WarGamesDeaths { get; set; }

		public int WarGamesMedals { get; set; }

		public int WarGamesGames { get; set; }

		public string WarGamesDuration { get; set; }

		public int Players { get; set; }
	}
}
