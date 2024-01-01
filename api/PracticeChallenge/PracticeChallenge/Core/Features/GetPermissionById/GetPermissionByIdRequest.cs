using MediatR;

namespace PracticeChallenge.Core.Features.GetPermissionById
{
    public class GetPermissionByIdRequest : IRequest<GetPermissionByIdResponse>
    {
        public int Id { get; set; }
    }
}