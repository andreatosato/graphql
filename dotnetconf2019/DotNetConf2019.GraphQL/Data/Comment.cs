using NodaTime;
using System;

namespace DotNetConf2019.GraphQL.Data
{
    public class Comment
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public int PostId { get; set; }

        public DateTimeOffset SubmittedOn { get; set; }
        //public OffsetDateTime SubmittedOn { get; set; }
    }
}
