using System;
using System.Collections.Generic;
using GameSparks.Core;
using GameSparks.Api.Requests;
using GameSparks.Api.Responses;

//THIS FILE IS AUTO GENERATED, DO NOT MODIFY!!
//THIS FILE IS AUTO GENERATED, DO NOT MODIFY!!
//THIS FILE IS AUTO GENERATED, DO NOT MODIFY!!

namespace GameSparks.Api.Requests{
	public class LogEventRequest_PostScore : GSTypedRequest<LogEventRequest_PostScore, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_PostScore() : base("LogEventRequest"){
			request.AddString("eventKey", "PostScore");
		}
		public LogEventRequest_PostScore Set_Score( long value )
		{
			request.AddNumber("Score", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_PostScore : GSTypedRequest<LogChallengeEventRequest_PostScore, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_PostScore() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "PostScore");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_PostScore SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_PostScore Set_Score( long value )
		{
			request.AddNumber("Score", value);
			return this;
		}			
	}
	
}
	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_HighscoreLeaderboard : GSTypedRequest<LeaderboardDataRequest_HighscoreLeaderboard,LeaderboardDataResponse_HighscoreLeaderboard>
	{
		public LeaderboardDataRequest_HighscoreLeaderboard() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "HighscoreLeaderboard");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_HighscoreLeaderboard (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_HighscoreLeaderboard SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_HighscoreLeaderboard SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_HighscoreLeaderboard SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_HighscoreLeaderboard SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_HighscoreLeaderboard SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_HighscoreLeaderboard SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_HighscoreLeaderboard SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_HighscoreLeaderboard SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_HighscoreLeaderboard SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_HighscoreLeaderboard : GSTypedRequest<AroundMeLeaderboardRequest_HighscoreLeaderboard,AroundMeLeaderboardResponse_HighscoreLeaderboard>
	{
		public AroundMeLeaderboardRequest_HighscoreLeaderboard() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "HighscoreLeaderboard");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_HighscoreLeaderboard (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_HighscoreLeaderboard SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_HighscoreLeaderboard SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_HighscoreLeaderboard SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_HighscoreLeaderboard SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_HighscoreLeaderboard SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_HighscoreLeaderboard SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_HighscoreLeaderboard SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_HighscoreLeaderboard : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_HighscoreLeaderboard(GSData data) : base(data){}
		public long? Score{
			get{return response.GetNumber("Score");}
		}
	}
	
	public class LeaderboardDataResponse_HighscoreLeaderboard : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_HighscoreLeaderboard(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_HighscoreLeaderboard> Data_HighscoreLeaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_HighscoreLeaderboard>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_HighscoreLeaderboard(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_HighscoreLeaderboard> First_HighscoreLeaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_HighscoreLeaderboard>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_HighscoreLeaderboard(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_HighscoreLeaderboard> Last_HighscoreLeaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_HighscoreLeaderboard>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_HighscoreLeaderboard(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_HighscoreLeaderboard : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_HighscoreLeaderboard(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_HighscoreLeaderboard> Data_HighscoreLeaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_HighscoreLeaderboard>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_HighscoreLeaderboard(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_HighscoreLeaderboard> First_HighscoreLeaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_HighscoreLeaderboard>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_HighscoreLeaderboard(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_HighscoreLeaderboard> Last_HighscoreLeaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_HighscoreLeaderboard>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_HighscoreLeaderboard(data);});}
		}
	}
}	

namespace GameSparks.Api.Messages {


}
