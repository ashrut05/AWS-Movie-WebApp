using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAshLab3.Models
{
    [DynamoDBTable("movie")]
    public class Movie
    {
        [DynamoDBHashKey]    //Partition key
        public int MovieID { get; set; }
        public string UserID { get; set; }
        public string MovieTitle { get; set; }
        public int Rating { get; set; }
        [DynamoDBProperty("Comments")]
        public Dictionary<string, string> MovieComments { get; set; }
        [DynamoDBProperty("Ratings")]
        public Dictionary<string, string> MovieRatings { get; set; }
        [DynamoDBProperty("Actors")]
        public List<string> MovieActors { get; set; }
    }
}
