namespace demo_graphql.Mutations.Data
{
    public class StatusResult
    {
        public StatusResult(string message)
        {
            Status = message;
        }
        public string Status { get; set; }
    }
}
