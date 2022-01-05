
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using shared.Data;
using shared.models;

namespace shared
{
    public class GraphqlService
    {

        private readonly GraphQLHttpClient _graphqlClient =
            new GraphQLHttpClient("https://localhost:44301/graphql", new NewtonsoftJsonSerializer());

        private readonly GraphQLRequest _fetchUsers = new GraphQLRequest
        {
            Query = @"
                query fetch {
                   applicationUsers{
                     name,
                     email
                   }
                }
            ",  
            OperationName = "fetch"
        };

        public async Task<GraphQLResponse<ApplicationUsersData>> FetchApplicationUsers()
        {
            var fetchQuery = await _graphqlClient.SendQueryAsync<ApplicationUsersData>(_fetchUsers);
            return fetchQuery;
        }
    }
}
